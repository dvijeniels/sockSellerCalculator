namespace Kassa
{
    partial class Index
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.yazi = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.UstPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Cikis = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCikis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGiriss = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKullanici = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.yazi;
            this.bunifuDragControl1.Vertical = true;
            // 
            // yazi
            // 
            this.yazi.AutoSize = true;
            this.yazi.BackColor = System.Drawing.Color.Transparent;
            this.yazi.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yazi.Location = new System.Drawing.Point(124, 5);
            this.yazi.Name = "yazi";
            this.yazi.Size = new System.Drawing.Size(151, 24);
            this.yazi.TabIndex = 11;
            this.yazi.Text = "Вход в аптеку";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.UstPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // UstPanel
            // 
            this.UstPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UstPanel.BackgroundImage")));
            this.UstPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UstPanel.Controls.Add(this.yazi);
            this.UstPanel.Controls.Add(this.Cikis);
            this.UstPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UstPanel.GradientBottomLeft = System.Drawing.Color.Violet;
            this.UstPanel.GradientBottomRight = System.Drawing.Color.DarkSlateGray;
            this.UstPanel.GradientTopLeft = System.Drawing.Color.DimGray;
            this.UstPanel.GradientTopRight = System.Drawing.Color.Indigo;
            this.UstPanel.Location = new System.Drawing.Point(0, 0);
            this.UstPanel.Name = "UstPanel";
            this.UstPanel.Quality = 10;
            this.UstPanel.Size = new System.Drawing.Size(403, 35);
            this.UstPanel.TabIndex = 4;
            // 
            // Cikis
            // 
            this.Cikis.BackgroundImage = global::Kassa.Properties.Resources.multiply_48px;
            this.Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cikis.Location = new System.Drawing.Point(367, 0);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(34, 34);
            this.Cikis.TabIndex = 8;
            this.Cikis.TabStop = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnCikis);
            this.bunifuGradientPanel1.Controls.Add(this.btnGiriss);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.txtSifre);
            this.bunifuGradientPanel1.Controls.Add(this.UstPanel);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(403, 446);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.BorderRadius = 0;
            this.btnCikis.ButtonText = "Выйти";
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DisabledColor = System.Drawing.Color.Gray;
            this.btnCikis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCikis.Iconimage = global::Kassa.Properties.Resources.door_sensor_alarmed_40px1;
            this.btnCikis.Iconimage_right = null;
            this.btnCikis.Iconimage_right_Selected = null;
            this.btnCikis.Iconimage_Selected = null;
            this.btnCikis.IconMarginLeft = 0;
            this.btnCikis.IconMarginRight = 0;
            this.btnCikis.IconRightVisible = true;
            this.btnCikis.IconRightZoom = 0D;
            this.btnCikis.IconVisible = true;
            this.btnCikis.IconZoom = 90D;
            this.btnCikis.IsTab = false;
            this.btnCikis.Location = new System.Drawing.Point(90, 360);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCikis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCikis.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCikis.selected = false;
            this.btnCikis.Size = new System.Drawing.Size(215, 41);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "Выйти";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Textcolor = System.Drawing.Color.White;
            this.btnCikis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // btnGiriss
            // 
            this.btnGiriss.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGiriss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGiriss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiriss.BorderRadius = 0;
            this.btnGiriss.ButtonText = "Войти";
            this.btnGiriss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiriss.DisabledColor = System.Drawing.Color.Gray;
            this.btnGiriss.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGiriss.Iconimage = global::Kassa.Properties.Resources.enter_key_80px;
            this.btnGiriss.Iconimage_right = null;
            this.btnGiriss.Iconimage_right_Selected = null;
            this.btnGiriss.Iconimage_Selected = null;
            this.btnGiriss.IconMarginLeft = 0;
            this.btnGiriss.IconMarginRight = 0;
            this.btnGiriss.IconRightVisible = true;
            this.btnGiriss.IconRightZoom = 0D;
            this.btnGiriss.IconVisible = true;
            this.btnGiriss.IconZoom = 90D;
            this.btnGiriss.IsTab = false;
            this.btnGiriss.Location = new System.Drawing.Point(90, 301);
            this.btnGiriss.Name = "btnGiriss";
            this.btnGiriss.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGiriss.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGiriss.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiriss.selected = false;
            this.btnGiriss.Size = new System.Drawing.Size(215, 41);
            this.btnGiriss.TabIndex = 13;
            this.btnGiriss.Text = "Войти";
            this.btnGiriss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiriss.Textcolor = System.Drawing.Color.White;
            this.btnGiriss.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiriss.Click += new System.EventHandler(this.btnGiriss_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtKullanici);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(53, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 56);
            this.panel1.TabIndex = 12;
            // 
            // txtKullanici
            // 
            this.txtKullanici.FormattingEnabled = true;
            this.txtKullanici.Location = new System.Drawing.Point(11, 20);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(273, 32);
            this.txtKullanici.TabIndex = 11;
            this.txtKullanici.SelectedIndexChanged += new System.EventHandler(this.txtKullanici_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(134, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 112);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtSifre
            // 
            this.txtSifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSifre.BorderThickness = 3;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.isPassword = false;
            this.txtSifre.Location = new System.Drawing.Point(64, 241);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(273, 40);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.Text = "Пароль";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // Index
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(403, 446);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Index_Load);
            this.UstPanel.ResumeLayout(false);
            this.UstPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel UstPanel;
        private System.Windows.Forms.Label yazi;
        private System.Windows.Forms.PictureBox Cikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtKullanici;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGiriss;
        private Bunifu.Framework.UI.BunifuFlatButton btnCikis;
    }
}

