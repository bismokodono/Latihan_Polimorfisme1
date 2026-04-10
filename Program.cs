ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Resize(-20);
imageProcessor.Resize(50);
imageProcessor.Resize(200);
imageProcessor.Resize(100);
imageProcessor.Resize(600, 400);
imageProcessor.Resize("A4");

class ImageProcessor
{
    public void Resize(int persen)
    {
        if (persen <= 0)
        {
            Console.Write("Error! Presentase Tidak Boleh Nol Atau Negatif");
        }
        else if (persen < 100)
        {
            Console.WriteLine($"Mengecilkan Gambar Sebesar {persen}%");
        }
        else if (persen > 100)
        {
            Console.WriteLine($"Memperbesar Gambar Sebesar {persen}%");
        }
        else
        {
            Console.WriteLine("Ukuran Tetap (100%)! Tidak Ada Perubahan");
        }
    }

    public void Resize(int panjang, int lebar)
    {
        Console.WriteLine($"Mengubah Ukuran Menjadi {panjang} px X {lebar}");
    }

    public void Resize(String UkuranKertas)
    {
        Console.WriteLine($"Menyesuaikan Ke Format Kertas {UkuranKertas}");
    }
}
