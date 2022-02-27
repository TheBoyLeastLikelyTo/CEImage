using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.WindowsCE.Forms;

namespace Imaging5
{
    public partial class TextDialog : Form
    {
        public TextDialog()
        {
            InitializeComponent();
        }

        public string EnteredText
        {
            get { return txtText.Text; }
        }

        public int EnteredSize
        {
            get
            {
                switch (ddlSize.SelectedItem as string)
                {
                    case "Small":
                    default:
                        return 12;
                    case "Medium":
                        return 16;
                    case "Large":
                        return 20;
                }
            }
        }

        public Font GetFont(Point p1, Point p2, float dpi)
        {
            int y = -(p2.Y - p1.Y); //adjust for inverted y axis
            int x = p2.X - p1.X;
            int angle = (int)(Math.Atan2(y, x) * 180 / Math.PI);
            
            //adjust for quadrant
            if (y < 0)
            {
                angle = 360 + angle;
            }

            LogFont lf = new LogFont();
            lf.Height = (int)(-EnteredSize * dpi / 96);
            lf.Escapement = angle * 10;
            lf.Orientation = lf.Escapement;
            lf.FaceName = Font.Name;

            return Font.FromLogFont(lf);
        }
    }
}