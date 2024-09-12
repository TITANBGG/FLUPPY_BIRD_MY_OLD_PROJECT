namespace FluppyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FlyBird = new System.Windows.Forms.PictureBox();
            this.BlokAsagi = new System.Windows.Forms.PictureBox();
            this.BlokYukari = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlokAsagi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlokYukari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FluppyBird.Properties.Resources.Nasihatler_arkaplan_resimleri_054_1024x576;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FlyBird
            // 
            this.FlyBird.Image = global::FluppyBird.Properties.Resources.dddEkran_görüntüsü_2023_10_04_213441;
            this.FlyBird.Location = new System.Drawing.Point(74, 60);
            this.FlyBird.Name = "FlyBird";
            this.FlyBird.Size = new System.Drawing.Size(100, 93);
            this.FlyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlyBird.TabIndex = 1;
            this.FlyBird.TabStop = false;
            // 
            // BlokAsagi
            // 
            this.BlokAsagi.Image = global::FluppyBird.Properties.Resources.pipedown;
            this.BlokAsagi.Location = new System.Drawing.Point(304, 1);
            this.BlokAsagi.Name = "BlokAsagi";
            this.BlokAsagi.Size = new System.Drawing.Size(100, 69);
            this.BlokAsagi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlokAsagi.TabIndex = 2;
            this.BlokAsagi.TabStop = false;
            // 
            // BlokYukari
            // 
            this.BlokYukari.Image = global::FluppyBird.Properties.Resources.pipe;
            this.BlokYukari.Location = new System.Drawing.Point(375, 257);
            this.BlokYukari.Name = "BlokYukari";
            this.BlokYukari.Size = new System.Drawing.Size(100, 70);
            this.BlokYukari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlokYukari.TabIndex = 3;
            this.BlokYukari.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = global::FluppyBird.Properties.Resources.ground;
            this.Zemin.Location = new System.Drawing.Point(-1, 323);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(553, 121);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 4;
            this.Zemin.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoEllipsis = true;
            this.ScoreText.AutoSize = true;
            this.ScoreText.Location = new System.Drawing.Point(24, 371);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(35, 16);
            this.ScoreText.TabIndex = 5;
            this.ScoreText.Text = "Skor";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 437);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.BlokYukari);
            this.Controls.Add(this.BlokAsagi);
            this.Controls.Add(this.FlyBird);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlokAsagi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlokYukari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox FlyBird;
        private System.Windows.Forms.PictureBox BlokAsagi;
        private System.Windows.Forms.PictureBox BlokYukari;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}

