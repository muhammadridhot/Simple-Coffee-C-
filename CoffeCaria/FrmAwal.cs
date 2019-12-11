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
    public partial class FrmAwal : Form
    {
        public FrmAwal()
        {
            InitializeComponent();
            SidePanel.Left = btnLogin.Left;
            pnlLogin.Show();
            pnlRegister.Hide();
            //txtPass.PasswordChar = '*';
            txtPassReg.PasswordChar = '*';

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SidePanel.Left = btnLogin.Left;
            SidePanel.Width = btnLogin.Width;
            
            pnlLogin.Show();
            pnlRegister.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SidePanel.Left = btnRegister.Left;
            SidePanel.Width = btnRegister.Width;
            pnlRegister.BringToFront();
            pnlLogin.Hide();
            pnlRegister.Show();
        }

       
        private void btnLog_Click(object sender, EventArgs e)
        {

            if (chkAdmin.Checked)
            { 
                Database.arRecord = Database.ds.Tables["Tabel_user"].Select("username = '" + txtUsername.Text + "' and password = '" + txtPass.Text + "' and status = 'admin'");
                        if (Database.arRecord.Length != 0)
                        {
                            FrmAwalAdmin frmAdmin;
                            frmAdmin = new FrmAwalAdmin();
                            frmAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username belum terdaftar");
                        }
            }
            else
            {
                Database.arRecord = Database.ds.Tables["Tabel_user"].Select("username = '" + txtUsername.Text + "' and password = '" + txtPass.Text + "' and status = 'member'");

                if (Database.arRecord.Length != 0)
                {
                    FrmHome frmHome;
                    frmHome = new FrmHome();
                    frmHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username belum terdaftar");
                }

            }

        }

        
        private void FrmAwal_Load(object sender, EventArgs e)
        {
            Database.BuatKoneksi();
            Database.TabelUser();
          
        }

        private void reset()
        {
            txtUsernameReg.Clear();
            txtPassReg.Clear();
            txtEmailReg.Clear();
        }

        private void UpdateDBUser()
        {
            Database.cbl = new SqlCommandBuilder(Database.adUser);
            Database.adUser = Database.cbl.DataAdapter;
            Database.adUser.Update(Database.ds, "Tabel_user");
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            Database.dr = Database.ds.Tables["Tabel_user"].NewRow();
            Database.dr["username"] = txtUsernameReg.Text;
            Database.dr["password"] = txtPassReg.Text;
            Database.dr["status"] = "member";
            Database.dr["email"] = txtEmailReg.Text;
            Database.ds.Tables["Tabel_user"].Rows.Add(Database.dr);
            UpdateDBUser();
            reset();
            MessageBox.Show("Registrasi berhasil,Silahkan login!");
            SidePanel.Left = btnLogin.Left;
            SidePanel.Width = btnLogin.Width;
            pnlRegister.Hide();
            pnlLogin.Show();
        }
  
        private void btnLUnlock_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            pnlLUnlock.Hide();
            pnlLLog.Show();
        }

        private void btnLLog_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            pnlLUnlock.Show();
            pnlLLog.Hide();
        }

    }
}
