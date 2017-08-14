using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemons> playerLemons;
        public List<Sugar> playerSugar;
        public List<Cups> playerCups;
        public List<IceCubes> playerIceCubes;

        public Inventory()
        {
            playerLemons = new List<Lemons>();
            playerSugar = new List<Sugar>();
            playerCups = new List<Cups>();
            playerIceCubes = new List<IceCubes>();
        }
    }
}
           
            

            
