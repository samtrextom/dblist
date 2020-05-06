using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace dblist.Model
{
    public class JokeItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Joke { get; set; }
    }
}
