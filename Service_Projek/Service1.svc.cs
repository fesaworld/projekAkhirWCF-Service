using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Service_Projek
{
    public class Service1 : IService1
    {
        //BARANG-
        public List<dataBarang> GetSemuaBarang()
        {
            List<dataBarang> list = new List<dataBarang>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Barang", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataBarang barang = new dataBarang();
                        barang.ID_Barang = reader.GetInt32(0);
                        barang.Nama_Barang = reader.GetString(1);
                        barang.Jenis_Barang = reader.GetString(2);
                        barang.Merek = reader.GetString(3);
                        barang.Harga = reader.GetInt32(4);
                        barang.Stok = reader.GetInt32(5);
                        //barang.Foto = reader.GetByte(6);
                        list.Add(barang);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return list;
        }

        public dataBarang GetBarangID(string id)
        {
            dataBarang barang = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Barang where ID_Barang=" + id, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                barang.ID_Barang = reader.GetInt32(0);
                barang.Nama_Barang = reader.GetString(1);
                barang.Jenis_Barang = reader.GetString(2);
                barang.Merek = reader.GetString(3);
                barang.Harga = reader.GetInt32(4);
                barang.Stok = reader.GetInt32(5);
                //barang.Foto = reader.GetByte(6);
            }
            con.Close();
            return barang;
        }

        public List<dataBarang> GetBarangNama(string nama)
        {
            List<dataBarang> list = new List<dataBarang>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Barang where Nama_Barang LIKE '%" + nama + "%'", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataBarang barang = new dataBarang();
                        barang.ID_Barang = reader.GetInt32(0);
                        barang.Nama_Barang = reader.GetString(1);
                        barang.Jenis_Barang = reader.GetString(2);
                        barang.Merek = reader.GetString(3);
                        barang.Harga = reader.GetInt32(4);
                        barang.Stok = reader.GetInt32(5);
                        //barang.Foto = reader.GetByte(6);
                        list.Add(barang);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return list;
        }
        
        public List<dataBarang> GetBarangJenis(string jenis)
        {
            List<dataBarang> list = new List<dataBarang>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Barang where Jenis_Barang LIKE '%" + jenis + "%'", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataBarang barang = new dataBarang();
                        barang.ID_Barang = reader.GetInt32(0);
                        barang.Nama_Barang = reader.GetString(1);
                        barang.Jenis_Barang = reader.GetString(2);
                        barang.Merek = reader.GetString(3);
                        barang.Harga = reader.GetInt32(4);
                        barang.Stok = reader.GetInt32(5);
                        //barang.Foto = reader.GetByte(6);
                        list.Add(barang);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return list;
        }

        public List<dataBarang> GetBarangMerek(string merek)
        {
            List<dataBarang> list = new List<dataBarang>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Barang where Merek LIKE '%" + merek + "%'", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataBarang barang = new dataBarang();
                        barang.ID_Barang = reader.GetInt32(0);
                        barang.Nama_Barang = reader.GetString(1);
                        barang.Jenis_Barang = reader.GetString(2);
                        barang.Merek = reader.GetString(3);
                        barang.Harga = reader.GetInt32(4);
                        barang.Stok = reader.GetInt32(5);
                        //barang.Foto = reader.GetByte(6);
                        list.Add(barang);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return list;

        }

        public List<dataBarang> GetBarangNamaJenisMerek(string nama, string jenis, string merek)
        {
            List<dataBarang> list = new List<dataBarang>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Barang where Nama_Barang LIKE '%"+ nama +"%' and Jenis_Barang LIKE '%"+ jenis +"%' and Merek LIKE '%"+ merek +"%'", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataBarang barang = new dataBarang();
                        barang.ID_Barang = reader.GetInt32(0);
                        barang.Nama_Barang = reader.GetString(1);
                        barang.Jenis_Barang = reader.GetString(2);
                        barang.Merek = reader.GetString(3);
                        barang.Harga = reader.GetInt32(4);
                        barang.Stok = reader.GetInt32(5);
                        //barang.Foto = reader.GetByte(6);
                        list.Add(barang);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return list;

        }

        public string AddBarang(dataBarang db)
        {
            string query = string.Format("insert into Barang values({0},{1},{2},{3},{4},{5},{6})", db.ID_Barang, db.Nama_Barang, db.Jenis_Barang, db.Merek, db.Harga, db.Stok, db.Foto);

            dataBarang DataBarang = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Rest;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Data Berhasil Di Tambahkan";
            }
            catch (Exception ex)
            {

                return "Data Gagal Ditambahkan : " + ex.ToString();
            }
        }

        public string UpdateBarang(dataBarang db)
        {
            string query = string.Format("update Barang set Nama_Barang='{1}', Jenis_Barang='{2}', Merek='{3}', Harga='{4}', Stok='{5}', Foto='{6}' where ID_Barang={0} ", db.ID_Barang, db.Nama_Barang, db.Jenis_Barang, db.Merek, db.Harga, db.Stok, db.Foto);

            dataBarang DataBarangdpp = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Rest;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Berhasil Di Update";
            }
            catch (Exception ex)
            {

                return "Gagal Di Update :" + ex.ToString();
            }

        }

        public string HapusBarang(string id)
        {
            string query = string.Format("DELETE FROM Barang WHERE ID_Barang=" + id);

            dataBarang DataBarang = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Berhasil Di Hapus";
            }
            catch (Exception ex)
            {

                return "Gagal Di Hapus :" + ex.ToString();
            }
        }

        //ADMIN
        public dataAdmin GetAdmin(string id)
        {
            dataAdmin DataAdmin = new dataAdmin();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Admin where ID__Admin =" + id, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataAdmin.ID_Admin = reader.GetInt32(0);
                DataAdmin.Nama_Admin = reader.GetString(1);
                DataAdmin.Password = reader.GetString(2);
            }
            con.Close();
            return DataAdmin;
        }

        //USER
        public dataUser GetUser(string id)
        {
            dataUser DataUser = new dataUser();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("SELECT * FROM .[dbo].[User] where ID_User =" + id, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataUser user = new dataUser();
                user.ID_User = reader.GetInt32(0);
                user.Nama_User = reader.GetString(1);
                user.Password = reader.GetString(2);
                user.Alamat = reader.GetString(3);
                user.No_Telpon = reader.GetString(4);
            }
            con.Close();
            return DataUser;
        }

        public string AddUser(dataUser du)
        {
            string query = string.Format("insert into User values({0},{1},{2},{3},{4})", du.ID_User, du.Nama_User, du.Password, du.Alamat, du.No_Telpon);

            dataUser DataUser = new dataUser();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Rest;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Data Berhasil Di Tambahkan";
            }
            catch (Exception ex)
            {

                return "Data Gagal Ditambahkan : " + ex.ToString();
            }
        }

        public string UpdateUser(dataUser du)
        {
            string query = string.Format("update User set Nama_User='{1}', Password='{2}', Alamat='{3}', No_Telpon='{4}' where ID_Barang={0} ", du.ID_User, du.Nama_User, du.Password, du.Alamat, du.No_Telpon);

            dataUser DataUser = new dataUser();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Rest;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Berhasil Di Update";
            }
            catch (Exception ex)
            {

                return "Gagal Di Update :" + ex.ToString();
            }

        }

        public string HapusUser(string id)
        {
            string query = string.Format("DELETE FROM User WHERE ID_User=" + id);

            dataUser DataUser = new dataUser();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Rest;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Berhasil Di Hapus";
            }
            catch (Exception ex)
            {

                return "Gagal Di Hapus :" + ex.ToString();
            }
        }

        //TRANSAKSI
        public dataTransaksi GetTransaksi(string idUser)
        {
            dataTransaksi DataTransaksi = new dataTransaksi();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Transaksi where ID_User=" + idUser, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataTransaksi Transaksi = new dataTransaksi();
                Transaksi.ID_Transaksi = reader.GetInt32(0);
                Transaksi.ID_User = reader.GetInt32(0);
                Transaksi.ID_Barang = reader.GetInt32(0);
                Transaksi.ID_Admin = reader.GetInt32(0);
                Transaksi.Total_Harga = reader.GetInt32(4);
                Transaksi.Tanggal_Transaksi = reader.GetDateTime(5);
                Transaksi.Status = reader.GetString(6);
            }
            con.Close();
            return DataTransaksi;
        }

        public string AddTransaksi(dataTransaksi dt)
        {
            string query = string.Format("insert into Transaksi values({0},{1},{2},{3},{4},{5},{6})", dt.ID_Transaksi, dt.ID_User, dt.ID_Barang, dt.ID_Admin, dt.Total_Harga, dt.Tanggal_Transaksi, dt.Status);

            dataTransaksi DataTransaksi = new dataTransaksi();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Rest;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Data Berhasil Di Tambahkan";
            }
            catch (Exception ex)
            {

                return "Data Gagal Ditambahkan : " + ex.ToString();
            }
        }

        public string UpdateTransaksi(dataTransaksi dt)
        {
            string query = string.Format("update Transaksi set ID_User='{1}', ID_Barang='{2}', ID_Admin='{3}', Total_Harga='{4}', Tanggal_Transaksi='{5}', Status='{6}' where ID_Transaksi={0} ", dt.ID_Transaksi, dt.ID_User, dt.ID_Barang, dt.ID_Admin, dt.Total_Harga, dt.Tanggal_Transaksi, dt.Status);

            dataTransaksi DataTransaksi = new dataTransaksi();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Rest;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Berhasil Di Update";
            }
            catch (Exception ex)
            {

                return "Gagal Di Update :" + ex.ToString();
            }

        }

        public string HapusTransaksi(string id)
        {
            string query = string.Format("DELETE FROM Transaksi WHERE ID_Transaksi=" + id);

            dataBarang DataTransaksi = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Rest;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Berhasil Di Hapus";
            }
            catch (Exception ex)
            {

                return "Gagal Di Hapus :" + ex.ToString();
            }
        }
    }
}
