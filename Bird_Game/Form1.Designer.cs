namespace Bird_Game
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
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.Blokalt = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bloküst = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.intimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blokalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloküst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Zemin
            // 
            this.Zemin.Image = global::Bird_Game.Properties.Resources.ground;
            this.Zemin.Location = new System.Drawing.Point(-4, 330);
            this.Zemin.Margin = new System.Windows.Forms.Padding(4);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(1159, 128);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 6;
            this.Zemin.TabStop = false;
            // 
            // Blokalt
            // 
            this.Blokalt.Image = global::Bird_Game.Properties.Resources.pipe;
            this.Blokalt.Location = new System.Drawing.Point(553, 228);
            this.Blokalt.Margin = new System.Windows.Forms.Padding(4);
            this.Blokalt.Name = "Blokalt";
            this.Blokalt.Size = new System.Drawing.Size(133, 106);
            this.Blokalt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Blokalt.TabIndex = 5;
            this.Blokalt.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Bird_Game.Properties.Resources.dddEkran_görüntüsü_2023_10_04_213441;
            this.pictureBox4.Location = new System.Drawing.Point(77, 105);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // bloküst
            // 
            this.bloküst.Image = global::Bird_Game.Properties.Resources.pipedown;
            this.bloküst.Location = new System.Drawing.Point(667, 0);
            this.bloküst.Margin = new System.Windows.Forms.Padding(4);
            this.bloküst.Name = "bloküst";
            this.bloküst.Size = new System.Drawing.Size(133, 114);
            this.bloküst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bloküst.TabIndex = 1;
            this.bloküst.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bird_Game.Properties.Resources._89_893933_torres_del_paine_background;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1159, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.GameTimer);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gamekeydown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gamekeyup);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score";
            // 
            // intimer
            // 
            this.intimer.Enabled = true;
            this.intimer.Interval = 20;
            this.intimer.Tick += new System.EventHandler(this.GameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.Blokalt);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bloküst);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "UcanKus";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blokalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloküst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bloküst;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Blokalt;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer intimer;
    }
}

