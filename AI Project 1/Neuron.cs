using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Project_1
{
    public class Neuron
    {
        public int nOfInputs;
        public double[] x;
        public double[] w;
        public double g;
        public double teta;
        public double ginput;
        public double activation;
        public double output;

        public Neuron()
        {
            nOfInputs = 0;
            g = 1;
            teta = 0;
            ginput = 0;
            activation = 0;
            output = 0;
        }

    }
}
