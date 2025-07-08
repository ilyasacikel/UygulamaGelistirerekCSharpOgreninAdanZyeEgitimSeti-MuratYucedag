using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class DALDepartman
    {
        public static List<EntityDepartman> DepartmanListesi()
        {
            List<EntityDepartman> entities = new List<EntityDepartman>();
            SqlCommand komut = new SqlCommand("Select * from TBLDEPARTMAN", Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                EntityDepartman entity = new EntityDepartman();
                entity.Id = int.Parse(dataReader[0].ToString());
                entity.Ad = dataReader[1].ToString();
                entity.Aciklama = dataReader[2].ToString();
                entities.Add(entity);
            }
            dataReader.Close();
            return entities;
        }

        public static bool DepartmanEkle(EntityDepartman entity)
        {
            SqlCommand komut = new SqlCommand("insert into TBLDEPARTMAN (AD,ACIKLAMA) values (@p1,@p2)",Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", entity.Ad);
            komut.Parameters.AddWithValue("@p2", entity.Aciklama);

            return komut.ExecuteNonQuery() > 0;
        }

        public static bool DepartmanSil(int id)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLDEPARTMAN where ID=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", id);

            return komut.ExecuteNonQuery() > 0;
        }

        public static bool DepartmanGuncelle(EntityDepartman entity)
        {
            SqlCommand komut = new SqlCommand("Update TBLDEPARTMAN set AD=@p1,ACIKLAMA=@p2 where ID=@p3", Baglanti.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", entity.Ad);
            komut.Parameters.AddWithValue("@p2", entity.Aciklama);
            komut.Parameters.AddWithValue("@p3", entity.Id);

            return komut.ExecuteNonQuery() > 0;
        }
    }
}
