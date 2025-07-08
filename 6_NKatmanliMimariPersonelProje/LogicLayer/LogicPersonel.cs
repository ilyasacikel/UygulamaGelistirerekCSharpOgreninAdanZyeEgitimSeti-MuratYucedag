using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LLPersonelEkle(EntityPersonel entity)
        {
            if(entity.Ad!="" && entity.Soyad!="" && entity.Maas>=2500 && entity.Ad.Length >= 3)
            {
                return DALPersonel.PersonelEkle(entity);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPersonelSil(int id)
        {
            if (id >= 1)
            {
                return DALPersonel.PersonelSil(id);
            }
            else
            {
                return false;
            }
        }

        public static bool LLPersonelGuncelle(EntityPersonel entity)
        {
            if (entity.Ad != "" && entity.Soyad != "" && entity.Maas >= 5000 && entity.Ad.Length >= 3)
            {
                return DALPersonel.PersonelGuncelle(entity);
            }
            else
            {
                return false;
            }
        }
    }
}
