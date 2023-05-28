namespace Kassa
{
    partial class frmRaporlar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ustPanel = new System.Windows.Forms.Panel();
            this.opisanie = new System.Windows.Forms.Label();
            this.Cikis = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SatislarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatislarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.ustPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.ustPanel.Controls.Add(this.opisanie);
            this.ustPanel.Controls.Add(this.Cikis);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(800, 33);
            this.ustPanel.TabIndex = 2;
            // 
            // opisanie
            // 
            this.opisanie.AutoSize = true;
            this.opisanie.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisanie.Location = new System.Drawing.Point(324, 4);
            this.opisanie.Name = "opisanie";
            this.opisanie.Size = new System.Drawing.Size(139, 26);
            this.opisanie.TabIndex = 10;
            this.opisanie.Text = "Распечатка";
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Red;
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SatislarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kassa.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 417);
            this.reportViewer1.TabIndex = 3;
            // 
            // SatislarBindingSource
            // 
            this.SatislarBindingSource.DataSource = typeof(Kassa.VeriTabanlar.Sold);
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.ustPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRaporlar";
            this.Text = "frmRaporlar";
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatislarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.Label opisanie;
        private System.Windows.Forms.PictureBox Cikis;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SatislarBindingSource;
    }
}