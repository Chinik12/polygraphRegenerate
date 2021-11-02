using Polygraph.Core.DM;
using System;
using System.IO;
using System.Text.Json;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace Polygraph.Core
{
    public class Polydraw
    {
        private int Scale;
        public Bitmap Bmp;
        public Graphics Grp;
        private BackgroundColor BackgroundColor;


        public Polydraw(int Scale, BackgroundColor backgroundcolor)
        {
            this.Scale = Scale;
            this.Bmp = new Bitmap(400 * Scale, 400 * Scale);
            this.Grp = Graphics.FromImage(Bmp);
            this.BackgroundColor = backgroundcolor;
            Grp.Clear(backgroundcolor.Color);
        }

        public Polydraw(Polyimage pi):this(pi.Scale, pi.Backgroundcolor)
        {
            
        }        

        public void Save(string filename, ImageFormat png)
        {
            Bmp.Save(filename, ImageFormat.Png);
        }

        


    }
}
