using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman21._11._4411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan("190302123", "Paijo", 3000000 );
            Karyawan karyawan2 = new Karyawan("190302124", "Jono", 2000000);
            Console.WriteLine("No NIK/Nama          Gaji Bulanan");
            Console.WriteLine("_________________________________");
            Console.WriteLine(" ");
            Console.WriteLine("1. "+karyawan.Nik+" "+karyawan.Nama+"      "+karyawan.GajiBulanan);
            Console.WriteLine("2. "+karyawan2.Nik+" "+karyawan2.Nama+"       "+karyawan2.GajiBulanan);
            int naik = karyawan.naikGaji(karyawan.GajiBulanan);
            int naik2 = karyawan2.naikGaji(karyawan2.GajiBulanan);
            Console.WriteLine("");
            Console.WriteLine("Kenaikan Gaji 10% ");
            Console.WriteLine("No NIK/Nama          Gaji Bulanan");
            Console.WriteLine("");
            Console.WriteLine("_________________________________");
            Console.WriteLine("1. " + karyawan.Nik + " " + karyawan.Nama + "      " + naik);
            Console.WriteLine("2. " + karyawan2.Nik + " " + karyawan2.Nama + "       " + naik2);
                

            Console.ReadKey();
        }
    }
}
