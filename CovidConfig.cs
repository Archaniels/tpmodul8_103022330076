using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

public class CovidConfig
{
    public String satuan_suhu { get; set; }
    public int batas_hari_demam { get; set; }
    public String pesan_ditolak { get; set; }
    public String pesan_diterima { get; set; }
    private String file = "covid_config.json";

    public CovidConfig()
    {
        if (File.Exists(file))
        {
            string jsonData = File.ReadAllText("covid_config.json");
            var data = JsonConvert.DeserializeObject<CovidConfig>(jsonData);
            this.satuan_suhu = data.satuan_suhu;
            this.batas_hari_demam = data.batas_hari_demam;
            this.pesan_ditolak = data.pesan_ditolak;
            this.pesan_diterima = data.pesan_diterima;
        }
        else
        {
            satuan_suhu = "celcius";
            batas_hari_demam = 14;
            pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
            pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
        }
    }

    public void UbahSatuan()
    {
        if (satuan_suhu == "celcius")
        {
            satuan_suhu = "fahrenheit";
        } else
        {
            satuan_suhu = "celcius";
        }
    }
}
