using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CoffeCaria
{
    class Database
    {
        public static SqlConnection con;
        public static SqlDataAdapter adUser,adListPesanan, adListPesananAdmin;
        public static DataSet ds;
        public static DataRow dr;
        public static DataRow[] arRecord;
        public static SqlCommandBuilder cbl;

        public static void BuatKoneksi()
        {
            con = new SqlConnection("data source=DESKTOP-3RA590P; initial catalog=CoffeeCaria; integrated security=true");
            ds = new DataSet();
           
        }
        public static void TabelUser()
        {
            if (Database.ds.Tables["Tabel_user"] != null) Database.ds.Tables["Tabel_user"].Clear();
            Database.adUser = new SqlDataAdapter("select * from Tabel_user", Database.con);
            Database.adUser.Fill(Database.ds, "Tabel_user");
        }
        public static void TabelListPesanan()
        {
            if (Database.ds.Tables["Tabel_LstPesanan"] != null) Database.ds.Tables["Tabel_LstPesanan"].Clear();
            Database.adListPesanan = new SqlDataAdapter("select Tanggal,IdCoffee,Meja,Jumlah,Harga from Tabel_ListPesanan", con);
            Database.adListPesanan.Fill(Database.ds, "Tabel_LstPesanan");
        }

        public static void TabelListPesananAdmin()
        {
            if (Database.ds.Tables["Tabel_LstPesananAdmin"] != null) Database.ds.Tables["Tabel_LstPesananAdmin"].Clear();
            Database.adListPesananAdmin = new SqlDataAdapter("select * from Tabel_LstPesananAdmin", con);
            Database.adListPesananAdmin.Fill(Database.ds, "Tabel_LstPesananAdmin");
        }

        public static void TabelMenu()
        {
            if (Database.ds.Tables["Tabel_Menu"] != null) Database.ds.Tables["Tabel_Menu"].Clear();
            Database.adListPesanan = new SqlDataAdapter("select * from Tabel_Menu", con);
            Database.adListPesanan.Fill(Database.ds, "Tabel_Menu");
        }

        public static void UpdateDBLstPesanan()
        {
            Database.cbl = new SqlCommandBuilder(Database.adListPesanan);
            Database.adListPesanan= Database.cbl.DataAdapter;
            Database.adListPesanan.Update(Database.ds, "Tabel_LstPesanan");
        }

        public static void UpdateDBLstPesananAdmin()
        {
            Database.cbl = new SqlCommandBuilder(Database.adListPesananAdmin);
            Database.adListPesananAdmin = Database.cbl.DataAdapter;
            Database.adListPesananAdmin.Update(Database.ds, "Tabel_LstPesananAdmin");
        }

    }
}
