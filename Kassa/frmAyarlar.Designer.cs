namespace Kassa
{
    partial class frmAyarlar
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ustPanel = new System.Windows.Forms.Panel();
            this.txtAra = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.opisanie = new System.Windows.Forms.Label();
            this.Cikis = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnSil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuncelle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTelefon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtKullanici = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mudId = new System.Windows.Forms.Label();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.ustPanel.Controls.Add(this.txtAra);
            this.ustPanel.Controls.Add(this.opisanie);
            this.ustPanel.Controls.Add(this.Cikis);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(800, 33);
            this.ustPanel.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAra.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAra.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAra.BorderThickness = 3;
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAra.ForeColor = System.Drawing.Color.White;
            this.txtAra.isPassword = false;
            this.txtAra.Location = new System.Drawing.Point(56, 3);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(225, 27);
            this.txtAra.TabIndex = 38;
            this.txtAra.Text = "Поиск";
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            this.txtAra.Enter += new System.EventHandler(this.txtAra_Enter);
            this.txtAra.Leave += new System.EventHandler(this.txtAra_Leave);
            // 
            // opisanie
            // 
            this.opisanie.AutoSize = true;
            this.opisanie.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisanie.Location = new System.Drawing.Point(324, 4);
            this.opisanie.Name = "opisanie";
            this.opisanie.Size = new System.Drawing.Size(152, 26);
            this.opisanie.TabIndex = 10;
            this.opisanie.Text = "НАСТРОЙКИ";
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Red;
            this.Cikis.BackgroundImage = global::Kassa.Properties.Resources.multiply_48px;
            this.Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cikis.Location = new System.Drawing.Point(763, -1);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(34, 34);
            this.Cikis.TabIndex = 9;
            this.Cikis.TabStop = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.opisanie;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.ustPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btnSil
            // 
            this.btnSil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(200)))));
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.BorderRadius = 0;
            this.btnSil.ButtonText = "УДАЛИТЬ";
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.DisabledColor = System.Drawing.Color.Gray;
            this.btnSil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSil.Iconimage = global::Kassa.Properties.Resources.delete_bin_100px;
            this.btnSil.Iconimage_right = null;
            this.btnSil.Iconimage_right_Selected = null;
            this.btnSil.Iconimage_Selected = null;
            this.btnSil.IconMarginLeft = 0;
            this.btnSil.IconMarginRight = 0;
            this.btnSil.IconRightVisible = true;
            this.btnSil.IconRightZoom = 0D;
            this.btnSil.IconVisible = true;
            this.btnSil.IconZoom = 90D;
            this.btnSil.IsTab = false;
            this.btnSil.Location = new System.Drawing.Point(13, 321);
            this.btnSil.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnSil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.btnSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSil.selected = false;
            this.btnSil.Size = new System.Drawing.Size(187, 36);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "УДАЛИТЬ";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Textcolor = System.Drawing.Color.White;
            this.btnSil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(200)))));
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.BorderRadius = 0;
            this.btnGuncelle.ButtonText = "ИЗМЕНИТЬ";
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuncelle.Iconimage = global::Kassa.Properties.Resources.available_updates_100px;
            this.btnGuncelle.Iconimage_right = null;
            this.btnGuncelle.Iconimage_right_Selected = null;
            this.btnGuncelle.Iconimage_Selected = null;
            this.btnGuncelle.IconMarginLeft = 0;
            this.btnGuncelle.IconMarginRight = 0;
            this.btnGuncelle.IconRightVisible = true;
            this.btnGuncelle.IconRightZoom = 0D;
            this.btnGuncelle.IconVisible = true;
            this.btnGuncelle.IconZoom = 90D;
            this.btnGuncelle.IsTab = false;
            this.btnGuncelle.Location = new System.Drawing.Point(13, 273);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnGuncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.btnGuncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuncelle.selected = false;
            this.btnGuncelle.Size = new System.Drawing.Size(187, 36);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "ИЗМЕНИТЬ";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Textcolor = System.Drawing.Color.White;
            this.btnGuncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(200)))));
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.BorderRadius = 0;
            this.btnKaydet.ButtonText = "СОХРАНИТЬ";
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.DisabledColor = System.Drawing.Color.Gray;
            this.btnKaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKaydet.Iconimage = global::Kassa.Properties.Resources.save_100px;
            this.btnKaydet.Iconimage_right = null;
            this.btnKaydet.Iconimage_right_Selected = null;
            this.btnKaydet.Iconimage_Selected = null;
            this.btnKaydet.IconMarginLeft = 0;
            this.btnKaydet.IconMarginRight = 0;
            this.btnKaydet.IconRightVisible = true;
            this.btnKaydet.IconRightZoom = 0D;
            this.btnKaydet.IconVisible = true;
            this.btnKaydet.IconZoom = 90D;
            this.btnKaydet.IsTab = false;
            this.btnKaydet.Location = new System.Drawing.Point(13, 229);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnKaydet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(187, 36);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "СОХРАНИТЬ";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Textcolor = System.Drawing.Color.White;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTelefon.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefon.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTelefon.BorderThickness = 3;
            this.txtTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefon.ForeColor = System.Drawing.Color.White;
            this.txtTelefon.isPassword = false;
            this.txtTelefon.Location = new System.Drawing.Point(264, 385);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(187, 44);
            this.txtTelefon.TabIndex = 8;
            this.txtTelefon.Text = "Телефон номер";
            this.txtTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefon.Enter += new System.EventHandler(this.txtTelefon_Enter);
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSifre.BorderThickness = 3;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.isPassword = false;
            this.txtSifre.Location = new System.Drawing.Point(264, 333);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(187, 44);
            this.txtSifre.TabIndex = 9;
            this.txtSifre.Text = "Пароль";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // txtKullanici
            // 
            this.txtKullanici.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtKullanici.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKullanici.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtKullanici.BorderThickness = 3;
            this.txtKullanici.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullanici.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKullanici.ForeColor = System.Drawing.Color.White;
            this.txtKullanici.isPassword = false;
            this.txtKullanici.Location = new System.Drawing.Point(264, 281);
            this.txtKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(187, 44);
            this.txtKullanici.TabIndex = 10;
            this.txtKullanici.Text = "Логин";
            this.txtKullanici.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKullanici.Enter += new System.EventHandler(this.txtKullanici_Enter);
            this.txtKullanici.Leave += new System.EventHandler(this.txtKullanici_Leave);
            // 
            // txtAdi
            // 
            this.txtAdi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAdi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAdi.BorderThickness = 3;
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAdi.ForeColor = System.Drawing.Color.White;
            this.txtAdi.isPassword = false;
            this.txtAdi.Location = new System.Drawing.Point(264, 229);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(187, 44);
            this.txtAdi.TabIndex = 11;
            this.txtAdi.Text = "Имя и Фамилия";
            this.txtAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdi.Enter += new System.EventHandler(this.txtAdi_Enter);
            this.txtAdi.Leave += new System.EventHandler(this.txtAdi_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(775, 174);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mudId
            // 
            this.mudId.AutoSize = true;
            this.mudId.Location = new System.Drawing.Point(222, 241);
            this.mudId.Name = "mudId";
            this.mudId.Size = new System.Drawing.Size(16, 13);
            this.mudId.TabIndex = 18;
            this.mudId.Text = "Id";
            this.mudId.Visible = false;
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mudId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.ustPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAyarlar";
            this.Text = "frmAyarlar";
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.PictureBox Cikis;
        private System.Windows.Forms.Label opisanie;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSil;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuncelle;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTelefon;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSifre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtKullanici;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAra;
        private System.Windows.Forms.Label mudId;
    }
}