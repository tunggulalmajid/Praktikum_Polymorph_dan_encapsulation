// contoh overloading kalkulator

class kalkulator
{
    public void hitung(int angka1)
    {
        
    }

    public void hitung(double namabeda)
    {

    }

    public void hitung(double namabeda, int angka1)
    {

    }

    //public int hitung(int angka1)
    //{
            //tetap error
    //}

}

// contoh overloading
public class Kasir
{
    // Bayar pakai cash (angka bulat)
    public void Bayar(int jumlah)
    {
        Console.WriteLine("Bayar tunai sebesar: " + jumlah);
    }

    // Bayar pakai kartu (teks)
    public void Bayar(string nomorKartu)
    {
        Console.WriteLine("Bayar pakai kartu: " + nomorKartu);
    }
}


class Hewan
{
    public int jumlahKaki;
    public string warnaKulit;

    public Hewan(int JumlahKaki, string warnaKulit)
    {
        this.jumlahKaki = JumlahKaki;
        this.warnaKulit = warnaKulit;
        //this.jumlahKaki = JumlahKaki; 
    }

    public virtual void TampilkanInfo()
    {
        Console.WriteLine($"jumlah kaki : {jumlahKaki}");
        Console.WriteLine($"Warna Kulit : {warnaKulit}");
    }

    public void Bersuara() //hidding 
    {
        Console.WriteLine("Bersuara");
    }
    //public virtual void Bersuara()
    //{
    //    Console.WriteLine("Bersuara");
    //}
}

class Harimau : Hewan
{
    public string julukan;
    public Harimau(int jumlahKaki, string warnaKulit, string julukan) : base(jumlahKaki, warnaKulit)
    {
        this.jumlahKaki=jumlahKaki;
        this.warnaKulit=warnaKulit;
        this.julukan=julukan;
    }

    public override void TampilkanInfo()
    {
        Console.WriteLine($"jumlah kaki : {jumlahKaki}");
        Console.WriteLine($"Warna Kulit : {warnaKulit}");
        Console.WriteLine($"Julukan : {julukan}");
    }

    public void Bersuara()
    {
        Console.WriteLine("Ngaung");
    }

    //public override void Bersuara()
    //{
    //    Console.WriteLine("Ngaung");
    //}

}

class Kambing : Hewan
{
    public Kambing(int jumlahKaki, string warnaKulit) : base(jumlahKaki, warnaKulit)
    {
        this.jumlahKaki = jumlahKaki;
        this.warnaKulit = warnaKulit;
    }

    public void Bersuara()
    {
        Console.WriteLine("mbek");
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //Hewan hewan = new Hewan(2,"Hitam");
        //Console.WriteLine("Parent : ");
        //hewan.TampilkanInfo();
        //Console.WriteLine("");

        //Harimau harimau = new Harimau(4, "Hitam Gelap", "Simba");
        //Console.WriteLine("Child : ");


        //hidding - Menyembunyikan method parent class 
        //harimau.Bersuara();
        Harimau harimau = new Harimau(4, "Hitam Gelap", "Simba");
        Hewan hewanHarimau = harimau;
        harimau.Bersuara();
        hewanHarimau.Bersuara();





    }
}