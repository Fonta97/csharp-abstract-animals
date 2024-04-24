using System;

// Esercizio 1: Classi astratte

// Classe astratta Animale
public abstract class Animale
{
    public abstract void Dormi();
    public abstract void Verso();
    public abstract void Mangia();
}

// Classi che estendono Animale
public class Cane : Animale
{
    public override void Dormi()
    {
        Console.WriteLine("Zzz");
    }

    public override void Verso()
    {
        Console.WriteLine("Bau!");
    }

    public override void Mangia()
    {
        Console.WriteLine("Carne");
    }
}

public class Passerotto : Animale
{
    public override void Dormi()
    {
        Console.WriteLine("Zzz");
    }

    public override void Verso()
    {
        Console.WriteLine("Cinguettio");
    }

    public override void Mangia()
    {
        Console.WriteLine("Semi");
    }
}

public class Aquila : Animale
{
    public override void Dormi()
    {
        Console.WriteLine("Zzz");
    }

    public override void Verso()
    {
        Console.WriteLine("Grido dell'aquila");
    }

    public override void Mangia()
    {
        Console.WriteLine("Carne");
    }
}

public class Delfino : Animale
{
    public override void Dormi()
    {
        Console.WriteLine("Zzz");
    }

    public override void Verso()
    {
        Console.WriteLine("Fischi del delfino");
    }

    public override void Mangia()
    {
        Console.WriteLine("Pesce");
    }
}

// Esercizio 2: Interfacce

// Interfacce per volare e nuotare
public interface IVolante
{
    void Vola();
}

public interface INuotante
{
    void Nuota();
}

// Classe che gestisce il comportamento del volo e del nuoto
public class GestoreMovimenti
{
    public void FaiVolare(IVolante animale)
    {
        animale.Vola();
    }

    public void FaiNuotare(INuotante animale)
    {
        animale.Nuota();
    }
}

// Implementazioni delle interfacce per alcuni animali
public class Sparrow : IVolante
{
    public void Vola()
    {
        Console.WriteLine("Sto volando!");
    }
}

public class Dolphin : INuotante
{
    public void Nuota()
    {
        Console.WriteLine("Sto nuotando!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Esercizio 1
        Cane cane = new Cane();
        cane.Dormi();
        cane.Verso();
        cane.Mangia();

        // Esercizio 2
        Sparrow passero = new Sparrow();
        Dolphin delfino = new Dolphin();

        GestoreMovimenti gestore = new GestoreMovimenti();
        gestore.FaiVolare(passero);
        gestore.FaiNuotare(delfino);
    }
}