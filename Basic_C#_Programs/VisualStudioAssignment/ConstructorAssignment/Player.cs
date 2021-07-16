using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public List<string> Weapons { get; set; }

        // This constructor will start the game at level 1 if no saved file found.
        public Player(string name) : this(name, 1)
        {

        }
        // This constructor sets the game at the level specified in the file selected.
        public Player(string name, int currentLevel)
        {

            Name = name;
            Level = currentLevel;
            Weapons = new List<string>();
        }
    }
}
