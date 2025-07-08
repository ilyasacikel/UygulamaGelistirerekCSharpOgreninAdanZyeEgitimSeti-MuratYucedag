using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicDepartman
    {
        public static List<EntityDepartman> LLDepartmanListesi()
        {
            return DALDepartman.DepartmanListesi();
        }

        public static bool LLDepartmanEkle(EntityDepartman entity)
        {
            if( entity.Ad != "" && entity.Ad.Length >= 2)
            {
                return DALDepartman.DepartmanEkle(entity);
            }
            else
            {
                return false;
            }
        }

        public static bool LLDepartmanSil(int id)
        {
            return DALDepartman.DepartmanSil(id);
        }

        public static bool LLDepartmanGuncelle(EntityDepartman entity)
        {
            if (entity.Ad != "" && entity.Ad.Length >= 2)
            {
                return DALDepartman.DepartmanGuncelle(entity);
            }
            else
            {
                return false;
            }
        }
    }
}
