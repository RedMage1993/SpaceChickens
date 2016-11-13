using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SpaceChickens
{
    public partial class SpaceChickens : Form
    {
        private DirectBitmap dbmp;
        private Graphics graphics;
        private GameScreenManager gsm;

        public SpaceChickens()
        {
            InitializeComponent();

            dbmp = new DirectBitmap(pbxGame.Width, pbxGame.Height);
            graphics = Graphics.FromImage(dbmp.Bitmap);
            gsm = new GameScreenManager(graphics);
        }

        private void SpaceChickens_Shown(object sender, System.EventArgs e)
        {
            Application.DoEvents();

            gsm.Push(new StartMenu(gsm));
            bgwDrawing.RunWorkerAsync();
        }

        private void bgwDrawing_DoWork(object sender, DoWorkEventArgs e)
        {
            Stopwatch dt = new Stopwatch();
            float tempDt = 0.0f;

            dt.Start();
            while (gsm.Update(tempDt))
            {
                gsm.Render();
                pbxGame.Invalidate();

                //Thread.Sleep(1);

                // Temporary (not going to use dt right now).
                // This sets a cap on how fast game can run.
                while (dt.ElapsedMilliseconds < 30)
                    Thread.Sleep(1);

                tempDt = dt.ElapsedMilliseconds / 1000.0f;
                dt.Reset();
                dt.Start();
            }

            dt.Stop();
        }

        private void bgwDrawing_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            gsm.Dispose();
            graphics.Dispose();
            dbmp.Dispose();

            Application.Exit();
        }
    }
}
