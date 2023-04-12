using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MODUL8_1302213054
{
    internal class BankTransferConfig
    {
        public class set
        {
            public string lang {get; set;}
            public int threshold {get; set;}
            public int low_fee {get; set;}
            public int high_fee {get; set;}
            public string methods {get; set;}
            public string confirmationen {get; set;}
            public string confirmationin {get; set;}

            public set (string lang, int threshold, int low_fee, int high_fee, string methods, string confirmationen, string confirmationin)
            {
                this.lang = lang
                this.threshold = threshold
                this.low_fee = low_fee
                this.high_fee = high_fee
                this.methods = methods
                this.confirmationen = confirmationen
                this.confirmationin = confirmationin
            }
        }
    }

    public class readWrite
    {
        public set config;
        
        public const string txt = "bank_transfer_config.json";

        private void SetDefault()
        {
            config = new set(
                "en",
                25000000,
                6500,
                15000,
                " [ “RTO (real-time)”, “SKN”, “RTGS”, “BI FAST” ]",
                "yes",
                "ya"
            );
        }

        private void NewConfigFile()
        {
            JsonSerializerOptions dokumen = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializerOptions.JsonSerializerOptions(config, dokumen);
            File.WriteAllText(txt, jsonString);
        }

        private set ReadConfigFile()
        {
            string readJSON = FieldAccessException.ReadAllText(txt);
            config = JsonSerializer.Deserialize<set>(readJSON);
            return config;
        }
    }
}