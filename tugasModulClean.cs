using System;

public class BeasiswaClean
{
    static void Main()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine(" SISTEM SELEKSI DAN PENENTUAN DIVISI BEASISWA");
        Console.WriteLine("==============================================");

        Console.Write("Masukkan IPK Pendaftar: ");
        double ipk = double.Parse(Console.ReadLine());

        if (ipk < 3.25)
        {
            Console.WriteLine("[HASIL SELEKSI] Gagal: IPK di bawah batas minimum (3.25).");
            return;
        }

        Console.WriteLine("[STATUS] IPK memenuhi syarat.");

        Console.Write("Masukkan Skor TOEFL: ");
        int toefl = int.Parse(Console.ReadLine());

        if (toefl >= 500)
        {
            Console.WriteLine("[STATUS] Lolos kualifikasi bahasa (Jalur Utama).");
        }
        else
        {
            Console.Write("Apakah memiliki surat rekomendasi dosen? (1=Ada, 0=Tidak Ada): ");
            int rekomendasi = int.Parse(Console.ReadLine());

            if (rekomendasi != 1)
            {
                Console.WriteLine("[HASIL SELEKSI] Gagal: TOEFL kurang dari 500 dan tidak memiliki surat rekomendasi.");
                return;
            }

            Console.WriteLine("[STATUS] Lolos kualifikasi bahasa (Jalur Bersyarat).");
        }

        Console.Write("Masukkan Nilai Tes Coding (0-100): ");
        int nilaiKoding = int.Parse(Console.ReadLine());

        Console.WriteLine("==============================================");
        Console.WriteLine("           HASIL AKHIR SELEKSI");
        Console.WriteLine("==============================================");

        if (nilaiKoding >= 85)
        {
            Console.WriteLine("Status     : Selamat! Anda diterima");
            Console.WriteLine("Divisi     : Software Engineer");
            Console.WriteLine("Fasilitas  : Beasiswa Uang Saku Penuh");
        }
        else if (nilaiKoding >= 70)
        {
            Console.WriteLine("Status     : Selamat! Anda diterima");
            Console.WriteLine("Divisi     : Data Analyst");
            Console.WriteLine("Fasilitas  : Beasiswa Uang Saku 50%");
        }
        else
        {
            Console.WriteLine("Status     : GAGAL SELEKSI");
            Console.WriteLine("Keterangan : Nilai tes coding di bawah batas minimum (70)");
        }

        Console.WriteLine("==============================================");
    }
}