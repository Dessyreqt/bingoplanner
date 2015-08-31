using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BingoPlanner.Data
{
    [XmlRoot("GameDatabase")]
    public class GameDatabase
    {
        [XmlElement("Game")]
        public List<Game> Games { get; set; }
        private const string FILE_PATH = "games.xml";

        public void LoadGames()
        {
            if (File.Exists(FILE_PATH))
            {
                using (Stream reader = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Read))
                {
                    var serializer = new XmlSerializer(typeof(GameDatabase));
                    var itemDataBase = (GameDatabase)serializer.Deserialize(reader);
                    reader.Close();

                    Games = itemDataBase.Games;
                }
            }
            else
            {
                Games = new List<Game>();
                WriteGames();
            }
        }

        private void WriteGames()
        {
            using (Stream writer = new FileStream(FILE_PATH, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(GameDatabase));
                serializer.Serialize(writer, this);
                writer.Close();
            }
        }

        public void AddGame(Game newGame)
        {
            if (Games == null)
                LoadGames();

            foreach (var game in Games)
            {
                if (game.Title.ToLower().Trim() == newGame.Title.ToLower().Trim())
                {
                    game.Title = newGame.Title;
                    game.BingoUrl = newGame.BingoUrl;
                    game.LongUrl = newGame.LongUrl;
                    game.ShortUrl = newGame.ShortUrl;
                    WriteGames();

                    return;
                }
            }

            Games.Add(newGame);
            WriteGames();
        }

        public Game FindGame(string value)
        {
            if (Games == null)
                LoadGames();

            foreach (var game in Games)
            {
                if (game.Title.ToLower().Trim() == value.ToLower().Trim())
                    return game;
            }

            //Item isn't found in the database. Return an item with the name that we're looking for.
            var retVal = new Game { Title = value };
            AddGame(retVal);
            return retVal;
        }
    }
}
