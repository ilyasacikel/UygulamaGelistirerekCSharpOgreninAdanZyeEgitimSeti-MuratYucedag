﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int id; // CTRL + R + E  kısayolu ile Encapsulate Field menüsü açılıyor.
        private string ad;
        private string soyad;
        private string sehir;
        private string gorev;
        private short maas;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public short Maas { get => maas; set => maas = value; }
        public string Gorev { get => gorev; set => gorev = value; }
    }
}
