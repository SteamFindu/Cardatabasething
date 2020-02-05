using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.model;

namespace Autokauppa.controller
{
    
    public class KaupanLogiikka
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();
        
        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbModel.connectDatabase();
            return doesItWork;
        }

        public bool saveAuto(model.Auto newAuto) 
        {
            bool didItGoIntoDatabase = dbModel.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public IEnumerable<AutoMerkki> getAllAutoMakers() {
            return dbModel.getAllAutoMakersFromDatabase();
        }

        public IEnumerable<AutoMalli> getAutoModels(int makerId) {
            return dbModel.getAutoModelsByMakerId(makerId);
        }
        public List<string> getPaints()
        {
            return dbModel.getColors();
        }
        public List<string> getFuels()
        {
            return dbModel.getFuel();
        }
        public IEnumerable<model.Auto> GetAuto(int MakerID, int MakeID)
        {
            return dbModel.GetAutos(MakerID, MakeID);
        }

        public void PutAuto(model.Auto car)
        {
            dbModel.InsertToDB(car);
        }
    }
}
