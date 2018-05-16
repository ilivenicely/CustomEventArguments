// Robert McCormick
// Frameworks
// term 3
// RobertMccormick_CE05


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventApp.Models
{
    public class SpaceShip
    {
        public string Name { get; set; }
        public int CrewSize { get; set; }
        public bool ActiveDuty { get; set; }

        public ShipTypeEnum ShipType { get; set; }

        public enum ShipTypeEnum
        {
            Cruiser,
            Destroyer,
            Freighter
        }

      
    }
}
