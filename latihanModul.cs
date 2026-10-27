using System;

public class Latian
{
    static void Main()
    {
        int status = 0;
        int denda = 0;
        int bukuDipinjam = 0;

        Console.WriteLine("===PERPUSTAKAAN KAMPUS===");

        Console.Write("Status Keanggotaan (1 = aktif, 0 = tidak aktif): ");
        status = int.Parse(Console.ReadLine());

        Console.Write("Total Dana Tertunggak (Rp): ");
        denda = int.Parse(Console.ReadLine());

        Console.Write("Jumlah Buku yang sedang dipinjam: ");
        bukuDipinjam = int.Parse(Console.ReadLine());

        if (status == 1)
        {
            if (denda == 0)
            {
                if (bukuDipinjam < 3)
                {
                    Console.WriteLine("Peminjaman Disetujui, Sisa Kuota: "+ (3 - bukuDipinjam) + " buku");
                } else
                {
                    Console.WriteLine("Peminjaman ditolak, Batas 3 buku sudah tercapai");
                }
            } else
            {
                Console.WriteLine("Peminjaman ditolak. Lunasi denda Rp" + denda + " terlebih dahulu");
            }
        } else
        {
            Console.WriteLine("Peminjaman Ditolak. Keanggotaan tidak aktif");
        }

    }
}