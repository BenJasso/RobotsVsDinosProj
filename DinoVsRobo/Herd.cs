using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class Herd
    {
        public Dinosaur trex;
        public Dinosaur teradactol;
        public Dinosaur raptor;
        


        public Herd()
        {
          trex = new Dinosaur("Trex", 400);
          teradactol = new Dinosaur("Teradactol", 200);
          raptor = new Dinosaur("Raptor", 100);
        }
        

    }
}
