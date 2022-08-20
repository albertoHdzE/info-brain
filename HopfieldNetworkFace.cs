using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Encog.Neural.Networks.Layers;
using Encog.Neural.Thermal;
using Encog.MathUtil;
using Encog.MathUtil.Matrices;
using Encog.ML.Data.Specific;
using Encog.ML.Data.Basic;
using Encog.ML.Data;
using Encog.ML;

namespace WolframAlgorithm
{
    class HopfieldNetworkFace
    {

        public const int GRID_X = 20;
        public const int GRID_Y = 20;
        public const int CELL_WIDTH = 10;
        public const int CELL_HEIGHT = 10;
        public HopfieldNetwork hopfield;
        private bool[] grid;

        public HopfieldNetworkFace()
        {
            this.hopfield = new HopfieldNetwork(HopfieldNetworkFace.GRID_X * HopfieldNetworkFace.GRID_Y);
            grid = new bool[HopfieldNetworkFace.GRID_X * HopfieldNetworkFace.GRID_Y];
        }


        /// <summary>
        /// Presenta un patron a la red de hopfield
        /// </summary>
        /// <param name="grid">la malla en pantalla</param>
        public void Train(bool[] grid)
        {
            var input = new BiPolarMLData(grid);
            this.hopfield.AddPattern(input);
        }



        public bool[] IML2Boolean(IMLData b)
        {
            bool[] result = new bool[b.Count];

            for (int i = 0; i < b.Count; i++)
            {
                if (b[i] > 0)
                {
                    result[i] = true;
                }
                else
                {
                    result[i] = false;
                }

            }

            return result;
        }


    }
}
