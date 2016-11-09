using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //gsm.Update();
            //gsm.Render();

            //pbxGame.Invalidate();
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
