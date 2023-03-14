// See https://aka.ms/new-console-template for more information


using modul4_1302210028;

internal class Program
{
    public static void Main(string[] args)
    {
        // Kode Buah
        KodeBuah cari = new KodeBuah();
        Console.WriteLine("Kode Buah untuk buah " + KodeBuah.Buah.Apel + " adalah " + cari.getKodeBuah(KodeBuah.Buah.Apel));
        Console.WriteLine();

        // Posisi Karakter Game
        // NIM % 3 == 1
        PosisiKarakterGame pkg = new PosisiKarakterGame();
        pkg.currentState = PosisiKarakterGame.KaraState.Berdiri;

        Console.WriteLine("Sekarang karakter: " + pkg.currentState);

        Console.WriteLine("Pilihan: W, S, X (CASE SENSITIVE!)");
        Console.WriteLine("Masukkan Input:");
        string input = Console.ReadLine();

        while (input != null)
        {
            if (input == "W")
            {
                pkg.activeTrigger(PosisiKarakterGame.Trigger.TombolW);
                if (pkg.currentState == PosisiKarakterGame.KaraState.Berdiri)
                {
                    Console.WriteLine("posisi standby");
                }
            }
            else if (input == "S")
            {
                pkg.activeTrigger(PosisiKarakterGame.Trigger.TombolS);
                if (pkg.currentState == PosisiKarakterGame.KaraState.Tengkurap)
                {
                    Console.WriteLine("posisi istirahat");
                }
                if (pkg.currentState == PosisiKarakterGame.KaraState.Berdiri)
                {
                    Console.WriteLine("posisi standby");
                }
            }
            else if (input == "X")
            {
                pkg.activeTrigger(PosisiKarakterGame.Trigger.TombolX);
            }
            string inputlagi = Console.ReadLine();
        }
    }
}