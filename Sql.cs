using System.Data.SqlClient;

namespace Kütüphane_Takip_Sistemi
{
    class Sql
    {
        public SqlConnection baglantı()
        {
            SqlConnection baglantı = new SqlConnection("Data Source=EMRE_SEFEROGLU\\SQLEXPRESS;Initial Catalog=KitapTakipSistemi;Integrated Security=True;Encrypt=False");
            baglantı.Open();
            return baglantı;
        }
    }
}
