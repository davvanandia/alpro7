using System;

public class BonusGaji
{
    static void Main()
    {
        // Console.Write("Masukkan Masa Kerja (tahun): ");
        // int masaKerja = int.Parse(Console.ReadLine());

        // if (masaKerja >= 2)
        // {
        //     Console.Write("Masukkan Nilai Kinerja: ");
        //     int kinerja = int.Parse(Console.ReadLine());

        //     if (kinerja >= 80)
        //     {
        //         Console.WriteLine("Bonus Karyawan: Rp.1.000.000");
        //     } else
        //     {
        //         Console.WriteLine("Bonus Karyaran Rp.500.000");
        //     }
        // } else
        // {
        //     Console.WriteLine("Karyawan Belum Memenuhi Syarat Bonus");
        // }

        //cleanCode
        Console.Write("Masukkan Masa Kerja: ");
        int masaKerja = int.Parse(Console.ReadLine());

        if (masaKerja < 2)
        {
            Console.WriteLine("Karyawan belum memenuhi syarat Bonus");
            return;
        } 

        Console.Write("Masukkan Nilai Kinerja: ");
        int kinerja = int.Parse(Console.ReadLine());

        if (kinerja >= 80)
        {
            Console.WriteLine("Bonus Karyawan: Rp.1.000.000");
        } else
        {
            Console.WriteLine("Bonus Karyaran Rp.500.000");
        }

    }
}