using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman21._11._4411
{
     class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string nik,string nama,int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
            if (gajibulanan < 0)
            {
                gajibulanan = 0;
            }

        }
        public int naikGaji(int gaji)
        {
            return gaji = GajiBulanan + (GajiBulanan / 100 * 10);
        }
    }
}
