using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NotemanLibrary.DataAccess;

namespace NotemanLibrary
{
    public static class GlobalConfig
    {

        public static List<IDataConnection> Connections
        {
            get; private set;
        } = new List<IDataConnection>();
        public static void InitializeConnections( bool database )
        {
            if (database)
            {
                SQLiteConnector sql = new SQLiteConnector();
                Connections.Add( sql );
            }
        }
        public static string SqliteDbPath()
        {
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NoteStorage.sqlite3";
            return dbPath;
        }
        public static string CnnString(string name)
        {
            if (name == "NoteStorage")
            {
                string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NoteStorage.sqlite3";
                string sql = "Data Source=" + dbPath;
                return sql;
            }
            else
            {
                string bs = "bullshit";
                return bs;
            }
        }


    }
}
