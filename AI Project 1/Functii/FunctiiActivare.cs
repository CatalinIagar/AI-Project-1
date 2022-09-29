using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Project_1.Functii
{
    public class FunctiiActivare
    {
        static public double calculActivareTreapta(Neuron neuron)
        {
            if (neuron.ginput >= neuron.teta) return 1;
            return 0;
        }

        static public double calculActivareSemn(Neuron neuron)
        {
            if (neuron.ginput >= neuron.teta) return 1;
            return -1;
        }

        static public double calculActivareSigmoidala(Neuron neuron)
        {
            double numarator = 1f;
            double numitor = 1 + Math.Pow(Math.E, -1 * neuron.g * (neuron.ginput - neuron.teta));
            return numarator / numitor;
        }

        static public double calculActivareTanh(Neuron neuron)
        {
            double numarator = Math.Pow(Math.E, neuron.g * (neuron.ginput - neuron.teta)) - Math.Pow(Math.E, -1 * neuron.g * (neuron.ginput - neuron.teta));
            double numitor = Math.Pow(Math.E, neuron.g * (neuron.ginput - neuron.teta)) + Math.Pow(Math.E, -1 * neuron.g * (neuron.ginput - neuron.teta));
            return numarator / numitor ;
        }

        static public double calculActivareLiniara(Neuron neuron)
        {
            if (neuron.ginput - neuron.teta < -1/neuron.g) return -1;
            if (neuron.ginput - neuron.teta > 1/neuron.g) return 1;
            return (neuron.ginput - neuron.teta) * neuron.g;
        }
    }
}
