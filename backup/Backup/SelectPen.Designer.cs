namespace Imaging5
{
    partial class SelectPen
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(84, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select";
            // 
            // cmbColor
            // 
            this.cmbColor.Items.Add("Black");
            this.cmbColor.Items.Add("Blue");
            this.cmbColor.Items.Add("Brown");
            this.cmbColor.Items.Add("Gray");
            this.cmbColor.Items.Add("Green");
            this.cmbColor.Items.Add("Orange");
            this.cmbColor.Items.Add("Pink");
            this.cmbColor.Items.Add("Purple");
            this.cmbColor.Items.Add("Red");
            this.cmbColor.Items.Add("White");
            this.cmbColor.Items.Add("Yellow");
            this.cmbColor.Location = new System.Drawing.Point(113, 36);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(100, 26);
            this.cmbColor.TabIndex = 1;
            this.cmbColor.Validating += new System.ComponentModel.CancelEventHandler(this.cmbColor_Validating);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Size";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(113, 73);
            this.numSize.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(100, 26);
            this.numSize.TabIndex = 4;
            this.numSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SelectPen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.button1);
            this.Menu = this.mainMenu1;
            this.Name = "SelectPen";
            this.Text = "Select Pen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSize;
    }
}