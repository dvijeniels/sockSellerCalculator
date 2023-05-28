namespace Kassa
{
    partial class frmSatislar
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
            this.ustPanel = new System.Windows.Forms.Panel();
            this.opisanie = new System.Windows.Forms.Label();
            this.Cikis = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.İlaçlar = new System.Windows.Forms.GroupBox();
            this.dtgSatilacak = new System.Windows.Forms.DataGridView();
            this.lbToplamFiyatYazi = new System.Windows.Forms.Label();
            this.lbtoplamfiyat = new System.Windows.Forms.Label();
            this.txtHesap = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbparaUstu = new System.Windows.Forms.Label();
            this.btnHesapla = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOde = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbToplamFiyatAgent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).BeginInit();
            this.İlaçlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSatilacak)).BeginInit();
            this.SuspendLayout();
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.ustPanel.Controls.Add(this.opisanie);
            this.ustPanel.Controls.Add(this.Cikis);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(854, 33);
            this.ustPanel.TabIndex = 2;
            // 
            // opisanie
            // 
            this.opisanie.AutoSize = true;
            this.opisanie.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisanie.Location = new System.Drawing.Point(382, 1);
            this.opisanie.Name = "opisanie";
            this.opisanie.Size = new System.Drawing.Size(103, 26);
            this.opisanie.TabIndex = 10;
            this.opisanie.Text = "Продать";
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Red;
            this.Cikis.BackgroundImage = global::Kassa.Properties.Resources.multiply_48px;
            this.Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cikis.Location = new System.Drawing.Point(820, 0);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(34, 34);
            this.Cikis.TabIndex = 9;
            this.Cikis.TabStop = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.ustPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.opisanie;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // İlaçlar
            // 
            this.İlaçlar.Controls.Add(this.dtgSatilacak);
            this.İlaçlar.Location = new System.Drawing.Point(15, 50);
            this.İlaçlar.Name = "İlaçlar";
            this.İlaçlar.Size = new System.Drawing.Size(821, 413);
            this.İlaçlar.TabIndex = 42;
            this.İlaçlar.TabStop = false;
            this.İlaçlar.Text = "Будут проданы";
            // 
            // dtgSatilacak
            // 
            this.dtgSatilacak.AllowDrop = true;
            this.dtgSatilacak.AllowUserToAddRows = false;
            this.dtgSatilacak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSatilacak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSatilacak.Location = new System.Drawing.Point(6, 15);
            this.dtgSatilacak.Name = "dtgSatilacak";
            this.dtgSatilacak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSatilacak.Size = new System.Drawing.Size(807, 392);
            this.dtgSatilacak.TabIndex = 20;
            this.dtgSatilacak.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSatilacak_CellDoubleClick);
            this.dtgSatilacak.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSatilacak_CellValueChanged);
            // 
            // lbToplamFiyatYazi
            // 
            this.lbToplamFiyatYazi.AutoSize = true;
            this.lbToplamFiyatYazi.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToplamFiyatYazi.Location = new System.Drawing.Point(356, 478);
            this.lbToplamFiyatYazi.Name = "lbToplamFiyatYazi";
            this.lbToplamFiyatYazi.Size = new System.Drawing.Size(303, 37);
            this.lbToplamFiyatYazi.TabIndex = 45;
            this.lbToplamFiyatYazi.Text = "Общая сумма для ОРК:";
            // 
            // lbtoplamfiyat
            // 
            this.lbtoplamfiyat.AutoSize = true;
            this.lbtoplamfiyat.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtoplamfiyat.Location = new System.Drawing.Point(665, 478);
            this.lbtoplamfiyat.Name = "lbtoplamfiyat";
            this.lbtoplamfiyat.Size = new System.Drawing.Size(29, 37);
            this.lbtoplamfiyat.TabIndex = 46;
            this.lbtoplamfiyat.Text = "0";
            // 
            // txtHesap
            // 
            this.txtHesap.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtHesap.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHesap.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtHesap.BorderThickness = 3;
            this.txtHesap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHesap.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHesap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHesap.isPassword = false;
            this.txtHesap.Location = new System.Drawing.Point(389, 556);
            this.txtHesap.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesap.Name = "txtHesap";
            this.txtHesap.Size = new System.Drawing.Size(127, 33);
            this.txtHesap.TabIndex = 47;
            this.txtHesap.Text = "Автокалькулятор";
            this.txtHesap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHesap.Enter += new System.EventHandler(this.txtHesap_Enter);
            this.txtHesap.Leave += new System.EventHandler(this.txtHesap_Leave);
            // 
            // lbparaUstu
            // 
            this.lbparaUstu.AutoSize = true;
            this.lbparaUstu.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbparaUstu.Location = new System.Drawing.Point(540, 559);
            this.lbparaUstu.Name = "lbparaUstu";
            this.lbparaUstu.Size = new System.Drawing.Size(76, 29);
            this.lbparaUstu.TabIndex = 45;
            this.lbparaUstu.Text = "Сдачи:";
            this.lbparaUstu.Visible = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(200)))));
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnHesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapla.BorderRadius = 0;
            this.btnHesapla.ButtonText = "Рассчитать";
            this.btnHesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapla.DisabledColor = System.Drawing.Color.Gray;
            this.btnHesapla.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHesapla.Iconimage = global::Kassa.Properties.Resources.calculator_100px;
            this.btnHesapla.Iconimage_right = null;
            this.btnHesapla.Iconimage_right_Selected = null;
            this.btnHesapla.Iconimage_Selected = null;
            this.btnHesapla.IconMarginLeft = 0;
            this.btnHesapla.IconMarginRight = 0;
            this.btnHesapla.IconRightVisible = true;
            this.btnHesapla.IconRightZoom = 0D;
            this.btnHesapla.IconVisible = true;
            this.btnHesapla.IconZoom = 90D;
            this.btnHesapla.IsTab = false;
            this.btnHesapla.Location = new System.Drawing.Point(389, 597);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnHesapla.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.btnHesapla.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHesapla.selected = false;
            this.btnHesapla.Size = new System.Drawing.Size(127, 36);
            this.btnHesapla.TabIndex = 34;
            this.btnHesapla.Text = "Рассчитать";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapla.Textcolor = System.Drawing.Color.White;
            this.btnHesapla.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnOde
            // 
            this.btnOde.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(200)))));
            this.btnOde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnOde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOde.BorderRadius = 0;
            this.btnOde.ButtonText = "СОХРАНИТЬ";
            this.btnOde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOde.DisabledColor = System.Drawing.Color.Gray;
            this.btnOde.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOde.Iconimage = global::Kassa.Properties.Resources.save_100px;
            this.btnOde.Iconimage_right = null;
            this.btnOde.Iconimage_right_Selected = null;
            this.btnOde.Iconimage_Selected = null;
            this.btnOde.IconMarginLeft = 0;
            this.btnOde.IconMarginRight = 0;
            this.btnOde.IconRightVisible = true;
            this.btnOde.IconRightZoom = 0D;
            this.btnOde.IconVisible = true;
            this.btnOde.IconZoom = 90D;
            this.btnOde.IsTab = false;
            this.btnOde.Location = new System.Drawing.Point(17, 478);
            this.btnOde.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnOde.Name = "btnOde";
            this.btnOde.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnOde.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.btnOde.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOde.selected = false;
            this.btnOde.Size = new System.Drawing.Size(146, 36);
            this.btnOde.TabIndex = 34;
            this.btnOde.Text = "СОХРАНИТЬ";
            this.btnOde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOde.Textcolor = System.Drawing.Color.White;
            this.btnOde.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // lbToplamFiyatAgent
            // 
            this.lbToplamFiyatAgent.AutoSize = true;
            this.lbToplamFiyatAgent.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToplamFiyatAgent.Location = new System.Drawing.Point(665, 515);
            this.lbToplamFiyatAgent.Name = "lbToplamFiyatAgent";
            this.lbToplamFiyatAgent.Size = new System.Drawing.Size(29, 37);
            this.lbToplamFiyatAgent.TabIndex = 55;
            this.lbToplamFiyatAgent.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 37);
            this.label2.TabIndex = 54;
            this.label2.Text = "Общая сумма агента:";
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 647);
            this.Controls.Add(this.lbToplamFiyatAgent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHesap);
            this.Controls.Add(this.lbtoplamfiyat);
            this.Controls.Add(this.lbparaUstu);
            this.Controls.Add(this.lbToplamFiyatYazi);
            this.Controls.Add(this.İlaçlar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.ustPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSatislar";
            this.Load += new System.EventHandler(this.frmSatislar_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).EndInit();
            this.İlaçlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSatilacak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.Label opisanie;
        private System.Windows.Forms.PictureBox Cikis;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnOde;
        private System.Windows.Forms.GroupBox İlaçlar;
        private System.Windows.Forms.DataGridView dtgSatilacak;
        private System.Windows.Forms.Label lbtoplamfiyat;
        private System.Windows.Forms.Label lbToplamFiyatYazi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHesap;
        private Bunifu.Framework.UI.BunifuFlatButton btnHesapla;
        private System.Windows.Forms.Label lbparaUstu;
        private System.Windows.Forms.Label lbToplamFiyatAgent;
        private System.Windows.Forms.Label label2;
    }
}