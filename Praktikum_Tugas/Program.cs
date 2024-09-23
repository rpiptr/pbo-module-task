class Program
{
    static void Main(string[] args)
    {
        Singa singa1 = new Singa("Jawa", 6, 4);
        Console.WriteLine(singa1.Suara());
        singa1.Mengaum();
    }
}

class Hewan
{
    public string nama;
    public int umur;

    public Hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public string InfoHewan()
    {
        return $"Nama: {this.nama}\nUmur: {this.umur}";
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base (nama, umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public override string Suara()
    {
        return "Mamalia ini bersuara";
    }
}

class Singa : Mamalia
{
    public Singa (string nama, int umur, int jumlahKaki) : base (nama, umur, jumlahKaki)
    {

    }

    public override string Suara()
    {
        return "rawr";
    }

    public void Mengaum()
    {
        Console.WriteLine($"Singa {this.nama} mengaum RAWR");
    }
}