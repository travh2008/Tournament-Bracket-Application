using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public list<Person> TeamMembers { get; set; }
        public string TeamName { get; set; }

        public TeamModel()
        {
            TeamMembers = new list<Person>();
        }
    }
}
