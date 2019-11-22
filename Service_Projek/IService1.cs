using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service_Projek
{
    [ServiceContract]
    public interface IService1
    {
        //BARANG
        [OperationContract]
        [WebInvoke(
           Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getallbarang"
           )]
        List<dataBarang> GetSemuaBarang();

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangid/id={Id}"
          )]
        dataBarang GetBarangID(string id);

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangnama/nama={Nama}"
          )]
        List<dataBarang> GetBarangNama(string nama);

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangjenis/jenis={Jenis}"
          )]
        List<dataBarang> GetBarangJenis(string jenis);

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangmerek/merek={Merek}"
          )]
        List<dataBarang> GetBarangMerek(string merek);

        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getbarangnamajenismerek/nama={Nama}/jenis={Jenis}/merek={Merek}"
          )]
        List<dataBarang> GetBarangNamaJenisMerek(string nama, string jenis, string merek);

        [OperationContract]
        [WebInvoke(
          Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "addbarang"
          )]
        string AddBarang(dataBarang db);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "updatebarang"
          )]
        string UpdateBarang(dataBarang db);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "deletebarang/id={Id}"
          )]
        string HapusBarang(string id);

        //ADMIN
        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getadmin/id={Id}"
          )]
        dataAdmin GetAdmin(string id);

        //USER
        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "getuser/id={Id}"
          )]
        dataUser GetUser(string id);

        [OperationContract]
        [WebInvoke(
          Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "adduser"
          )]
        string AddUser(dataUser du);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "updateuser"
          )]
        string UpdateUser(dataUser du);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "deleteuser/id={Id}"
          )]
        string HapusUser(string id);

        //TRANSAKSI
        [OperationContract]
        [WebInvoke(
          Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "gettransaksi/idUser={IdUser}"
          )]
        dataTransaksi GetTransaksi(string idUser);

        [OperationContract]
        [WebInvoke(
          Method = "PUT",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "addtransaksi"
          )]
        string AddTransaksi(dataTransaksi dt);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "updatetransaksi"
          )]
        string UpdateTransaksi(dataTransaksi dt);

        [OperationContract]
        [WebInvoke(
          Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "deletetransaksi"
          )]
        string HapusTransaksi(string id);
    }
        
    [DataContract]
    public class dataAdmin
    {
        [DataMember]
        public int ID_Admin { get; set; }
        [DataMember]
        public string Nama_Admin { get; set; }
        [DataMember]
        public string Password { get; set; }
    }

    [DataContract]
    public class dataUser
    {
        [DataMember]
        public int ID_User { get; set; }
        [DataMember]
        public string Nama_User { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Alamat { get; set; }
        [DataMember]
        public string No_Telpon { get; set; }
    }

    [DataContract]
    public class dataBarang
    {
        [DataMember]
        public int ID_Barang { get; set; }
        [DataMember]
        public string Nama_Barang { get; set; }
        [DataMember]
        public string Jenis_Barang { get; set; }
        [DataMember]
        public string Merek { get; set; }
        [DataMember]
        public int Harga { get; set; }
        [DataMember]
        public int Stok { get; set; }
        [DataMember]
        public byte Foto { get; set; }
    }

    [DataContract]
    public class dataTransaksi
    {
        [DataMember]
        public int ID_Transaksi { get; set; }
        [DataMember]
        public int ID_User { get; set; }
        [DataMember]
        public int ID_Barang { get; set; }
        [DataMember]
        public int ID_Admin { get; set; }
        [DataMember]
        public int Total_Harga { get; set; }
        [DataMember]
        public DateTime Tanggal_Transaksi { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
