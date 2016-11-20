namespace SpaceChickens
{
    partial class SpaceChickens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceChickens));
            this.bgwDrawing = new System.ComponentModel.BackgroundWorker();
            this.pbxGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwDrawing
            // 
            this.bgwDrawing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDrawing_DoWork);
            // 
            // pbxGame
            // 
            this.pbxGame.Location = new System.Drawing.Point(0, 0);
            this.pbxGame.Name = "pbxGame";
            this.pbxGame.Size = new System.Drawing.Size(1481, 540);
            this.pbxGame.TabIndex = 0;
            this.pbxGame.TabStop = false;
            // 
            // SpaceChickens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1481, 540);
            this.Controls.Add(this.pbxGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpaceChickens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Chickens";
            this.Shown += new System.EventHandler(SpaceChickens_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwDrawing;
        private System.Windows.Forms.PictureBox pbxGame;
    }
}

