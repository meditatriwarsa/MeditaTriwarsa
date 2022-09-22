namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mobil mobil1 = new Toyota("Agya", "Michelin");
            //mobil1.CekBan();
            Mobil mobil1 = new Agya("Michelin");
            //mobil1.Ban = new Michelin();
            //Ban ban1 = new Michelin();
            //mobil1.CekBan();
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();

            Console.WriteLine(" ");
            //Mobil mobil2 = new Toyota("Avanza", "Bridgestone");
            //mobil2.CekBan();
            Mobil mobil2 = new Avanza("Bridgestone");
            mobil2.NyalakanMesin();
            mobil2.MatikanMesin();
            ((Avanza)mobil2).NyalakanLampu();
            //((Toyota)mobil2).NyalakanLampu();
            Console.WriteLine(" ");
            //Mobil civic1 = new Honda("Civic", "Bridgestone");
            //civic1.CekBan();
            Mobil civic1 = new Civic("Bridgestone");
            civic1.NyalakanMesin();
            civic1.MatikanMesin();
            ((Civic)civic1).VtecKickedIn();
            //((Honda)civic1).VtecKickedIn();
            Console.WriteLine(" ");
            Mobil honda1 = new Honda("Civic", "Bridgestone");
            //honda1.CekBan();
            honda1.NyalakanMesin();
            honda1.MatikanMesin();
            ((Honda)honda1).VtecKickedIn();
            //((Honda)honda1).VtecKickedIn();
        }
    }
}

class Ban
{
    public string Merk;
    public Ban(string merk)
    {
        this.Merk = merk;
    }

}

class Michelin : Ban
{
    public Michelin() : base("Michelin")
    {
    }
}

class Bridgestone : Ban
{
    public Bridgestone() : base("Bridgestone")
    {
    }
}

class Mobil
{
    public string Merk, Tipe, Ban;

    public Mobil(string merk, string tipe, string ban)
    {
        this.Merk = merk;
        this.Tipe = tipe;
        this.Ban = ban;
    }

    public void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} menyala menggunakan ban {this.Ban}");
    }

    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} mati menggunakan ban {this.Ban}");
    }

    //public void CekBan()
    //{
    //    Console.WriteLine($"mobil {this.Merk} bertipe {this.Tipe} menggunakan ban {this.Ban}");
    //}
}

class Toyota : Mobil
{
    public Toyota(string tipe, string ban) : base("Toyota", tipe, ban)
    {
    }

    public void NyalakanLampu()
    {
        Console.WriteLine($"Lampu mobil {this.Merk} bertipe {this.Tipe} menyala");
    }

}

class Daihatsu : Mobil
{
    public Daihatsu(string tipe, string ban) : base("Daihatsu", tipe, ban)
    {
    }

}

class Honda : Mobil
{
    public Honda(string tipe, string ban) : base("Honda", tipe, ban)
    {
    }

    public void VtecKickedIn()
    {
        Console.WriteLine($"Ngeeeng Wooosh!");
    }
}

class Agya : Toyota
{
    public Agya(string ban) : base("Agya", ban)
    {
    }
}

class Innova : Toyota
{
    public Innova(string ban) : base("Innova", ban)
    {
    }
}

class Avanza : Toyota
{
    public Avanza(string ban) : base("Avanza", ban)
    {
    }
}

class Ayla : Daihatsu
{
    public Ayla(string ban) : base("Ayla", ban)
    {
    }
}

class Xenia : Daihatsu
{
    public Xenia(string ban) : base("Xenia", ban)
    {
    }
}

class Brio : Honda
{
    public Brio(string ban) : base("Brio", ban)
    {
    }
}

class Civic : Honda
{
    public Civic(string ban) : base("Civic", ban)
    {
    }
}
