using System;

public class HaloGeneric
{
    public void SapaUser<T>(T x)
    {
        Console.WriteLine($"Halo user {x}");
    }

    static void Main(string[] args)
    {
        HaloGeneric hGen = new HaloGeneric();
        string namaUser = "dani";

       hGen.SapaUser<string>(namaUser);
    }
}
