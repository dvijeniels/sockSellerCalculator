using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kassa.VeriTabanlar;

namespace Kassa
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
       
        Context db = new Context();
        private void Index_Load(object sender, EventArgs e)
        {
            //var temp = db.Mudurs.Select(x => x.AdiSoyadi );
            //txtKullanici.DataSource = temp.ToList();
            txtKullanici.DataSource = db.Users.ToList();
            txtKullanici.DisplayMember = "Name";
            txtKullanici.ValueMember = "ID";
        }
        private void Cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
           
        }
        private void txtKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mudur mudur = (Mudur)txtKullanici.SelectedItem;
            //Giris.mudurID = mudur.MudurId;
            ///mudur.MudurId;
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var temp = from p in db.Users where p.ID == (int)txtKullanici.SelectedValue && p.Password == txtSifre.Text select p;
            //var deger = db.Mudurs.Where(x => x.MudurId==Convert.ToInt32(textBox1.Text) && x.Sifre==txtSifre.Text).SingleOrDefault();
            if(temp.Any())
            {
                Anasayfa f1 = new Anasayfa();
                f1.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Не правильно!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if(txtSifre.Text== "Пароль")
            {
                txtSifre.Text = "";
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Пароль";
            }
        }

        private void btnGiriss_Click(object sender, EventArgs e)
        {
            int mudurid = (int)txtKullanici.SelectedValue;
            Giris.mudurID = mudurid;
            var temp = from p in db.Users where p.ID == mudurid && p.Password == txtSifre.Text select p;
            //var deger = db.Mudurs.Where(x => x.MudurId==Convert.ToInt32(textBox1.Text) && x.Sifre==txtSifre.Text).SingleOrDefault();
            if (temp.Any())
            {
                Anasayfa f1 = new Anasayfa();
                f1.Show();
                this.Hide();
            }
            
        }
        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    public class Giris
    {
        public static int mudurID;
    }
}
