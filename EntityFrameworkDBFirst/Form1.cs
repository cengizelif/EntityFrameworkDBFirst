using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListesi();

            cmb_kategoriler.DataSource = db.Kategoriler.ToList();
            cmb_kategoriler.DisplayMember = "KategoriAdi";
            cmb_kategoriler.ValueMember = "KategoriID";

            cmb_tedarikciler.DataSource = db.Tedarikciler.ToList();
            cmb_tedarikciler.DisplayMember = "SirketAdi";
            cmb_tedarikciler.ValueMember = "TedarikciID";
        }

        private void UrunListesi()
        {
            //dgv_urunler.DataSource = db.Urunler.ToList();

            var sonuc1 = db.Urunler.Join(db.Kategoriler, u => u.KategoriID, k => k.KategoriID, (urn, kat) => new { urn.UrunID, urn.UrunAdi,urn.BirimFiyati,urn.HedefStokDuzeyi,kat.KategoriID,kat.KategoriAdi });

            var sonuc2 = db.Urunler.Join(db.Tedarikciler, u => u.TedarikciID, t => t.TedarikciID, (urn, ted)=>new {urn.UrunID,urn.UrunAdi,urn.BirimFiyati,urn.HedefStokDuzeyi,ted.TedarikciID,ted.SirketAdi});
            
            var sonuc3 = db.Urunler.Join (db.Kategoriler, u => u.KategoriID, k => k.KategoriID, (urn, kat) => new { urn,kat.KategoriAdi }).Join(db.Tedarikciler,prd=>prd.urn.TedarikciID,t=>t.TedarikciID,(urun,ted)=> new {urun.urn.UrunID,urun.urn.UrunAdi, urun.urn.BirimFiyati,urun.urn.HedefStokDuzeyi, urun.urn.TedarikciID, urun.urn.KategoriID,urun.KategoriAdi,ted.SirketAdi  } );

            dgv_urunler.DataSource = sonuc3.ToList();
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAdi = txt_urunadi.Text;
            u.HedefStokDuzeyi = (short)nud_stok.Value;
            u.BirimFiyati = nud_fiyat.Value;
            u.KategoriID = (int)cmb_kategoriler.SelectedValue;
            u.TedarikciID = (int)cmb_tedarikciler.SelectedValue;
            db.Urunler.Add(u);
            db.SaveChanges();
            UrunListesi();
        }
        private void dgv_urunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_urunadi.Text = dgv_urunler.CurrentRow.Cells["UrunAdi"].Value.ToString();
            nud_fiyat.Value = (decimal)dgv_urunler.CurrentRow.Cells["BirimFiyati"].Value;
            nud_stok.Value = (short)dgv_urunler.CurrentRow.Cells["HedefStokDuzeyi"].Value;
            cmb_kategoriler.SelectedValue = dgv_urunler.CurrentRow.Cells["KategoriID"].Value;
            cmb_tedarikciler.SelectedValue = dgv_urunler.CurrentRow.Cells["TedarikciID"].Value;
            txt_urunadi.Tag = dgv_urunler.CurrentRow.Cells["UrunID"].Value;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_urunadi.Tag);
            Urunler u = db.Urunler.FirstOrDefault(i => i.UrunID == id);
            if (u != null)
            {
                u.UrunAdi = txt_urunadi.Text;
                u.BirimFiyati = nud_fiyat.Value;
                u.HedefStokDuzeyi = (short)nud_stok.Value;
                u.KategoriID = (int)cmb_kategoriler.SelectedValue;
                u.TedarikciID = (int)cmb_tedarikciler.SelectedValue;
                db.SaveChanges();
            }

            UrunListesi();
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            dgv_urunler.DataSource = db.Urunler.Where(x => x.UrunAdi.Contains(txt_ara.Text)).ToList();
        }

        private void rdb_Artan_CheckedChanged(object sender, EventArgs e)
        {
            dgv_urunler.DataSource = db.Urunler.OrderBy(x => x.BirimFiyati).ToList();
        }

        private void rdb_Azalan_CheckedChanged(object sender, EventArgs e)
        {
            dgv_urunler.DataSource = db.Urunler.OrderByDescending(x => x.BirimFiyati).ToList();

        }

        private void dgv_urunler_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void btn_ilk10_Click(object sender, EventArgs e)
        {
            dgv_urunler.DataSource = db.Urunler.Take(10).ToList();
        }

        private void btn_son10_Click(object sender, EventArgs e)
        {
            dgv_urunler.DataSource = db.Urunler.Take(10).OrderByDescending(x => x.UrunID).ToList();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_urunler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_urunler.CurrentRow.Cells["UrunID"].Value);
                Urunler u = db.Urunler.FirstOrDefault(i => i.UrunID == id);
                if (u != null)
                {
                    db.Urunler.Remove(u);
                    db.SaveChanges();
                }
            }
            UrunListesi();
        }
    }
}
