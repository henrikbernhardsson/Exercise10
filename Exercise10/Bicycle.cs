using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Bicycle : Vehicle
    {
        public string FrameMaterial { get; set; }

        public Bicycle(string frameMaterial) : base("Bicycle")
        {
            this.FrameMaterial = frameMaterial;
        }
    }
}
