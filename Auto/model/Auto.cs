using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Autokauppa.model
{
    public class Auto
    {
        public int ID { get; set; }
        public decimal Hinta { get; set; }
        public DateTime Rekisteri_paivamaara { get; set; }
        public decimal Moottorin_tilavuus { get; set; }
        public int Mittarilukema { get; set; }
        public int AutonMerkkiID { get; set; }
        public int AutonMalliID { get; set; }
        public int VaritID { get; set; }
        public int PolttoaineID { get; set; }

        public static Auto Create(IDataRecord record)
        {
            return new Auto
            {
                ID = (int)record["ID"],
                Hinta = (decimal)record["Hinta"],
                Rekisteri_paivamaara = (DateTime)record["Rekisteri_paivamaara"],
                Moottorin_tilavuus = (decimal)record["Moottorin_tilavuus"],
                Mittarilukema = (int)record["Mittarilukema"],
                AutonMerkkiID = (int)record["AutonMerkkiID"],
                AutonMalliID = (int) record["AutonMalliID"],
                VaritID = (int)record["VaritID"],
                PolttoaineID = (int)record["PolttoaineID"]
            };
            
        }
    }

    public class AutoMalli
    {
        public int ID { get; set; }
        public string Malli { get; set; }
        public int MerkkiID { get; set; }

        public static AutoMalli Create(IDataRecord record)
        {
            return new AutoMalli
            {
                ID = (int)record["ID"],
                Malli = (string)record["Auton_mallin_nimi"],
                MerkkiID = (int)record["AutonMerkkiID"]
            };
        }
    }

    public class AutoMerkki
    {
        public int ID { get; set; }
        public string Merkki { get; set; }

        public static AutoMerkki Create(IDataRecord record)
        {
            return new AutoMerkki
            {
                ID = (int)record["ID"],
                Merkki = (string)record["Merkki"]
            };
        }
    }
}
