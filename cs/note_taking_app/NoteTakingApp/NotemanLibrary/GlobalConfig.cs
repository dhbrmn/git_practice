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
                //TODO - Create the SQLite connection
                SQLiteConnector sql = new SQLiteConnector();
                Connections.Add( sql );
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


    }
}
