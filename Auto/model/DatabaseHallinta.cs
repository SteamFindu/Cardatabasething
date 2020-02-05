using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string yhteysTiedot { get; set; }

        SqlConnection DbYhteys { get; set; }

        SqlCommand cmd { get; set; }

        SqlDataReader dr { get; set; }

        public DatabaseHallinta()
        {
            yhteysTiedot = "Integrated Security=true; server=(Local)";
        }

        public bool connectDatabase()
        {
            DbYhteys = new SqlConnection(yhteysTiedot);

            try
            {
                DbYhteys.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                DbYhteys.Close();
                return false;
            }

        }

        public void disconnectDatabase()
        {
            DbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            bool palaute = false;
            return palaute;

        }
        public List<string> getFromDatabase(string sql, int valueid)
        {

            List<string> output = new List<string>();


            cmd = new SqlCommand(sql, DbYhteys);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                output.Add(Convert.ToString(dr.GetValue(valueid)));
            }

            dr.Close();

            cmd.Dispose();

            return output;
        }

        public IEnumerable<AutoMerkki> getAllAutoMakersFromDatabase()
        {
            string sql = "SELECT [ID] ,[Merkki] FROM[Automvc].[dbo].[AutonMerkki]";

            cmd = new SqlCommand(sql, DbYhteys);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                yield return AutoMerkki.Create(dr);
            }

            dr.Close();

        }

        public IEnumerable<AutoMalli> getAutoModelsByMakerId(int makerId)
        {
            string sql = "SELECT [ID], [Auton_mallin_nimi], [AutonMerkkiID] FROM[Automvc].[dbo].[AutonMallit] WHERE[AutonMerkkiID] = " + makerId;

            cmd = new SqlCommand(sql, DbYhteys);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                yield return AutoMalli.Create(dr);
            }

            dr.Close();
        }

        public List<string> getColors()
        {
            return getFromDatabase("SELECT [ID] ,[Varin_nimi] FROM[Automvc].[dbo].[Varit]", 1);
        }

        public List<string> getFuel()
        {
            return getFromDatabase("SELECT[ID],[Polttoaineen_nimi] FROM[Automvc].[dbo].[Polttoaine]", 1);
        }
        public IEnumerable<Auto> GetAutos(int MakerID, int MakeID)
        {
            string sql = "SELECT [ID],[Hinta],[Rekisteri_paivamaara],[Moottorin_tilavuus],[Mittarilukema],[AutonMerkkiID],[AutonMalliID] ,[VaritID],[PolttoaineID] FROM[Automvc].[dbo].[auto] WHERE[AutonMerkkiID] = " + MakerID + " AND [AutonMalliID] = " + MakeID;

            cmd = new SqlCommand(sql, DbYhteys);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                yield return Auto.Create(dr);
            }

            dr.Close();

            cmd.Dispose();
        }
        public void InsertToDB(Auto car)
        {
            try
            {
                string largestid = getFromDatabase("SELECT [ID] FROM [Automvc].[dbo].[auto] WHERE id=(SELECT max(ID) FROM [Automvc].[dbo].[auto])", 0)[0];

                Console.WriteLine(largestid);

                string sql = ("INSERT INTO [Automvc].[dbo].[auto] VALUES (" + (largestid + 1)  + " " + car.Hinta + " " + car.Rekisteri_paivamaara + " " + car.Moottorin_tilavuus + " " + car.Mittarilukema
                             + " " + car.AutonMerkkiID + " " + car.AutonMalliID + " " + car.VaritID + " " + car.PolttoaineID + ")");

                // this shit pukes out format errors, fix that.

                cmd = new SqlCommand(sql, DbYhteys);

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = new SqlCommand(sql, DbYhteys);
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
