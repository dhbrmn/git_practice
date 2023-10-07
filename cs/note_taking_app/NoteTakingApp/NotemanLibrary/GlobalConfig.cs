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
        /// <summary>
        /// Opens a list of all different connections one could add
        /// </summary>
        public static List<IDataConnection> Connections
        {
            get; private set;
        } = new List<IDataConnection>();
        /// <summary>
        /// Initializes the connection and preps the various connectors for databases
        /// </summary>
        /// <param name="database">Bool defines if a database is to be used</param>
        public static void InitializeConnections( bool database )
        {
            if (database)
            {
                SQLiteConnector sql = new SQLiteConnector();
                Connections.Add( sql );
            }
        }
        /// <summary>
        /// Method for setting the database file location
        /// </summary>
        /// <returns>String of path the database file</returns>
        public static string SqliteDbPath()
        {
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NoteStorage.sqlite3";
            return dbPath;
        }
        /// <summary>
        /// Initializes various connection strings for multiple databases
        /// </summary>
        /// <param name="name">Databse name used to determine which connection string to output</param>
        /// <returns>String of connection string needed to connect to the database</returns>
        public static string CnnString(string name)
        {
            if (name == "NoteStorage")
            {
                string sql = "Data Source=" + SqliteDbPath();
                return sql;
            }
            else
            {
                return "";       
            }
        }
    }
}
