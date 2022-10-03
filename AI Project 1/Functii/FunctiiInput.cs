using System.Linq;

namespace AI_Project_1.Functii
{
    public class FunctiiInput
    {
        static public double calculInputSuma(Neuron neuron)
        {
            double sum = 0;
            for (int i = 0; i < neuron.nOfInputs; i++)
            {
                sum += neuron.x[i] * neuron.w[i];
            }
            return sum;
        }

        static public double calculInputprodus(Neuron neuron)
        {
            double prod = 0.0;

            if (neuron.nOfInputs == 0) return 0.0;

            if (neuron.nOfInputs >= 1) prod = neuron.x[0] * neuron.w[0];
            if(neuron.nOfInputs > 1)
            {
                for (int i = 1; i < neuron.nOfInputs; i++)
                {
                    prod *= neuron.x[i] * neuron.w[i];
                }
            }
            
            return prod;
        }

        static public double calculInputMaxim(Neuron neuron)
        {
            if (neuron.nOfInputs == 0) return 0;
            double[] values = new double[neuron.nOfInputs];
            for (int i = 0; i < neuron.nOfInputs; ++i)
            {
                values[i] = neuron.x[i] * neuron.w[i];
            }
            return values.Max();
        }

        static public double calculInputMinim(Neuron neuron)
        {
            if(neuron.nOfInputs == 0) return 0;
            double[] values = new double[neuron.nOfInputs];
            for (int i = 0; i < neuron.nOfInputs; ++i)
            {
                values[i] = neuron.x[i] * neuron.w[i];
            }
            return values.Min();
        }
    }
}
