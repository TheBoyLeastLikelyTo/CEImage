using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.WindowsMobile.Forms;
using Microsoft.WindowsMobile.PocketOutlook;
using Microsoft.WindowsMobile.Status;

using System.Drawing.Imaging;

namespace Imaging5
{
    public partial class Main : Form
    {
        Bitmap _overlay;
        Bitmap _background;
        Color _transparentColor = Color.AliceBlue;//any color not in the pen dialog will do

        private void ClearOverlay()
        {
            using (Graphics og = Graphics.FromImage(_overlay))
            {
                using (Brush tb = new SolidBrush(_transparentColor))
                {
                    //fill overlay with our transparent color
                    og.FillRectangle(tb, 0, 0, _overlay.Width, _overlay.Height);
                }
            }

            Invalidate(ClientRectangle);
        }

        private void SetBackground(string filename)
        {
            using (Bitmap srcImage = new Bitmap(filename))
            {
                using (Graphics g = Graphics.FromImage(_background))
                {
                    g.DrawImage(srcImage, 
                        new Rectangle(0, 0, _background.Width, _background.Height), 
                        new Rectangle(0, 0, srcImage.Width, srcImage.Height), 
                        GraphicsUnit.Pixel);
                }
            }
        }

        public Main()
        {
            InitializeComponent();

            int width = ClientRectangle.Width; //240; 
            int height = ClientRectangle.Height; //268;
            _overlay = new Bitmap(width, height);
            _background = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(_background))
            {
                using (Brush b = new SolidBrush(Color.LightGray))
                {
                    g.FillRectangle(b, 0, 0, _background.Width, _background.Height);
                }
            }

            ClearOverlay();

            //check for a camera
            mnuNew.Enabled = SystemState.CameraPresent;

            //check for email accounts
            using (OutlookSession session = new OutlookSession())
            {
                mnuSend.Enabled = session.EmailAccounts.Count > 0;
            }

            //set status bar

            statusBar1.Text = "Ready, Blank Canvas";
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            using (SelectPictureDialog dlgPic = new SelectPictureDialog())
            {
                dlgPic.Title = "Open Picture";
                //dlgPic.CameraAccess = true;

                if (dlgPic.ShowDialog() == DialogResult.OK)
                {
                   SetBackground(dlgPic.FileName);
                   statusBar1.Text = "Canvas Image Ready, Unsaved";
                }
            }
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            using (CameraCaptureDialog dlgCam = new CameraCaptureDialog())
            {
                dlgCam.Title = "New Picture";
                dlgCam.Mode = CameraCaptureMode.Still;
                dlgCam.StillQuality = CameraCaptureStillQuality.Default;

                if (dlgCam.ShowDialog() == DialogResult.OK)
                {
                   SetBackground(dlgCam.FileName);
                   statusBar1.Text = "Canvas Image Ready, Unsaved";
                }
            }
        }

