using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SessionManager.Database
{
    class DatabaseControler
    {
        public SQLiteConnection sQLiteConnection;

        public DatabaseControler()
        {
            sQLiteConnection = new SQLiteConnection("Data Source=Database.db");

            if (!File.Exists("./Database.db"))
            {
                SQLiteConnection.CreateFile("Database.db");
            }  
        }

        public void putDataNPC(NpcModel data)
        {
            string query = "INSERT INTO NPC";
        }
    }
}
