using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Versioning;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("Select * From TBLBILGI", Baglanti.bgl);

            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                EntityPersonel entity = new EntityPersonel();
                entity.Id = int.Parse(dataReader["ID"].ToString());
                entity.Ad = dataReader["AD"].ToString();
                entity.Soyad = dataReader["SOYAD"].ToString();
                entity.Sehir = dataReader["SEHIR"].ToString();
                entity.Gorev = dataReader["GOREV"].ToString();
                entity.Maas = short.Parse(dataReader["MAAS"].ToString());

                degerler.Add(entity);
            }
            dataReader.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel entity)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBILGI (AD,SOYAD,GOREV,SEHIR,MAAS) values (@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", entity.Ad);
            komut.Parameters.AddWithValue("@p2", entity.Soyad);
            komut.Parameters.AddWithValue("@p3", entity.Gorev);
            komut.Parameters.AddWithValue("@p4", entity.Sehir);
            komut.Parameters.AddWithValue("@p5", entity.Maas);
           
            return komut.ExecuteNonQuery();
        }

        public static bool PersonelSil(int id)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLBILGI where ID=@p1", Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", id);

            return komut.ExecuteNonQuery() > 0;
        }

        public static bool PersonelGuncelle(EntityPersonel entity)
        {
            SqlCommand komut = new SqlCommand("Update TBLBILGI set AD=@p1, SOYAD=@p2, MAAS=@p3, SEHIR=@p4, GOREV=@p5 Where ID=@p6", Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                Baglanti.bgl.Open();
            }
            komut.Parameters.AddWithValue("@p1", entity.Ad);
            komut.Parameters.AddWithValue("@p2", entity.Soyad);
            komut.Parameters.AddWithValue("@p3", entity.Maas);
            komut.Parameters.AddWithValue("@p4", entity.Sehir);
            komut.Parameters.AddWithValue("@p5", entity.Gorev);
            komut.Parameters.AddWithValue("@p6", entity.Id);

            return komut.ExecuteNonQuery() > 0;
        }
    }
}
