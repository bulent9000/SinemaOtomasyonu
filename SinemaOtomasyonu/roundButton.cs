﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    class roundButton : Button
    {


        protected override void OnPaint(PaintEventArgs pevent)
        {

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(gp);


            base.OnPaint(pevent);

          

        }



    }



}

