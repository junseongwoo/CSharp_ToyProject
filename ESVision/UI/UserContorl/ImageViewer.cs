﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESVision
{
    public partial class ImageViewer : UserControl
    {
        private Image image;
        public ImageViewer()
        {
            InitializeComponent();
        }

        public Image Image
        {
            get => image;
            set
            {
                image = value;
                Invalidate();
            }
        }

        private void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(image, new Rectangle(0, 0, Width, Height));
        }
    }
}
