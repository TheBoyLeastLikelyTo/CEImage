using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Imaging5
{
    public partial class SelectPen : Form
    {
        public SelectPen()
        {
            InitializeComponent();
           
            cmbColor.SelectedIndex = 0;
        }

        public Color PenColor
        {
            get
            {
                Color c;
                switch (cmbColor.SelectedItem as string)
                {
                    default:
                    case "Black":
                        c = Color.Black;
                        break;
                    case "Blue":
                        c = Color.Blue;
                        break;
                    case "Gray":
                        c = Color.Gray;
                        break;
                    case "Green":
                        c = Color.Green;
                        break;
                    case "Orange":
                        c = Color.Orange;
                        break;
                    case "Pink":
                        c = Color.Pink;
                        break;
                    case "Purple":
                        c = Color.Purple;
                        break;
                    case "Red":
                        c = Color.Red;
                        break;
                    case "White":
                        c = Color.White;
                        break;
                    case "Yellow":
                        c = Color.Yellow;
                        break;
                }
                return c;
            }
        }

        public float PenSize
        {
            get { return Convert.ToSingle(numSize.Value); }
        }

        private void cmbColor_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = cmbColor.SelectedIndex == -1;
        }
	
    }
}