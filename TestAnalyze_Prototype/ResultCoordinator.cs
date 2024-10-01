using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnalyze_Prototype
{
    class ResultCoordinator
    {

        public double S_Vic = 0, S_Eic = 0, S_Aic = 0; int result = 0;
        double S_V, S_E, S_A;

        Neuro neuro = new Neuro();

        public ResultCoordinator()
        {

        }

        public void CountResult(List<int> SVi, List<int> SEi, List<int> SAi, int CountSV, int CountSE, int CountSA)
        {
            for (int i = 0; i < SVi.Count; i++)
            {
                S_Vic += SVi[i];
            }

            for (int i = 0; i < SEi.Count; i++)
            {
                S_Eic += SEi[i];
            }

            for (int i = 0; i < SAi.Count; i++)
            {
                S_Aic += SAi[i];
            }

            S_V = S_Vic / CountSV;
            S_E = S_Eic / CountSE;
            S_A = S_Aic / CountSA;
        }

        public double ReturnSVi()
        {
            return S_Vic;
        }

        public double ReturnSEi()
        {
            return S_Eic;
        }

        public double ReturnSAi()
        {
            return S_Aic;
        }

        public double ReturSV()
        {
            return S_V;
        }

        public double ReturSE()
        {
            return S_E;
        }

        public double ReturSA()
        {
            return S_A;
        }

        public int ReturnResult()
        {
            neuro.LearningNeuro();
            return neuro.ResCheck(S_V, S_E, S_A);
        }

        
    }
}
