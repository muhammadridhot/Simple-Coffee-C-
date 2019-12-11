using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeCaria
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            SidePanel.Left = btnHome.Left;
            SidePanel.Width = btnHome.Width;
            pnlHome.Show();
            pnlPesan.Hide();
            pnlListPesanan.Hide();
            Database.BuatKoneksi();
            Database.TabelListPesanan();
            dgvListPesanan.DataSource = Database.ds.Tables["Tabel_LstPesanan"];
            txtMeja.Text = "CARIA1";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Left = btnHome.Left;
            SidePanel.Width = btnHome.Width;
            pnlHome.Show();
            pnlPesan.Hide();
            pnlListPesanan.Hide();

        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            SidePanel.Left = btnPesan.Left;
            SidePanel.Width = btnPesan.Width;
            pnlHome.Hide();
            pnlListPesanan.Hide();
            pnlPesan.Show();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            FrmAwal frmAwal;
            frmAwal = new FrmAwal();
            frmAwal.Show();
            this.Close();
        }



        private void bBtnLstPesanan_Click(object sender, EventArgs e)
        {
            pnlPesan.Hide();
            pnlHome.Hide();
            pnlListPesanan.Show();
        }

        private void btnPAf_Click(object sender, EventArgs e)
        {
            Database.dr = Database.ds.Tables["Tabel_LstPesanan"].NewRow();
            Database.dr["Tanggal"] = DateTime.Now;
            Database.dr["IdCoffee"] = "MC001";
            Database.dr["Meja"] = txtMeja.Text;
            Database.dr["Jumlah"] = nudAffogato.Value;
            Database.dr["Harga"] = 30000 * nudAffogato.Value;
            Database.ds.Tables["Tabel_LstPesanan"].Rows.Add(Database.dr);       
        }

        private void btnPMachiato_Click(object sender, EventArgs e)
        {
            Database.dr = Database.ds.Tables["Tabel_LstPesanan"].NewRow();
            Database.dr["Tanggal"] = DateTime.Now;
            Database.dr["IdCoffee"] = "MC003";
            Database.dr["Meja"] = txtMeja.Text;
            Database.dr["Jumlah"] = nudMachiato.Value;
            Database.dr["Harga"] = 25000 * nudMachiato.Value;
            Database.ds.Tables["Tabel_LstPesanan"].Rows.Add(Database.dr);
        }

        private void btnPFWhite_Click(object sender, EventArgs e)
        {
            Database.dr = Database.ds.Tables["Tabel_LstPesanan"].NewRow();
            Database.dr["Tanggal"] = DateTime.Now;
            Database.dr["IdCoffee"] = "MC002";
            Database.dr["Meja"] = txtMeja.Text;
            Database.dr["Jumlah"] = nudFWhite.Value;
            Database.dr["Harga"] = 20000 * nudFWhite.Value;
            Database.ds.Tables["Tabel_LstPesanan"].Rows.Add(Database.dr);
        }

        private void btnPMochachino_Click(object sender, EventArgs e)
        {
            Database.dr = Database.ds.Tables["Tabel_LstPesanan"].NewRow();
            Database.dr["Tanggal"] = DateTime.Now;
            Database.dr["IdCoffee"] = "MC004";
            Database.dr["Meja"] = txtMeja.Text;
            Database.dr["Jumlah"] = nudMochachino.Value;
            Database.dr["Harga"] = 15000 * nudMochachino.Value;
            Database.ds.Tables["Tabel_LstPesanan"].Rows.Add(Database.dr);
        }

        private void btnBackPesan_Click(object sender, EventArgs e)
        {
            SidePanel.Left = btnPesan.Left;
            SidePanel.Width = btnPesan.Width;
            pnlHome.Hide();
            pnlListPesanan.Hide();
            pnlListPesanan.Hide();
            pnlPesan.Show();
        }

        private void bBtnHpsLstPesanan_Click(object sender, EventArgs e)
        {
            short baris = (short)dgvListPesanan.CurrentCell.RowIndex;
            if (baris >= 0 && baris <= dgvListPesanan.Rows.Count - 2)
            {
                dgvListPesanan.Rows.RemoveAt(baris);
            }
        }

        private void bBtnLanjutPesan_Click(object sender, EventArgs e)
        {
            Database.UpdateDBLstPesanan();
            MessageBox.Show("Pesanan Berhasil dilakukan, Terima Kasih.");
        }

        private void bBtnPGCoffee_Click(object sender, EventArgs e)
        {
            Database.dr = Database.ds.Tables["Tabel_LstPesanan"].NewRow();
            Database.dr["Tanggal"] = DateTime.Now;
            Database.dr["IdCoffee"] = "MC005";
            Database.dr["Meja"] = txtMeja.Text;
            Database.dr["Jumlah"] = "1";
            Database.dr["Harga"] = 16000 ;
            Database.ds.Tables["Tabel_LstPesanan"].Rows.Add(Database.dr);
        }
    }
}
