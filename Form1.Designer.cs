namespace Imaging5
{
    partial class Form1
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
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuClear = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.mnuSend = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuPen = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuLine = new System.Windows.Forms.MenuItem();
            this.mnuText = new System.Windows.Forms.MenuItem();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
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
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.mnuClear);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.mnuSave);
            this.menuItem1.MenuItems.Add(this.mnuSend);
            this.menuItem1.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Text = "New Background";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Text = "Open Background";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "-";
            // 
            // mnuClear
            // 
            this.mnuClear.Text = "Clear Drawing";
            this.mnuClear.Click += new System.EventHandler(this.mnuClear_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "-";
            // 
            // mnuSave
            // 
            this.mnuSave.Text = "Save Image As...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSend
            // 
            this.mnuSend.Text = "Save and Send";
            this.mnuSend.Click += new System.EventHandler(this.mnuSend_Click);
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
            this.dlgSave.Filter = "Image files|*.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Simon\'s Imaging App";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuOpen;
        private System.Windows.Forms.MenuItem mnuSave;
        private System.Windows.Forms.MenuItem mnuNew;
        private System.Windows.Forms.MenuItem mnuSend;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuPen;
        private System.Windows.Forms.MenuItem mnuText;
        private System.Windows.Forms.MenuItem mnuClear;
        private System.Windows.Forms.MenuItem mnuLine;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

