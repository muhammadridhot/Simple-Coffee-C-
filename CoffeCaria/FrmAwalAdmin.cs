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
    public partial class FrmAwalAdmin : Form
    {
        public FrmAwalAdmin()
        {
            InitializeComponent();
            Database.BuatKoneksi();
            Database.TabelMenu();
            Database.TabelListPesananAdmin();
            dgvLstMenu.DataSource = Database.ds.Tables["Tabel_Menu"];
            dgvDataPesanan.DataSource = Database.ds.Tables["Tabel_LstPesananAdmin"];
            nudHarga.Minimum = 1000;
            nudHarga.ThousandsSeparator = true;
            nudHarga.Maximum = 100000;
            nudHarga.Increment = 100;
            btnDMCoffee.BackColor = Color.White;
            btnDMCoffee.FlatAppearance.BorderColor = Color.White;
            pnlDataPesanan.Hide();
            pnlLaporan.Hide();
            pnlDataMenu.Show();
        }


        private void reset()
        {
            txtIdCoffee.Clear();
            txtNCoffee.Clear();
            nudHarga.Value = nudHarga.Minimum;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Database.dr = Database.ds.Tables["Tabel_Menu"].NewRow();
            Database.dr["IdCoffee"] = txtIdCoffee.Text;
            Database.dr["NamaCoffee"] = txtNCoffee.Text;
            Database.dr["Harga"] = nudHarga.Value;
            Database.ds.Tables["Tabel_Menu"].Rows.Add(Database.dr);
            reset();

        }

        private void txtIdCoffee_Validating(object sender, CancelEventArgs e)
        {
            Database.arRecord = Database.ds.Tables["Tabel_Menu"].Select("IdCoffee ='" + txtIdCoffee.Text + "'");
            if(Database.arRecord.Length != 0)
            {
                txtNCoffee.Text = Database.arRecord[0]["NamaCoffee"].ToString();
                nudHarga.Value = Convert.ToDecimal(Database.arRecord[0]["Harga"]);
                txtIdCoffee.Enabled = false;
            }
            else
            {
                txtNCoffee.Clear();
                nudHarga.Value = nudHarga.Minimum;
               
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            Database.arRecord = Database.ds.Tables["Tabel_Menu"].Select("IdCoffee ='" + txtIdCoffee.Text + "'");
            if (Database.arRecord.Length != 0)
            {
                Database.arRecord[0]["NamaCoffee"] = txtNCoffee.Text;
                Database.arRecord[0]["Harga"] = nudHarga.Value;

                MessageBox.Show("Data berhasil diubah.");
                txtIdCoffee.Enabled = true;
                reset();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin hapus data " + txtIdCoffee.Text + " ?",this.Text,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            { 
                Database.arRecord = Database.ds.Tables["Tabel_Menu"].Select("IdCoffee ='" + txtIdCoffee.Text + "'");
                foreach(DataRow dr in Database.arRecord)
                {
                    dr.Delete();
                }
                txtIdCoffee.Enabled = true;
                reset();
            }
        }

        private void dgvLstPesanan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dgvLstMenu.Rows.Count - 2)
            {
                txtIdCoffee.Text = dgvLstMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNCoffee.Text = dgvLstMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
                nudHarga.Value = Convert.ToDecimal(dgvLstMenu.Rows[e.RowIndex].Cells[2].Value);
                txtIdCoffee.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            txtIdCoffee.Enabled = true;
        }

        private void btnDMCoffee_Click(object sender, EventArgs e)
        {
            btnDPesanan.BackColor = Color.Transparent;
            btnLaporan.BackColor = Color.Transparent;
            btnDPesanan.FlatAppearance.BorderColor = Color.Black;
            btnDMCoffee.BackColor = Color.White;
            btnDMCoffee.FlatAppearance.BorderColor = Color.White;
            btnLaporan.FlatAppearance.BorderColor = Color.Black;
            pnlDataPesanan.Hide();
            pnlLaporan.Hide();
            pnlDataMenu.Show();
        }

        private void btnDPesanan_Click(object sender, EventArgs e)
        {
            btnDMCoffee.BackColor = Color.Transparent;
            btnLaporan.BackColor = Color.Transparent;
            btnDPesanan.BackColor = Color.White;
            btnDPesanan.FlatAppearance.BorderColor = Color.White;
            btnDMCoffee.FlatAppearance.BorderColor = Color.Black;
            btnLaporan.FlatAppearance.BorderColor = Color.Black;
            pnlDataPesanan.Show();
            pnlDataMenu.Hide();
            pnlLaporan.Hide();
        }

        private void btnHapusDPesanan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin hapus data ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                short baris = (short)dgvDataPesanan.CurrentCell.RowIndex;
                if (baris >= 0 && baris <= dgvDataPesanan.Rows.Count - 2)
                {
                    dgvDataPesanan.Rows.RemoveAt(baris);
                    Database.UpdateDBLstPesananAdmin();
                }
            }
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

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            btnDMCoffee.BackColor = Color.Transparent;
            btnDPesanan.BackColor = Color.Transparent;
            btnDPesanan.FlatAppearance.BorderColor = Color.Black;
            btnDMCoffee.FlatAppearance.BorderColor = Color.Black;
            btnLaporan.BackColor = Color.White;
            btnLaporan.FlatAppearance.BorderColor = Color.White;
            pnlDataPesanan.Hide();
            pnlDataMenu.Hide();
            pnlLaporan.Show();
        }

        private void bBtnLaporanPesanan_Click(object sender, EventArgs e)
        {
            CRPesanan cr;
            cr = new CRPesanan();

            cr.Refresh();
            FrmLaporan frmLaporan;
            frmLaporan = new FrmLaporan();
            frmLaporan.crystalReportViewer1.ReportSource = cr;
            frmLaporan.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            frmLaporan.Show();
        }

        private void bBtnLaporanMenu_Click(object sender, EventArgs e)
        {
            CRMenu cr;
            cr = new CRMenu();

            cr.Refresh();
            FrmLaporan frmMenu;
            frmMenu = new FrmLaporan();
            frmMenu.crystalReportViewer1.ReportSource = cr;
            frmMenu.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            frmMenu.Show();
        }
    }
}
