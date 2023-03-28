using System;

public class Tartaly
{
    private string _nev;
    private int _a, _b, _c;
    private double _aktLiter;

    public Tartaly(string nev, int a, int b, int c)
    {
        _nev = nev;
        _a = a;
        _b = b;
        _c = c;
        _aktLiter = 0;
    }

    public double Terfogat
    {
        get { return _a * _b * _c; }
    }

    public void DuplazMeretet()
    {
        _a *= 2;
        _b *= 2;
        _c *= 2;
    }

    public void TeljesLeengedes()
    {
        _aktLiter = 0;
    }

    public double Toltottseg
    {
        get { return (_aktLiter / Terfogat) * 100; }
    }

    public void Tolt(double liter)
    {
        if (_aktLiter + liter > Terfogat)
        {
            Console.WriteLine("Hiba: A tartaly tele lenne.");
        }
        else
        {
            _aktLiter += liter;
        }
    }

    public string Info()
    {
        return String.Format("{0}: {1} cm3 = ({2} liter), töltöttsége: {3:f1}%, ({4:f2} liter), méretei: {5}x{6}x{7} cm",
            _nev, this.Terfogat, this.Terfogat / 1000, this.Toltottseg, _aktLiter, _a, _b, _c);
    }

    static void Main(string[] args)
    {
        Tartaly nagytartaly = new Tartaly("Medence", 500, 200, 120);
        Tartaly literes = new Tartaly("Literes", 10, 10, 10);

        Console.WriteLine(nagytartaly.Info());
        nagytartaly.Tolt(12000);
        Console.WriteLine(nagytartaly.Info());
        Console.WriteLine();

        Console.WriteLine(literes.Info());
        literes.DuplazMeretet();
        literes.Tolt(0.56);
        Console.WriteLine(literes.Info());
        literes.TeljesLeengedes();
        literes.Tolt(1.6);
        Console.WriteLine(literes.Info());
    }
}







