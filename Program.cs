using System;

public class PROGram
{
    public static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();

        config.UbahSatuan();

        Console.Write("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu);
        Console.WriteLine(" ");
        double suhu = double.Parse(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        Console.WriteLine(" ");
        int hariDemam = int.Parse(Console.ReadLine());

        bool suhuNormal = false;
        if (config.satuan_suhu == "celcius")
        {
            if (suhu >= 36.5 && suhu <= 37.5)
            {
                suhuNormal = true;
            }
        }
        else if (config.satuan_suhu == "fahrenheit")
        {
            if (suhu >= 97.7 && suhu <= 99.5)
            {
                suhuNormal = true;
            }
        }

        if (suhuNormal == true && hariDemam < config.batas_hari_demam)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }
    }
}