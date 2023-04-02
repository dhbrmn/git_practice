using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;
using NotemanLibrary.Models;

namespace NotemanLibrary.DataAccess
{
    public class SQLiteConnector : IDataConnection
    {
        // TODO - Naredi da bo vse skupaj dejansko shranjevalo v db
        /// <summary>
        /// Saves a note to the database.
        /// </summary>
        /// <param name="model">The complete assembeled note.</param>
        /// <returns>The whole note model including the unique identifier.</returns>
        public NoteModel CreateNote(NoteModel model)
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var n = new DynamicParameters();

                n.Add("@Title", model.Title);
                n.Add("@Body", model.Body);
               // n.Add("@Date", model.Date);

                connection.Execute("INSERT INTO Notes (Title, Body) VALUES (@Title, @Body)", n, commandType: CommandType.Text);
                Int64 lastId64 = (Int64)connection.ExecuteScalar("SELECT last_insert_rowid()");
                int lastId = (int)lastId64;

                model.Id = lastId;
                
                return model;
            }
        }
    }
}
