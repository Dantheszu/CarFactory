using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class Car
    {
        public Car()
        {
            Marka = "markaPodstawowa";
            Model = "modelPodstawowy";
        }
        public string Marka { get; private set; }

        public string Model { get; private set; }

        public void Drive(float dystans)
        {
            string jazda = "";

            if (dystans > 0)
            {
                jazda = ("jade");
            }
            else if (dystans <= 0)
            {
                jazda = ("Stop");
            }
                      
        }
        public void Trąb()
        {
            
        }

    }

}
