using System.Collections.Generic;
using System.Xml.Serialization;

namespace BingoPlanner.Data
{
    public class Goal
    {
        public string Title { get; set; }
        public string Notes { get; set; }
        [XmlElement("Conflict")]
        public List<string> ConflictingGoals { get; set; }

        public Goal()
        {
            Title = "";
            Notes = "";
            ConflictingGoals = new List<string>();
        }
    }
}
