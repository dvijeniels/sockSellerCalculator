using Kassa.VeriTabanlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        Context db = new Context();

        private void btnilac_Click(object sender, EventArgs e)
        {
            frmIlaclar frm = new frmIlaclar();
            frm.ShowDialog();
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            frm.ShowDialog();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            frmSatislar frm = new frmSatislar();
            frm.ShowDialog();

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            frm.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            //var temp = db.Mudurs.Where(x => x.MudurId == Giris.mudurID);
            var temp2 = from gelenid in db.Users
                        where gelenid.ID == Giris.mudurID
                        select gelenid.Name;
            AdSoyad.Text = temp2.First();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
