// See https://aka.ms/new-console-template for more information


using modul4_1302210028;

internal class Program
{
    public static void Main(string[] args)
    {
        KodeBuah cari = new KodeBuah();
        Console.WriteLine("Kode Buah untuk buah " + KodeBuah.Buah.Apel + " adalah " + cari.getKodeBuah(KodeBuah.Buah.Apel));
    }
}