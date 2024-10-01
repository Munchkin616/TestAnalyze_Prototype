using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TestAnalyze_Prototype
{
    public class DataBank
    {
        string surname;
        string name;
        string dadname;
        int age;

        double S_V;
        double S_E;
        double S_A;
        int S_C;

        int result;
        int resForLearn;

        public DataBank(string surname, string name, string dadname, int age)
        {
            this.surname = surname;
            this.name = name;
            this.dadname = dadname;
            this.age = age;
        }

        public void SaveRes(double S_V, double S_E, double S_A)
        {
            this.S_V = S_V;
            this.S_E = S_E;
            this.S_A = S_A;
        }

        public string RetSurname()
        {
            return surname;
        }

        public string RetName()
        {
            return name;
        }

        public string RetDadname()
        {
            return dadname;
        }

        public int RetAge()
        {
            return age;
        }

        public double RetS_V()
        {
            return S_V;
        }

        public double RetS_E()
        {
            return S_E;
        }

        public double RetS_A()
        {
            return S_A;
        }
        public int RetS_C()
        {
            return S_C;
        }

        public void SetResult(int res)
        {
            result = res;
        }

        public int RetResult()
        {
            return result;
        }

        public void SetResultLearn(int res)
        {
            resForLearn = res;
        }

        public int RetResultLearn()
        {
            return resForLearn;
        }

    }
}
