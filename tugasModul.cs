using System;

public class Beasiswa
{
    static void Main()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine(" SISTEM SELEKSI DAN PENENTUAN DIVISI BEASISWA");
        Console.WriteLine("==============================================");

        double ipk = 0;
        int toefl = 0;
        int rekomendasi = 0;
        int nilaiKoding = 0;
        int coding = 0;

        Console.Write("Masukkan IPK Pendaftar: ");
        ipk = double.Parse(Console.ReadLine());

        if (ipk >= 3.5)
        {
            Console.WriteLine("[STATUS] IPK Memenuhi Syarat. Melanjutkan ke tahap 2.....");
            Console.Write("Masukkan Skor TOEFL: ");
            toefl = int.Parse(Console.ReadLine());

            if (toefl >= 500)
            {
                Console.WriteLine("[STATUS] Lolos kualifikasi bahasa (Jalur Utama).");
                Console.WriteLine("---------------------------------------------");
                        Console.Write("Masukkan Nilai Tes Coding (0-100): ");
                        Console.WriteLine();

                        nilaiKoding = int.Parse(Console.ReadLine());
                        if (nilaiKoding >= 85)
                        {
                            Console.WriteLine("=====HASIL AKHIR SELEKSI=====");
                            Console.WriteLine("Status : Selamat! Anda diterima");
                            Console.WriteLine("Divisi : Software Engineer");
                            Console.WriteLine("Fasilitas : Beasiswa Uang Saku Penuh");
                            Console.WriteLine("=============================");
                        } else if (nilaiKoding >= 70 && nilaiKoding < 85)
                        {
                            Console.WriteLine("=====HASIL AKHIR SELEKSI=====");
                            Console.WriteLine("Status : Selamat! Anda diterima");
                            Console.WriteLine("Divisi : Data Analyst");
                            Console.WriteLine("Fasilitas : Beasiswa Uang Saku 50%");
                            Console.WriteLine("=============================");
                        } else
                        {
                            Console.WriteLine("=====HASIL AKHIR SELEKSI=====");
                            Console.WriteLine("Status : GAGAL SELEKSI");
                            Console.WriteLine("Keterangan : Nilai tes coding dibawah kelayakan (70)");
                            Console.WriteLine("=============================");
                        }
            }
            else
            {
                Console.Write("Skor Toefl <500. Apakah Memiliki surat rekomendasi dosen? (1=Ada, 0=Tidak Ada): ");
                rekomendasi = int.Parse(Console.ReadLine());
                if (rekomendasi == 1)
                {
                    Console.WriteLine("[STATUS] Lolos kualifikasi bahasa (Jalur Bersyarat).");
                    if (rekomendasi == 1)
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.Write("Masukkan Nilai Tes Coding (0-100): ");
                        Console.WriteLine();

                        nilaiKoding = int.Parse(Console.ReadLine());
                        if (nilaiKoding >= 85)
                        {
                            Console.WriteLine("=====HASIL AKHIR SELEKSI=====");
                            Console.WriteLine("Status : Selamat! Anda diterima");
                            Console.WriteLine("Divisi : Software Engineer");
                            Console.WriteLine("Fasilitas : Beasiswa Uang Saku Penuh");
                            Console.WriteLine("=============================");
                        } else if (nilaiKoding >= 70 && nilaiKoding < 85)
                        {
                            Console.WriteLine("=====HASIL AKHIR SELEKSI=====");
                            Console.WriteLine("Status : Selamat! Anda diterima");
                            Console.WriteLine("Divisi : Data Analyst");
                            Console.WriteLine("Fasilitas : Beasiswa Uang Saku 50%");
                            Console.WriteLine("=============================");
                        } else
                        {
                            Console.WriteLine("=====HASIL AKHIR SELEKSI=====");
                            Console.WriteLine("Status : GAGAL SELEKSI");
                            Console.WriteLine("Keterangan : Nilai tes coding dibawah kelayakan (70)");
                            Console.WriteLine("=============================");
                        }

                    }

                } else if (rekomendasi == 0)
                {
                    Console.WriteLine("[HASIL SELEKSI] Gagal: Skor TOEFL kurang dari 500 dan tidak memiliki surat rekomendasi");
                }
            }
        } else
        {
            Console.WriteLine("[HASIL SELEKSI] Gagal: IPK di bawah batas minimum (3.25)");
        }

    }
}