using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

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
                barang.Foto = reader.GetString(6);
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
            SqlCommand cmd = new SqlCommand("select * from Barang where Nama_Barang LIKE '%" + nama + "%' and Jenis_Barang LIKE '%" + jenis + "%' and Merek LIKE '%" + merek + "%'", con);
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

        public void AddBarang(dataBarang db)
        {
            string query = string.Format("insert into Barang values ('{0}', '{1}', '{2}', {3}, {4}, '{5}')", db.Nama_Barang, db.Jenis_Barang, db.Merek, db.Harga, db.Stok, db.Foto);

            dataBarang DataBarang = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateBarang(dataBarang db)
        {
            string query = string.Format("update Barang set Nama_Barang='{1}', Jenis_Barang='{2}', Merek='{3}', Harga={4}, Stok={5}, Foto='{6}' where ID_Barang={0} ", db.ID_Barang, db.Nama_Barang, db.Jenis_Barang, db.Merek, db.Harga, db.Stok, db.Foto);

            dataBarang DataBarangdpp = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateBarangNoFoto(dataBarang db)
        {
            string query = string.Format("update Barang set Nama_Barang='{1}', Jenis_Barang='{2}', Merek='{3}', Harga={4}, Stok={5} where ID_Barang={0} ", db.ID_Barang, db.Nama_Barang, db.Jenis_Barang, db.Merek, db.Harga, db.Stok);

            dataBarang DataBarangdpp = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateStokBarang(dataBarang db)
        {
            string query = string.Format("update Barang set Stok={1} where ID_Barang={0} ", db.ID_Barang, db.Stok);

            dataBarang DataBarangdpp = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void HapusBarang(string id)
        {
            string query = string.Format("DELETE FROM Barang WHERE ID_Barang=" + id);

            dataBarang DataBarang = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static Image SimpanGambar(byte[] imageData)
        {
            Image image;
            using (MemoryStream inStream = new MemoryStream())
            {
                inStream.Write(imageData, 0, imageData.Length);

                image = Bitmap.FromStream(inStream);
            }
            
            return image;
        }


        //ADMIN
        public dataAdmin GetAdmin(string nama)
        {
            dataAdmin admin = new dataAdmin();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Admin where Nama_Admin ='" + nama + "'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                admin.ID_Admin = reader.GetInt32(0);
                admin.Nama_Admin = reader.GetString(1);
                admin.Password = reader.GetString(2);
            }
            con.Close();
            return admin;
        }

        //USER
        public dataPengguna GetUser(string nama)
        {
            dataPengguna user = new dataPengguna();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pengguna where Nama_User ='" + nama +"'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.ID_User = reader.GetInt32(0);
                user.Nama_User = reader.GetString(1);
                user.Password = reader.GetString(2);
                user.Alamat = reader.GetString(3);
                user.No_Telpon = reader.GetString(4);
            }
            con.Close();
            return user;
        }

        public int updatehp(string h)
        {
            int hp = -1;
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select ID_User from Pengguna where No_Telpon='" + h + "'", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        hp = reader.GetInt32(0);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return hp;
        }

        public void AddUser(dataPengguna du)
        {
            string query = string.Format("insert into Pengguna values('{0}','{1}','{2}','{3}')", du.Nama_User, du.Password, du.Alamat, du.No_Telpon);

            dataPengguna DataUser = new dataPengguna();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa; Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public string UpdateUser(dataPengguna du)
        {
            string query = string.Format("update Pengguna set Nama_User='{1}', Password='{2}', Alamat='{3}', No_Telpon='{4}' where ID_User={0} ", du.ID_User, du.Nama_User, du.Password, du.Alamat, du.No_Telpon);

            dataPengguna DataUser = new dataPengguna();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
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

        //TRANSAKSI
        public List<dataTransaksi> GetSemuaTransaksi()
        {
            List<dataTransaksi> list = new List<dataTransaksi>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select Transaksi.ID_Transaksi, Pengguna.Nama_User, Barang.Nama_Barang, Admin.Nama_Admin, Transaksi.Tanggal_Transaksi, Transaksi.Total_Harga, Pengguna.Alamat, Transaksi.Status from Transaksi join Pengguna on Transaksi.ID_User = Pengguna.ID_User join Admin on Transaksi.ID_Admin = Admin.ID__Admin join Barang on Transaksi.ID_Barang = barang.ID_Barang", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataTransaksi transaksi = new dataTransaksi();
                        transaksi.ID_Transaksi = reader.GetInt32(0);
                        transaksi.ID_User = reader.GetInt32(1);
                        transaksi.ID_Barang = reader.GetInt32(2);
                        transaksi.ID_Admin = reader.GetInt32(3);
                        transaksi.Total_Harga = reader.GetInt32(4);
                        transaksi.Tanggal_Transaksi = reader.GetDateTime(5);
                        transaksi.Status = reader.GetString(6);
                        list.Add(transaksi);
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

        public List<dataTransaksi> GetTransaksi(string idUser)
        {
            List<dataTransaksi> list = new List<dataTransaksi>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(" SELECT * FROM Transaksi" + idUser, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataTransaksi transaksi = new dataTransaksi();
                        transaksi.ID_Transaksi = reader.GetInt32(0);
                        transaksi.ID_User = reader.GetInt32(1);
                        transaksi.ID_Barang = reader.GetInt32(2);
                        transaksi.ID_Admin = reader.GetInt32(3);
                        transaksi.Total_Harga = reader.GetInt32(4);
                        transaksi.Tanggal_Transaksi = reader.GetDateTime(5);
                        transaksi.Status = reader.GetString(6);
                        list.Add(transaksi);

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

        public void addtrans(dataTransaksi dt)
        {
            string query = string.Format("insert into Transaksi values ({0},{1},{2},{3},'{4}','{5}')", dt.ID_User, dt.ID_Barang, dt.ID_Admin, dt.Total_Harga, dt.Tanggal_Transaksi, dt.Status);

            dataBarang DataBarang = new dataBarang();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string AddTransaksi(dataTransaksi dt)
        {
            string query = string.Format("insert into Transaksi values ({0},{1},{2},{3},{4},'{5}','{6}')", dt.ID_Transaksi, dt.ID_User, dt.ID_Barang, dt.ID_Admin, dt.Total_Harga, dt.Tanggal_Transaksi, dt.Status);
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            dataTransaksi DataTransaksi = new dataTransaksi();
            SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Data Berhasil Di Tambahkan";

        }

        //VIEW TRANSAKSI
        public List<dataView> GetSemuaTransaksiView()
        {
            List<dataView> list = new List<dataView>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from ViewTransaksi", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataView view = new dataView();
                        view.ID_Transaksi = reader.GetInt32(0);
                        view.Nama_User = reader.GetString(1);
                        view.Nama_Barang = reader.GetString(2);
                        view.Nama_Admin = reader.GetString(3);
                        view.Total_Harga = reader.GetInt32(4);
                        view.Tanggal_Transaksi = reader.GetDateTime(5);
                        view.Alamat = reader.GetString(6);
                        view.No_Telpon = reader.GetString(7);
                        view.Status = reader.GetString(8);
                        list.Add(view);
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

        public List<dataView> GetSemuaTransaksiViewUser(string nama)
        {
            List<dataView> list = new List<dataView>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from ViewTransaksi where Nama_User LIKE '%" + nama + "%'", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataView view = new dataView();
                        view.ID_Transaksi = reader.GetInt32(0);
                        view.Nama_User = reader.GetString(1);
                        view.Nama_Barang = reader.GetString(2);
                        view.Nama_Admin = reader.GetString(3);
                        view.Total_Harga = reader.GetInt32(4);
                        view.Tanggal_Transaksi = reader.GetDateTime(5);
                        view.Alamat = reader.GetString(6);
                        view.No_Telpon = reader.GetString(7);
                        view.Status = reader.GetString(8);
                        list.Add(view);
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

        public List<dataView> GetSemuaTransaksiViewId(string id)
        {
            List<dataView> list = new List<dataView>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from ViewTransaksi where ID_Transaksi LIKE '%" + id + "%'", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataView view = new dataView();
                        view.ID_Transaksi = reader.GetInt32(0);
                        view.Nama_User = reader.GetString(1);
                        view.Nama_Barang = reader.GetString(2);
                        view.Nama_Admin = reader.GetString(3);
                        view.Total_Harga = reader.GetInt32(4);
                        view.Tanggal_Transaksi = reader.GetDateTime(5);
                        view.Alamat = reader.GetString(6);
                        view.No_Telpon = reader.GetString(7);
                        view.Status = reader.GetString(8);
                        list.Add(view);
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

        public List<dataView> GetSemuaTransaksiViewStatus(string status)
        {
            List<dataView> list = new List<dataView>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from ViewTransaksi where Status LIKE '%" + status + "%'", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataView view = new dataView();
                        view.ID_Transaksi = reader.GetInt32(0);
                        view.Nama_User = reader.GetString(1);
                        view.Nama_Barang = reader.GetString(2);
                        view.Nama_Admin = reader.GetString(3);
                        view.Total_Harga = reader.GetInt32(4);
                        view.Tanggal_Transaksi = reader.GetDateTime(5);
                        view.Alamat = reader.GetString(6);
                        view.No_Telpon = reader.GetString(7);
                        view.Status = reader.GetString(8);
                        list.Add(view);
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

        public void UpdateTransaksi(dataTransaksi dt)
        {
            string query = string.Format("update Transaksi set ID_Admin={1}, Status='{2}' where ID_Transaksi={0}", dt.ID_Transaksi, dt.ID_Admin, dt.Status);

            dataTransaksi DataTransaksi = new dataTransaksi();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Service Buat Ujian Mandiri
        public List<dataViewManual> GetSemuaTransaksiManual()
        {
            List<dataViewManual> list = new List<dataViewManual>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from ViewTransaksi", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataViewManual manual = new dataViewManual();
                    manual.ID_Transaksi = reader.GetInt32(0);
                    manual.Nama_User = reader.GetString(1);
                    manual.Nama_Barang = reader.GetString(2);
                    manual.Nama_Admin = reader.GetString(3);
                    manual.Total_Harga = reader.GetInt32(4);
                    manual.Tanggal_Transaksi = reader.GetDateTime(5);
                    manual.Alamat = reader.GetString(6);
                    manual.No_Telpon = reader.GetString(7);
                    manual.Status = reader.GetString(8);
                    manual.Foto = reader.GetString(9);
                    list.Add(manual);
                }
                con.Close();
            }
           
            return list;
        }

        public List<dataBarang> GetBarangNamaManual(string nama)
        {
            List<dataBarang> list = new List<dataBarang>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Barang where Nama_Barang LIKE '%" + nama + "%'", con);

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
                    barang.Foto = reader.GetString(6);
                    list.Add(barang);
                }
                con.Close();
            }

            return list;
        }

        public List<dataPengguna> GetSemuaUserManual()
        {
            List<dataPengguna> list = new List<dataPengguna>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Pengguna", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataPengguna pengguna = new dataPengguna();
                    pengguna.ID_User = reader.GetInt32(0);
                    pengguna.Nama_User = reader.GetString(1);
                    pengguna.Password = reader.GetString(2);
                    pengguna.Alamat = reader.GetString(3);
                    pengguna.No_Telpon = reader.GetString(4);
                    list.Add(pengguna);
                }
                con.Close();
            }

            return list;
        }

        public List<dataPengguna> GetUserNamaManual(string nama)
        {
            List<dataPengguna> list = new List<dataPengguna>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pengguna where Nama_User LIKE '%" + nama + "%'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataPengguna pengguna = new dataPengguna();
                pengguna.ID_User = reader.GetInt32(0);
                pengguna.Nama_User = reader.GetString(1);
                pengguna.Password = reader.GetString(2);
                pengguna.Alamat = reader.GetString(3);
                pengguna.No_Telpon = reader.GetString(4);
                list.Add(pengguna);
            }
            con.Close();

            return list;
        }

        public List<dataBarang> GetSemuaBarangManual()
        {
            List<dataBarang> list = new List<dataBarang>();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("select * from Barang", con);

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
                    list.Add(barang);
                }
                con.Close();
            }

            return list;
        }

        public void AddTransaksiManual(dataTransaksi dt)
        {
            string query = string.Format("insert into Transaksi values ({0},{1},{2},{3},{4},'{5}','{6}')", dt.ID_Transaksi, dt.ID_User, dt.ID_Barang, dt.ID_Admin, dt.Total_Harga, dt.Tanggal_Transaksi, dt.Status);

            dataTransaksi DataTransaksi = new dataTransaksi();
            SqlConnection con = new SqlConnection("Data Source=FESAART-DEKSTOP;Initial Catalog=WCF_Projek-Akhir;Persist Security Info=True;User ID=sa;Password=123456" );
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
