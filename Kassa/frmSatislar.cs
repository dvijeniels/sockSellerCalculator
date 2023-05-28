using Kassa.VeriTabanlar;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa
{
    public partial class frmSatislar : Form
    {
        public frmSatislar()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void Cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите закрыть?\nВыбранные вами товары будут отменены!!!", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        void workersGet()
        {
            var query = from p in db.Products
                        where p.Status == false
                        orderby p.Name ascending
                        select p;
            dtgSatilacak.DataSource = query.ToList();
            dtgSatilacak.Columns[1].Width = 250;
            dtgSatilacak.Columns[2].Visible = false;
            dtgSatilacak.Columns[1].ReadOnly = true;
            dtgSatilacak.Columns[3].Visible = false;
            dtgSatilacak.Columns[4].Visible = false;
            dtgSatilacak.Columns[5].Visible = false;
            dtgSatilacak.Columns[6].Visible = false;
            dtgSatilacak.Columns.Add("setSocks", "Кол-во взятых");
            dtgSatilacak.Columns.Add("getSocks", "Кол-во принятых");
            dtgSatilacak.Columns.Add("moneysORK", "Цена для ОРК");
            dtgSatilacak.Columns.Add("moneysAgent", "Цена для агента");
            dtgSatilacak.Columns[9].ReadOnly = true;
            dtgSatilacak.Columns[10].ReadOnly = true;
            dtgSatilacak.Columns[0].Visible = false;
            //dtgSatilacak.Rows.Add(db.Products.Where(a => a.Status == false).ToList());

        
    }
        private void frmSatislar_Load(object sender, EventArgs e)
        {
            workersGet();
            dtgSatilacak.Refresh();
        }
/*        private void dtgilac_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool result = false; int temp = 0;
            int id = Convert.ToInt32(dtgilac.CurrentRow.Cells[0].Value.ToString());
            //DataGridViewRow row = dtgilac.CurrentRow;
            if (dtgSatilacak.Rows.Count > 0)
            {
                for (int i = 0; i < dtgSatilacak.Rows.Count; i++)
                {
                    if (dtgSatilacak.Rows[i].Cells[1].Value.ToString() == dtgilac.CurrentRow.Cells[1].Value.ToString())
                    {
                        result = true;
                        temp = i;
                        break;
                    }
                }
                if (result)
                {
                    DataGridViewRow newDataRow = dtgSatilacak.Rows[temp];
                    newDataRow.Cells[3].Value = Convert.ToString(Convert.ToInt32(newDataRow.Cells[3].Value) + Convert.ToInt32(1));
                    newDataRow.Cells[4].Value = Convert.ToDouble(newDataRow.Cells[3].Value) * Convert.ToDouble(dtgilac.CurrentRow.Cells[2].Value.ToString());
                    lbtoplamfiyat.Text = Convert.ToString(Convert.ToInt32(dtgilac.CurrentRow.Cells[2].Value) + Convert.ToInt32(lbtoplamfiyat.Text));
                    var ilacid = db.Ilaclars.Find(id);
                    ilacid.KutuStok = ilacid.KutuStok - 1;
                    db.SaveChanges();
                    ilacGetir();
                }
                else
                {
                    dtgSatilacak.Rows.Add(dtgilac.CurrentRow.Cells[0].Value.ToString(),
                                dtgilac.CurrentRow.Cells[1].Value.ToString(),
                                dtgilac.CurrentRow.Cells[2].Value.ToString(),
                                dtgilac.CurrentRow.Cells[3].Value = 1,
                                dtgilac.CurrentRow.Cells[2].Value.ToString());
                    lbtoplamfiyat.Text = Convert.ToString(Convert.ToInt32(dtgilac.CurrentRow.Cells[2].Value) + Convert.ToInt32(lbtoplamfiyat.Text));
                    var ilacid = db.Ilaclars.Find(id);
                    ilacid.KutuStok = ilacid.KutuStok - 1;
                    db.SaveChanges();
                    ilacGetir();
                }
            }
            else
            {
                
                //DataGridViewRow newDataRowilac = dtgilac.Rows[Convert.ToInt32(dtgilac.CurrentCell.RowIndex)];
                //newDataRowilac.Cells[3].Value= Convert.ToString(Convert.ToInt32(newDataRowilac.Cells[3].Value) - Convert.ToInt32(1));
                dtgSatilacak.Rows.Add(dtgilac.CurrentRow.Cells[0].Value.ToString(),
                                dtgilac.CurrentRow.Cells[1].Value.ToString(),
                                dtgilac.CurrentRow.Cells[2].Value.ToString(),
                                dtgilac.CurrentRow.Cells[3].Value = 1,
                                dtgilac.CurrentRow.Cells[2].Value.ToString());
                lbtoplamfiyat.Text = dtgilac.CurrentRow.Cells[2].Value.ToString();
                var ilacid = db.Ilaclars.Find(id);
                ilacid.KutuStok = ilacid.KutuStok - 1;
                db.SaveChanges();
                ilacGetir();
            }
        }*/
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lbparaUstu.Visible = true;
            if (txtHesap.Text != "" && txtHesap.Text != "Автокалькулятор")
            {
                if (Convert.ToDouble(lbtoplamfiyat.Text) > Convert.ToDouble(txtHesap.Text))
                {
                    lbparaUstu.Text = Convert.ToString(Math.Abs(Convert.ToDouble(lbtoplamfiyat.Text) - Convert.ToDouble(txtHesap.Text))) + " Рублей ещё не хватает";
                }
                else
                {
                    lbparaUstu.Text = Convert.ToString(Math.Abs(Convert.ToDouble(lbtoplamfiyat.Text) - Convert.ToDouble(txtHesap.Text))) + " Рублей сдачи";
                }
            }
            else MessageBox.Show("Не оставляйте поле пустым! Введите число!!!", "Предупреждение!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void txtHesap_Enter(object sender, EventArgs e)
        {
            if (txtHesap.Text== "Автокалькулятор")
            {
                txtHesap.Text="";
            }
        }

        private void txtHesap_Leave(object sender, EventArgs e)
        {
            if (txtHesap.Text == "")
            {
                txtHesap.Text = "Автокалькулятор";
            }
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            Sold sat = new Sold();
            if (dtgSatilacak.Rows.Count > 0)
            {
                for (int i = 0; i < dtgSatilacak.Rows.Count; i++)
                {
                    sat.Tarih = DateTime.Now;
                    sat.WorkerPriceTotal = Convert.ToDecimal(lbToplamFiyatAgent.Text);
                    sat.CompanyPriceTotal = Convert.ToDecimal(lbtoplamfiyat.Text);
                    sat.UserId = 1;
                    //for (int i = 0; i < dtgSatilacak.Rows.Count; i++)
                    //{
                    //    sat.ProductId = Convert.ToInt32(dtgSatilacak.Rows[i].Cells[0].Value.ToString());
                    //}
                    
                    db.Solds.Add(sat);
                    db.SaveChanges();
                }
                MessageBox.Show("Успешно сохранен", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgSatilacak.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Заполните сначала!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            dtgSatilacak.Rows.Clear();
        }

        private void dtgSatilacak_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dtgSatilacak.Rows.Count > 0)
            //{
            //    foreach (DataGridViewRow item in this.dtgSatilacak.SelectedRows)
            //    {
            //        dtgSatilacak.Rows.RemoveAt(item.Index);
            //    }
            //}
        }

        private void dtgSatilacak_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal PriceCompany=0, PriceAgent=0;
            if (dtgSatilacak.Rows.Count!=0 )
            {
                int kalan = Convert.ToInt32(Convert.ToInt32(dtgSatilacak.SelectedCells[7].Value) - Convert.ToInt32(dtgSatilacak.SelectedCells[8].Value));
                int agent = Convert.ToInt32(Convert.ToInt32(dtgSatilacak.SelectedCells[4].Value) - Convert.ToInt32(dtgSatilacak.SelectedCells[3].Value));
                //int agent = Convert.ToInt32(temp.RetailPrice - temp.PurchasePrice);
                dtgSatilacak.SelectedCells[9].Value = Convert.ToDecimal(kalan) * Convert.ToDecimal(dtgSatilacak.SelectedCells[3].Value);
                dtgSatilacak.SelectedCells[10].Value = Convert.ToDecimal(kalan) * (agent);
                for (int i = 0; i < dtgSatilacak.Rows.Count; i++)
                {
                    PriceCompany += Convert.ToDecimal(dtgSatilacak.Rows[i].Cells[9].Value);
                    PriceAgent += Convert.ToDecimal(dtgSatilacak.Rows[i].Cells[10].Value);
                }
                lbtoplamfiyat.Text = String.Format("{0:N2}", PriceCompany);
                lbToplamFiyatAgent.Text = String.Format("{0:N2}", PriceAgent);
            }
        }
    }
}
