class Program
{  
    static void Main(string[] args)
    {
        KebunBinatang zoo = new KebunBinatang();
        Singa singa = new Singa("Singa", 5, 4);
        Gajah gajah = new Gajah("Gajah", 8, 4);
        Ular ular = new Ular("Ular", 3, 2.12);
        Buaya buaya = new Buaya("Buaya", 12, 3.6);
        zoo.TambahHewan(singa);
        zoo.TambahHewan(gajah);
        zoo.TambahHewan(ular);
        zoo.TambahHewan(buaya);
        zoo.DaftarHewan();
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());
        singa.Mengaum();

        //soal 1
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());

        //soal 2
        singa.Mengaum();

        //soal 3
        Console.WriteLine(singa.InfoHewan());

        //soal 4
        ular.Merayap();

        //soal 5
        Reptil reptil = new Buaya("Reptil", 3, 3.1);
        Console.WriteLine(reptil.Suara());
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

    public virtual string InfoHewan()
    {
        return $"Nama: {this.nama}\nUmur: {this.umur} tahun";
    }
}

class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>(); 

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
        Console.WriteLine("Hewan berhasil ditambahkan");
    }

    public void DaftarHewan()
    {
        Console.WriteLine("Daftar hewan di kebun binatang:");
        foreach (Hewan hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.ToString());
        }
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public override string Suara()
    {
        return "Mamalia ini bersuara";
    }
}

class Reptil : Hewan
{
    public double panjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        this.panjangTubuh = panjangTubuh;
    }
}

class Singa : Mamalia
{
    public Singa (string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }

    public override string Suara()
    {
        return "Singa bersuara rawr";
    }

    public override string InfoHewan()
    {
        return $"{base.InfoHewan()}\nJumlah kaki: {this.jumlahKaki}";
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa mengaum RAWR");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }

    public override string Suara()
    {
        return "Gajah bersuara trotttt";
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }

    public override string Suara()
    {
        return "Ular bersuara psssshh";
    }

    public void Merayap()
    {
        Console.WriteLine("Ular merayap di tanah");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }

    public override string Suara()
    {
        return "Buaya bersuara grrrrr";
    }
}