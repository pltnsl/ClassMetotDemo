﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" " + musteri.Adi +" " + musteri.Soyadi  + " " + musteri.Adresi  + " " + musteri.Meslegi + " " + "Müşteri Eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" " + musteri.Adi +" " +  musteri.Soyadi +" " +  musteri.Adresi + " " + musteri.Meslegi + " " + "Müşteri Silindi");
        }

       
    }
}
