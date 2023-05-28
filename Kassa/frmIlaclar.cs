using Kassa.VeriTabanlar;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kassa
{
    public partial class frmIlaclar : Form
    {
        public frmIlaclar()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void Cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите закрыть?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtAdi_Enter(object sender, EventArgs e)
        {
            if (txtAdi.Text== "Название товара")
            {
                txtAdi.Text = "";
            }
        }


        private void txtAdi_Leave(object sender, EventArgs e)
        {
            if (txtAdi.Text == "")
            {
                txtAdi.Text = "Название товара";
            }
        }

        private void txtFiyat_Enter(object sender, EventArgs e)
        {
            if (txtFiyat.Text == "Закупочная цена")
            {
                txtFiyat.Text = "";
            }
        }

        private void txtFiyat_Leave(object sender, EventArgs e)
        {
            if (txtFiyat.Text == "")
            {
                txtFiyat.Text = "Закупочная цена";
            }
        }
        private void txtFiyat2_Enter(object sender, EventArgs e)
        {
            if (txtFiyat2.Text == "Розничная цена")
            {
                txtFiyat2.Text = "";
            }
        }
        private void txtFiyat2_Leave(object sender, EventArgs e)
        {
            if (txtFiyat2.Text == "")
            {
                txtFiyat2.Text = "Розничная цена";
            }
        }
        private void txtStok_Enter(object sender, EventArgs e)
        {
            if (txtStok.Text == "Штук(Запасов)")
            {
                txtStok.Text = "";
            }
        }

        private void txtStok_Leave(object sender, EventArgs e)
        {
            if (txtStok.Text == "")
            {
                txtStok.Text = "Штук(Запасов)";
            }
        }
        void ilacgetir()
        {
            var deger = from items1 in db.Products
                        where items1.Status==false
                        orderby items1.Name ascending
                        select new { items1.ID,Название_товара=items1.Name, Закупочная_Цена = items1.PurchasePrice, Розничная_Цена =items1.RetailPrice,Запасы=items1.Qty};
            dtgIlac.DataSource = deger.ToList();
            dtgIlac.Columns[0].Visible = false;
        }
        private void frmIlaclar_Load(object sender, EventArgs e)
        {
            ilacgetir();
            txtAdi.Select();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool sonuc = true;
            if (txtAdi.Text!="Название товара" && txtFiyat.Text!="Закупочная цена" && txtFiyat2.Text != "Розничная цена" && txtStok.Text!= "Штук(Запасов)")
            {
                try
                {
                    for (int i = 0; i < dtgIlac.Rows.Count; i++)
                    {
                        if (dtgIlac.Rows[i].Cells[1].Value.ToString()==txtAdi.Text)
                        {
                             sonuc = false;
                        }
                    }
                    if (sonuc)
                    {
                        Product ilac = new Product();
                        ilac.Name = txtAdi.Text;
                        ilac.PurchasePrice = Convert.ToDecimal(txtFiyat.Text);
                        ilac.RetailPrice = Convert.ToDecimal(txtFiyat2.Text);
                        ilac.Qty = Convert.ToInt32(txtStok.Text);
                        db.Products.Add(ilac);
                        db.SaveChanges();
                        MessageBox.Show("Успешно добавлено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ilacgetir();
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("Такой товар уже существует!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Пожалуйста введите число!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста для начала заполните!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       

        private void btnBul_Click(object sender, EventArgs e)
        {
        }
        private void txtAra_Enter(object sender, EventArgs e)
        {
            if (txtAra.Text=="Поиск")
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

        private void txtAra_OnValueChanged(object sender, EventArgs e)
        {
            if (txtAra.Text!= "Поиск")
            {
                var temp = from item in db.Products
                           where item.Name.Contains(txtAra.Text)
                select new { item.ID, Название_товара = item.Name, Закупочная_Цена = item.PurchasePrice, Розничная_Цена = item.RetailPrice, Запасы = item.Qty};
                dtgIlac.DataSource = temp.ToList();
            }
            else
            {
                ilacgetir();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != "Название товара" && txtFiyat.Text != "Закупочная цена" && txtFiyat2.Text != "Розничная цена" && txtStok.Text != "Штук(Запасов)")
            {
                try
                {
                    var temp = db.Products.Find(Convert.ToInt32(ilacID.Text));
                    temp.Name = txtAdi.Text;
                    temp.PurchasePrice = Convert.ToDecimal(txtFiyat.Text);
                    temp.RetailPrice = Convert.ToDecimal(txtFiyat2.Text);
                    temp.Qty = Convert.ToInt32(txtStok.Text);
                    MessageBox.Show("Успешно изменено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();
                    ilacgetir();
                    temizle();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Пожалуйста введите число!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        void temizle()
        {
            txtAdi.Text = "Название товара";
            txtFiyat.Text = "Закупочная цена";
            txtFiyat2.Text = "Розничная цена";
            txtStok.Text = "Штук(Запасов)";
        }
        private void dtgIlac_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ilacID.Text = dtgIlac.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dtgIlac.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dtgIlac.CurrentRow.Cells[2].Value.ToString();
            txtFiyat2.Text = dtgIlac.CurrentRow.Cells[3].Value.ToString();
            txtStok.Text = dtgIlac.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (ilacID.Text!="Id")
            {
                if (MessageBox.Show("Хотите удалить?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    var sil = db.Products.Find(Convert.ToInt32(ilacID.Text));
                    sil.Status = true;
                    db.SaveChanges();
                    ilacgetir();
                    MessageBox.Show("Успешно удалено!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста для удаления выберите из списка!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgIlac_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ilacID.Text = dtgIlac.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dtgIlac.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dtgIlac.CurrentRow.Cells[2].Value.ToString();
            txtFiyat2.Text = dtgIlac.CurrentRow.Cells[3].Value.ToString();
            txtStok.Text = dtgIlac.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
