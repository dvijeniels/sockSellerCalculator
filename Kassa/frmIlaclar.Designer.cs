namespace Kassa
{
    
    partial class frmIlaclar
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
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ustPanel = new System.Windows.Forms.Panel();
            this.Cikis = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFiyat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStok = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAra = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ilacID = new System.Windows.Forms.Label();
            this.txtFiyat2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dtgIlac = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBul = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuncelle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIlac)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.Vertical = true;
            // 
            // opisanie
            // 
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.ustPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.ustPanel.Controls.Add(this.Cikis);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(712, 33);
            this.ustPanel.TabIndex = 2;
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Red;
            this.Cikis.BackgroundImage = global::Kassa.Properties.Resources.multiply_48px;
            this.Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cikis.Location = new System.Drawing.Point(675, -1);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(34, 34);
            this.Cikis.TabIndex = 9;
            this.Cikis.TabStop = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtAdi
            // 
            this.txtAdi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAdi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAdi.BorderThickness = 3;
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdi.isPassword = false;
            this.txtAdi.Location = new System.Drawing.Point(236, 232);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(187, 44);
            this.txtAdi.TabIndex = 4;
            this.txtAdi.Text = "Название товара";
            this.txtAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdi.Enter += new System.EventHandler(this.txtAdi_Enter);
            this.txtAdi.Leave += new System.EventHandler(this.txtAdi_Leave);
            // 
            // txtFiyat
            // 
            this.txtFiyat.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFiyat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiyat.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtFiyat.BorderThickness = 3;
            this.txtFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiyat.isPassword = false;
            this.txtFiyat.Location = new System.Drawing.Point(236, 284);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(187, 44);
            this.txtFiyat.TabIndex = 4;
            this.txtFiyat.Text = "Закупочная цена";
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiyat.Enter += new System.EventHandler(this.txtFiyat_Enter);
            this.txtFiyat.Leave += new System.EventHandler(this.txtFiyat_Leave);
            // 
            // txtStok
            // 
            this.txtStok.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStok.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStok.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtStok.BorderThickness = 3;
            this.txtStok.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStok.isPassword = false;
            this.txtStok.Location = new System.Drawing.Point(236, 388);
            this.txtStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(187, 44);
            this.txtStok.TabIndex = 4;
            this.txtStok.Text = "Штук(Запасов)";
            this.txtStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStok.Enter += new System.EventHandler(this.txtStok_Enter);
            this.txtStok.Leave += new System.EventHandler(this.txtStok_Leave);
            // 
            // txtAra
            // 
            this.txtAra.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAra.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAra.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAra.BorderThickness = 3;
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAra.isPassword = false;
            this.txtAra.Location = new System.Drawing.Point(17, 368);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(187, 44);
            this.txtAra.TabIndex = 4;
            this.txtAra.Text = "Поиск";
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAra.OnValueChanged += new System.EventHandler(this.txtAra_OnValueChanged);
            this.txtAra.Enter += new System.EventHandler(this.txtAra_Enter);
            this.txtAra.Leave += new System.EventHandler(this.txtAra_Leave);
            // 
            // ilacID
            // 
            this.ilacID.AutoSize = true;
            this.ilacID.Location = new System.Drawing.Point(213, 246);
            this.ilacID.Name = "ilacID";
            this.ilacID.Size = new System.Drawing.Size(16, 13);
            this.ilacID.TabIndex = 16;
            this.ilacID.Text = "Id";
            this.ilacID.Visible = false;
            // 
            // txtFiyat2
            // 
            this.txtFiyat2.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFiyat2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiyat2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtFiyat2.BorderThickness = 3;
            this.txtFiyat2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyat2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFiyat2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiyat2.isPassword = false;
            this.txtFiyat2.Location = new System.Drawing.Point(236, 336);
            this.txtFiyat2.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat2.Name = "txtFiyat2";
            this.txtFiyat2.Size = new System.Drawing.Size(187, 44);
            this.txtFiyat2.TabIndex = 17;
            this.txtFiyat2.Text = "Розничная цена";
            this.txtFiyat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiyat2.Enter += new System.EventHandler(this.txtFiyat2_Enter);
            this.txtFiyat2.Leave += new System.EventHandler(this.txtFiyat_Leave);
            // 
            // dtgIlac
            // 
            this.dtgIlac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgIlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIlac.Location = new System.Drawing.Point(12, 39);
            this.dtgIlac.Name = "dtgIlac";
            this.dtgIlac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgIlac.Size = new System.Drawing.Size(688, 164);
            this.dtgIlac.TabIndex = 18;
            this.dtgIlac.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgIlac_CellDoubleClick_1);
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
            this.btnKaydet.Location = new System.Drawing.Point(17, 232);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnKaydet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(187, 36);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "СОХРАНИТЬ";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Textcolor = System.Drawing.Color.White;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
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
            this.btnSil.Location = new System.Drawing.Point(17, 316);
            this.btnSil.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnSil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.btnSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSil.selected = false;
            this.btnSil.Size = new System.Drawing.Size(187, 36);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "УДАЛИТЬ";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Textcolor = System.Drawing.Color.White;
            this.btnSil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnBul
            // 
            this.btnBul.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(200)))));
            this.btnBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnBul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBul.BorderRadius = 0;
            this.btnBul.ButtonText = "НАЙТИ";
            this.btnBul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBul.DisabledColor = System.Drawing.Color.Gray;
            this.btnBul.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBul.Iconimage = global::Kassa.Properties.Resources.google_web_search_100px;
            this.btnBul.Iconimage_right = null;
            this.btnBul.Iconimage_right_Selected = null;
            this.btnBul.Iconimage_Selected = null;
            this.btnBul.IconMarginLeft = 0;
            this.btnBul.IconMarginRight = 0;
            this.btnBul.IconRightVisible = true;
            this.btnBul.IconRightZoom = 0D;
            this.btnBul.IconVisible = true;
            this.btnBul.IconZoom = 90D;
            this.btnBul.IsTab = false;
            this.btnBul.Location = new System.Drawing.Point(17, 430);
            this.btnBul.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnBul.Name = "btnBul";
            this.btnBul.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnBul.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.btnBul.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBul.selected = false;
            this.btnBul.Size = new System.Drawing.Size(187, 36);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "НАЙТИ";
            this.btnBul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBul.Textcolor = System.Drawing.Color.White;
            this.btnBul.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
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
            this.btnGuncelle.Location = new System.Drawing.Point(17, 274);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnGuncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(23)))), ((int)(((byte)(100)))));
            this.btnGuncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuncelle.selected = false;
            this.btnGuncelle.Size = new System.Drawing.Size(187, 36);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "ИЗМЕНИТЬ";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Textcolor = System.Drawing.Color.White;
            this.btnGuncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmIlaclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 475);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtFiyat2);
            this.Controls.Add(this.ilacID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.dtgIlac);
            this.Controls.Add(this.ustPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIlaclar";
            this.Text = "frmIlaclar";
            this.Load += new System.EventHandler(this.frmIlaclar_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIlac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.PictureBox Cikis;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStok;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFiyat;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAdi;
        private Bunifu.Framework.UI.BunifuFlatButton btnSil;
        private Bunifu.Framework.UI.BunifuFlatButton btnBul;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuncelle;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAra;
        private System.Windows.Forms.Label ilacID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFiyat2;
        private System.Windows.Forms.DataGridView dtgIlac;
    }
}