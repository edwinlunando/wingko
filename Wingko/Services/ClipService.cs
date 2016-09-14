using SQLite;
using Wingko.Models;

namespace Wingko.Services
{
    class ClipService
    {

        private SQLiteConnection _database;

        public ClipService()
        {
            _database = new SQLiteConnection("wingko.db");
        }

        public Clip SaveNewClip(Clip.ClipType type, string content)
        {
            Clip clip = new Clip();
            clip.Type = (int)type;
            clip.Content = content;
            _database.Insert(clip);
            return clip;
        }

    }
}
