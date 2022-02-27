namespace Imaging5
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuNew = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnuInkClear = new System.Windows.Forms.MenuItem();
            this.mnuBcdClr = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.mnuSend = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuPen = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuLine = new System.Windows.Forms.MenuItem();
            this.mnuText = new System.Windows.Forms.MenuItem();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem3);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.mnuNew);
            this.menuItem1.MenuItems.Add(this.mnuOpen);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.mnuInkClear);
            this.menuItem1.MenuItems.Add(this.mnuBcdClr);
            this.menuItem1.MenuItems.Add(this.mnuSave);
            this.menuItem1.MenuItems.Add(this.mnuSend);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.MenuItems.Add(this.mnuExit);
            this.menuItem1.Text = "File";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // mnuNew
            // 
            this.mnuNew.Text = "New Canvas from Camera...";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Text = "Open Image for Canvas...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "-";
            // 
            // mnuInkClear
            // 
            this.mnuInkClear.Text = "Clear Ink";
            this.mnuInkClear.Click += new System.EventHandler(this.mnuInkClear_Click);
            // 
            // mnuBcdClr
            // 
            this.mnuBcdClr.Text = "Clear Ink and Canvas";
            this.mnuBcdClr.Click += new System.EventHandler(this.mnuBcdClr_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Text = "Save Drawing As...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSend
            // 
            this.mnuSend.Text = "Send Drawing...";
            this.mnuSend.Click += new System.EventHandler(this.mnuSend_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.MenuItems.Add(this.mnuPen);
            this.menuItem3.MenuItems.Add(this.menuItem4);
            this.menuItem3.MenuItems.Add(this.mnuLine);
            this.menuItem3.MenuItems.Add(this.mnuText);
            this.menuItem3.Text = "Draw";
            // 
            // mnuPen
            // 
            this.mnuPen.Text = "Select Pen...";
            this.mnuPen.Click += new System.EventHandler(this.mnuPen_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "-";
            // 
            // mnuLine
            // 
            this.mnuLine.Text = "Draw Line";
            this.mnuLine.Click += new System.EventHandler(this.mnuLine_Click);
            // 
            // mnuText
            // 
            this.mnuText.Text = "Draw Text...";
            this.mnuText.Click += new System.EventHandler(this.mnuText_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All Files" +
                "|*.*";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 244);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 24);
            this.statusBar1.Text = "statusBar1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.statusBar1);
            this.Menu = this.mainMenu1;
            this.Name = "Main";
            this.Text = "CEImager5";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem mnuOpen;
        private System.Windows.Forms.MenuItem mnuSave;
        private System.Windows.Forms.MenuItem mnuNew;
        private System.Windows.Forms.MenuItem mnuSend;

        private System.Windows.Forms.MenuItem mnuPen;
        private System.Windows.Forms.MenuItem mnuText;
        private System.Windows.Forms.MenuItem mnuInkClear;
        private System.Windows.Forms.MenuItem mnuLine;

        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.MenuItem mnuBcdClr;
        private System.Windows.Forms.MenuItem menuItem6;
    }
}

