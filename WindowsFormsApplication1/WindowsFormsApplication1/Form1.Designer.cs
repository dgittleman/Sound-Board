namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.backPic = new System.Windows.Forms.PictureBox();
            this.picTubeR = new System.Windows.Forms.PictureBox();
            this.picTubeL = new System.Windows.Forms.PictureBox();
            this.picPit = new System.Windows.Forms.PictureBox();
            this.picCoin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTubeR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTubeL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // backPic
            // 
            this.backPic.Location = new System.Drawing.Point(0, 0);
            this.backPic.Name = "backPic";
            this.backPic.Size = new System.Drawing.Size(750, 446);
            this.backPic.TabIndex = 0;
            this.backPic.TabStop = false;
            this.backPic.MouseEnter += new System.EventHandler(this.backPic_MouseEnter);
            // 
            // picTubeR
            // 
            this.picTubeR.Location = new System.Drawing.Point(656, 334);
            this.picTubeR.Name = "picTubeR";
            this.picTubeR.Size = new System.Drawing.Size(64, 64);
            this.picTubeR.TabIndex = 3;
            this.picTubeR.TabStop = false;
            this.picTubeR.Click += new System.EventHandler(this.picTubeR_Click);
            this.picTubeR.MouseEnter += new System.EventHandler(this.picTubeR_MouseEnter);
            // 
            // picTubeL
            // 
            this.picTubeL.Location = new System.Drawing.Point(31, 334);
            this.picTubeL.Name = "picTubeL";
            this.picTubeL.Size = new System.Drawing.Size(64, 64);
            this.picTubeL.TabIndex = 4;
            this.picTubeL.TabStop = false;
            this.picTubeL.Click += new System.EventHandler(this.picTubeL_Click);
            this.picTubeL.MouseEnter += new System.EventHandler(this.picTubeL_MouseEnter);
            // 
            // picPit
            // 
            this.picPit.Location = new System.Drawing.Point(456, 399);
            this.picPit.Name = "picPit";
            this.picPit.Size = new System.Drawing.Size(142, 49);
            this.picPit.TabIndex = 5;
            this.picPit.TabStop = false;
            // 
            // picCoin
            // 
            this.picCoin.Location = new System.Drawing.Point(214, 272);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(164, 32);
            this.picCoin.TabIndex = 6;
            this.picCoin.TabStop = false;
            this.picCoin.MouseEnter += new System.EventHandler(this.picCoin_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 447);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.picPit);
            this.Controls.Add(this.picTubeL);
            this.Controls.Add(this.picTubeR);
            this.Controls.Add(this.backPic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTubeR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTubeL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backPic;
        private System.Windows.Forms.PictureBox picTubeR;
        private System.Windows.Forms.PictureBox picTubeL;
        private System.Windows.Forms.PictureBox picPit;
        private System.Windows.Forms.PictureBox picCoin;
    }
}

