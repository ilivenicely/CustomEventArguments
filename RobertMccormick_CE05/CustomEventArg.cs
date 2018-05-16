// Robert McCormick
// Frameworks
// term 3
// RobertMccormick_CE05


using CustomEventApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventApp
{
    public class CustomEventArg : EventArgs
    {
        public SpaceShip Model { get; set; }

        public CustomEventArg(SpaceShip model)
        {
            this.Model = model;
        }
    }
}
