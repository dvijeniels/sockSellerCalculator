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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void Cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtAdi_Enter(object sender, EventArgs e)
        {
            if (txtAdi.Text== "Имя и Фамилия")
            {
                txtAdi.Text = "";
            }
        }

        private void txtAdi_Leave(object sender, EventArgs e)
        {
            if (txtAdi.Text == "")
            {
                txtAdi.Text = "Имя и Фамилия";
            }
        }

        private void txtKullanici_Enter(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "Логин")
            {
                txtKullanici.Text = "";
            }
        }

        private void txtKullanici_Leave(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "")
            {
                txtKullanici.Text = "Логин";
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Пароль")
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

        private void txtTelefon_Enter(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "Телефон номер")
            {
                txtTelefon.Text = "";
            }
        }

        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "")
            {
                txtTelefon.Text = "Телефон номер";
            }
        }

        private void txtAra_Enter(object sender, EventArgs e)
        {
            if (txtAra.Text == "Поиск")
            {
                txtAra.Text = "";
            }
        }

        private void txtAra_Leave(object sender, EventArgs e)
        {
            if (txtAra.Text == "")
            {
                txtAra.Text = "Поиск";
            }
        }
        void mudurGetir()
        {
            var temp = from item in db.Users
                       where item.Status == false
                       select new { item.ID, Имя_и_Фамилия=item.Name, Логин=item.KullaniciAdi, Телефон=item.TelNumara, Пароль=item.Password };
            dataGridView1.DataSource = temp.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
        void temizle()
        {
            txtAdi.Text = "Имя и Фамилия";
            txtTelefon.Text = "Телефон номер";
            txtKullanici.Text = "Логин";
            txtSifre.isPassword = true;
            txtSifre.Text = "Пароль";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool sonuc = true;
            if (txtAdi.Text != "Имя и Фамилия" & txtAdi.Text != ""& txtTelefon.Text != "Телефон номер"& txtSifre.Text!="Пароль")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txtAdi.Text)
                    {
                        sonuc = false;
                    }
                }
                if (sonuc)
                {
                    User mud = new User();
                    mud.Name = txtAdi.Text;
                    mud.TelNumara = txtTelefon.Text;
                    mud.KullaniciAdi = txtKullanici.Text;
                    mud.Password = txtSifre.Text;
                    db.Users.Add(mud);
                    db.SaveChanges();
                    MessageBox.Show("Успешно добавлено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mudurGetir();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Руководитель с таким именем уже существует!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста для начала заполните!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            mudurGetir();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mudId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKullanici.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSifre.isPassword = true;
            txtSifre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != "Имя и Фамилия" & txtAdi.Text != "" & txtTelefon.Text != "Телефон номер" & txtSifre.Text != "Пароль")
            {
                var mud = db.Users.Find(Convert.ToInt32(mudId.Text));
                mud.Name = txtAdi.Text;
                mud.TelNumara = txtTelefon.Text;
                mud.KullaniciAdi = txtKullanici.Text;
                mud.Password = txtSifre.Text;
                db.SaveChanges();
                MessageBox.Show("Руководитель успешно изменено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mudurGetir();
                temizle();
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните для начало!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (txtAdi.Text != "Имя и Фамилия" && mudId.Text != "Id")
            {
                if (MessageBox.Show("Хотите удалить?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    var sil = db.Users.Find(Convert.ToInt32(mudId.Text));
                    sil.Status = true;
                    db.SaveChanges();
                    mudurGetir();
                    MessageBox.Show("Успешно удалено!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }
            else
            {
                MessageBox.Show("Выберите руководителя для удаления!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            if (txtAra.Text != "Поиск")
            {
                var temp = from item in db.Users
                           where item.Name.Contains(txtAra.Text) && item.Status == false
                           select new { item.ID, Имя_и_Фамилия = item.Name, Логин = item.KullaniciAdi, Телефон = item.TelNumara, Пароль = item.Password };
                dataGridView1.DataSource = temp.ToList();
            }
            else
            {
                mudurGetir();
            }
        }
    }
}