        //returns the filename of the saved image so Send can use it
        private string SaveImage()
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Bitmap newImage = new Bitmap(_background))
                    {
                        using (Graphics g = Graphics.FromImage(newImage))
                        {
                            DrawOverlay(g, new Rectangle(0, 0, _overlay.Width, _overlay.Height));
                        }

                        newImage.Save(dlgSave.FileName, ImageFormat.Bmp);
                        statusBar1.Text = "Canvas Image Ready, Saved";
                    }

                    System.Windows.Forms.DialogResult dialogresult = MessageBox.Show("Save Successful!","Saving Drawing");
                    return dlgSave.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't save bitmap to " + dlgSave.FileName + ": " + ex.Message,"Error");
                }
            }

            return null;
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void mnuSend_Click(object sender, EventArgs e)
        {
            string filename = SaveImage();
            if (filename != null)
            {
                //pick a contact
                using (ChooseContactDialog dlgContact = new ChooseContactDialog())
                {
                    dlgContact.HideNew = true;
                    dlgContact.RequiredProperties = new ContactProperty[1];
                    dlgContact.RequiredProperties[0] = ContactProperty.Email1Address;

                    if (dlgContact.ShowDialog() == DialogResult.OK)
                    {
                        //send an email
                        EmailMessage msg = new EmailMessage();
                        msg.To.Add(new Recipient(dlgContact.SelectedContact.Email1Address));
                        msg.Subject = "Here is an image I created...";
                        msg.BodyText = "...using Windows Mobile 5";
                        msg.Attachments.Add(new Attachment(filename));

                        using (OutlookSession outlook = new OutlookSession())
                        {
                            outlook.EmailAccounts[0].Send(msg);
                        }

                        MessageBox.Show("Send Successful.","Sending Drawing");
                    }
                }
            }
        }

        private Pen _pen = new Pen(Color.Blue, 1.0f);

        private void mnuPen_Click(object sender, EventArgs e)
        {            
            using (SelectPen dlgPen = new SelectPen())
            {
                if (dlgPen.ShowDialog() == DialogResult.OK)
                    {
                        _pen.Dispose();
                        _pen = new Pen(dlgPen.PenColor, dlgPen.PenSize);
                    }
             }
        }

        private void DrawOverlay(Graphics g, Rectangle region)
        {
            ImageAttributes attribs = new ImageAttributes();
            attribs.SetColorKey(_transparentColor, _transparentColor);

            g.DrawImage(_overlay, region, region.X, region.Y,
                region.Width, region.Height, GraphicsUnit.Pixel, attribs);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_background, e.ClipRectangle, e.ClipRectangle, GraphicsUnit.Pixel);

            DrawOverlay(e.Graphics, e.ClipRectangle);
        }

        bool _drawText = false;
        int _pointCount = -1;
        Point[] _points = new Point[2];


        private void mnuLine_Click(object sender, EventArgs e)
        {
            statusBar1.Text = "Select first point";
            _pointCount = 0;
            _drawText = false;
        }

        private void mnuText_Click(object sender, EventArgs e)
        {
            statusBar1.Text = "Select first point";
            _pointCount = 0;
            _drawText = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_pointCount >= 0)
            {
                _points[_pointCount] = new Point(e.X, e.Y);
                _pointCount++;

                if (_pointCount == 1)
                {
                    statusBar1.Text = "Select the second point";
                }
                else
                {
                    using (Graphics g = Graphics.FromImage(_overlay))
                    {
                        if (_drawText)
                        {
                            using (TextDialog dlg = new TextDialog())
                            {
                                if (dlg.ShowDialog() == DialogResult.OK)
                                {
                                    using (SolidBrush brush = new SolidBrush(_pen.Color))
                                    {
                                        g.DrawString(dlg.EnteredText,
                                            dlg.GetFont(_points[0], _points[1], g.DpiY), brush,
                                            _points[0].X, _points[0].Y, new StringFormat(StringFormatFlags.NoClip | StringFormatFlags.NoWrap));
                                        
                                    }
                                }
                            }
                            statusBar1.Text = "Canvas Image Ready, Unsaved";
                        }
                        else
                        {
                            g.DrawLine(_pen, _points[0].X, _points[0].Y, _points[1].X, _points[1].Y);
                            statusBar1.Text = "Canvas Image Ready, Unsaved";
                        }
                    }
                    Invalidate(ClientRectangle);

                    Text = "Imaging5";
                    _pointCount = -1;
                }
            }
        }

        private void mnuInkClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear Ink?", "Clear Ink", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                ClearOverlay();
                statusBar1.Text = "Canvas Image Ready, Unsaved";
            }
        }

        private void mnuBcdClr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear Ink and Canvas?", "Clear Canvas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                ClearOverlay();
                using (Graphics g = Graphics.FromImage(_background))
                {
                    using (Brush b = new SolidBrush(Color.LightGray))
                    {
                        g.FillRectangle(b, 0, 0, _background.Width, _background.Height);
                    }
                }
                statusBar1.Text = "Ready, Blank Canvas";
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }


    }
}