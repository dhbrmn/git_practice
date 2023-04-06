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
        /// <summary>
        /// Saves a note to the database.
        /// </summary>
        /// <param name="model">The NoteModel created by inputing the Title and Body, but has no ID.</param>
        /// <returns>The saved NoteModel from the db with the ID.</returns>
        public NoteModel CreateNote( NoteModel model )
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var n = new DynamicParameters();

                n.Add("@Title", model.Title);
                n.Add("@Body", model.Body);
                n.Add("@Date", model.Date);

                connection.Execute("INSERT INTO Notes (Title, Body, Date) VALUES (@Title, @Body, @Date)", n, commandType: CommandType.Text);
                Int64 lastId64 = (Int64)connection.ExecuteScalar("SELECT last_insert_rowid()");
                int lastId = (int)lastId64;

                model.ID = lastId;

                return model;
            }
        }
        public NoteModel ReadNote( int id )
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var input = new DynamicParameters();
                input.Add("@ID", id);
                NoteModel model = (NoteModel)connection.QuerySingle<NoteModel> ("SELECT * FROM Notes WHERE ID = @ID", input ,commandType: CommandType.Text);
                return model;
            }
        }
        //public NoteModel UpdateNote( NoteModel model )
        //{
        //    using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
        //    {
        //        var n = new DynamicParameters();
        //        // TODO - Make it so it can update an already saved note with new parameters
        //    }
        //}
        public void DeleteNote( NoteModel model )
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var n = new DynamicParameters();
                n.Add("@ID", model.ID);
                connection.Execute("DELETE FROM Notes WHERE ID = @ID", n, commandType: CommandType.Text);
            }
        }
        public NoteModel[] GetAllNotes()
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                int rows = RowsNumber();
                var notesArray = connection.Query<NoteModel>("SELECT * FROM Notes", commandType: CommandType.Text).ToArray();
                return notesArray;
            }
        }

        public int RowsNumber()
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                Int64 rowsInt64 = (Int64)connection.ExecuteScalar("SELECT COUNT (*) FROM Notes");
                int rows = (int)rowsInt64;
                return rows;
            }
        }
    }
}
