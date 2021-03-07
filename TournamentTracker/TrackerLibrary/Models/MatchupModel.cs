using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> MyProperty { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents winner team.
        /// </summary>
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
