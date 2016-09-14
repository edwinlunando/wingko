using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Wingko.Services
{
    class ClipService
    {

        private SQLiteConnection _database;

        public ClipService()
        {
            _database = new SQLiteConnection("wingko.db");
        }



    }
}
