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
        /// <summary>
        /// Reads a note from the database using it's ID parameter
        /// </summary>
        /// <param name="id">Unique identifier of a note</param>
        /// <returns>A stored note as NoteModel</returns>
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
        /// <summary>
        /// Updates an edited note entry
        /// </summary>
        /// <param name="model">New note model that has been edited</param>
        public void UpdateNote( NoteModel model )
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var n = new DynamicParameters();

                n.Add("@ID", model.ID);
                n.Add("@Title", model.Title);
                n.Add("@Body", model.Body);
                n.Add("@Date", model.Date);

                connection.Execute("UPDATE Notes SET Title = @Title, Body = @Body, Date = @Date WHERE ID = @ID", n, commandType: CommandType.Text);
            }
        }
        /// <summary>
        /// Deletes a stored note(row) from the database
        /// </summary>
        /// <param name="model">NoteModel of the note entry that will be deleted</param>
        public void DeleteNote( NoteModel model )
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var n = new DynamicParameters();
                n.Add("@ID", model.ID);
                connection.Execute("DELETE FROM Notes WHERE ID = @ID", n, commandType: CommandType.Text);
            }
        }
        /// <summary>
        /// Deletes a stored note(row) from the database including the attachments
        /// </summary>
        /// <param name="model">NoteModel of the note entry that will be deleted</param>
        public void DeleteNoteWithAttachment( NoteModel model )
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var n = new DynamicParameters();
                n.Add("@ID", model.ID);
                connection.Execute("DELETE FROM Attachments WHERE NoteID = @ID", n, commandType: CommandType.Text);
                connection.Execute("DELETE FROM Notes WHERE ID = @ID", n, commandType: CommandType.Text);
            }
        }
        /// <summary>
        /// Deletes a single attachment using its ID
        /// </summary>
        /// <param name="attachment">AttachmentModel with unique ID</param>
        public void DeleteAttachment( AttachmentModel attachment )
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var n = new DynamicParameters();
                n.Add("@ID", attachment.ID);
                connection.Execute("DELETE FROM Attachments WHERE ID = @ID", n, commandType: CommandType.Text);
            }
        }
        /// <summary>
        /// Calls a query to read all stored notes in the databse
        /// </summary>
        /// <returns>Array of all stored notes in the database</returns>
        public NoteModel[] GetAllNotes()
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                int rows = NotesNumber();
                var notesArray = connection.Query<NoteModel>("SELECT * FROM Notes", commandType: CommandType.Text).ToArray();
                return notesArray;
            }
        }
        /// <summary>
        /// Method aquires the number of stored notes in the database
        /// </summary>
        /// <returns>Number of stored notes as an integer32</returns>
        public int NotesNumber()
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                Int64 rowsInt64 = (Int64)connection.ExecuteScalar("SELECT COUNT (*) FROM Notes");
                int rows = (int)rowsInt64;
                return rows;
            }
        }
        /// <summary>
        /// Saves an attachment to the database
        /// </summary>
        /// <param name="attachment">Attachment stored on local disk</param>
        public void StoreAttach( AttachmentModel attachment )
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var n = new DynamicParameters();

                n.Add("@NoteID", attachment.NoteId);
                n.Add("@Name", attachment.Name);
                n.Add("@AttachmentPath", attachment.AttachmentPath);

                connection.Execute("INSERT INTO Attachments (NoteID, Name, AttachmentPath) VALUES (@NoteID, @Name, @AttachmentPath)", n, commandType: CommandType.Text);
            }
        }
        /// <summary>
        /// Reads all attachments stored in the database
        /// </summary>
        /// <returns>Array of AttachmentModel for each row in the attachments database</returns>
        public AttachmentModel[] GetAllAttachments()
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                int rows = AttachmentNumber();
                var attachmentsArray = connection.Query<AttachmentModel>("SELECT * FROM Attachments", commandType: CommandType.Text).ToArray();
                return attachmentsArray;
            }
        }
        /// <summary>
        /// Gets the number of all rows stored in the attachment database
        /// </summary>
        /// <returns>Integer of rows in the attachment database</returns>
        public int AttachmentNumber()
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                Int64 rowsInt64 = (Int64)connection.ExecuteScalar("SELECT COUNT (*) FROM Attachments");
                int rows = (int)rowsInt64;
                return rows;
            }
        }
        /// <summary>
        /// Reads attachment info stored in the database linked to a note stored in the database
        /// </summary>
        /// <param name="id">ID of the stored note that is linked to the attachment</param>
        /// <returns>Fully populated AttachmentModel with all the information from the database</returns>
        public AttachmentModel ReadAttachment( int id )
        {
            using (IDbConnection connection = new SqliteConnection(GlobalConfig.CnnString("NoteStorage")))
            {
                var input = new DynamicParameters();
                input.Add("@NoteID", id);
                AttachmentModel model = (AttachmentModel)connection.QuerySingle<AttachmentModel>("SELECT * FROM Attachments WHERE ID = @NoteID", input, commandType: CommandType.Text);
                return model;
            }
        }
    }
}
