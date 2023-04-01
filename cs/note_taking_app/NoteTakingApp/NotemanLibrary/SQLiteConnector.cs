using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotemanLibrary
{
    public class SQLiteConnector : IDataConnection
    {
        // TODO - Naredi da bo vse skupaj dejansko shranjevalo v db
        /// <summary>
        /// Saves a note to the database.
        /// </summary>
        /// <param name="model">The complete assembeled note.</param>
        /// <returns>A whole stored note model including the unique identifier.</returns>
        public NoteModel CreateNote( NoteModel model )
        {
            model.Id = 1;

            return model;
        }
    }
}
