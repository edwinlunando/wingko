using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Wingko.Models
{
    class Clip
    {

        enum ClipType { Text, FileDrop, Image, Data, Audio};

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(8)]
        public int Type { get; set; }
    }
}
