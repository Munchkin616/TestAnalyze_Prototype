using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestAnalyze_Prototype
{
    class Neuro
    {

        bool flag;
        private List<DataBank> data = new List<DataBank>();
        StreamReader reader = new StreamReader("ResultForAnalyse.txt");
        StreamWriter stepslearn = new StreamWriter(new FileStream("StepsLearn.txt", FileMode.Create, FileAccess.Write));
        StreamWriter resultlearn = new StreamWriter(new FileStream("ResultLearn.txt", FileMode.Create, FileAccess.Write));
        
        //double diff2SV, diff2SE, diff2SA;
        //double wSV = 0.333333333333333, wSE = 0.333333333333333, wSA = 0.333333333333333;
        double wSV = 0.6, wSE = 0.6, wSA = 0.6;
        //const double border = (2 / 3);
        const double border = 0.666666666666667;
        bool DoneLearn = false;
        const int EpochLearn = 100000;
        int step = 0;
        string savetext;

        private void ReadInfo()
        {
            try
            {
                string line;


                while ((line = reader.ReadLine()) != null)
                {
                    string[] sub = line.Split(' ');
                    if (sub[7] == "true")
                    {
                        DataBank ReadData = new DataBank(sub[0], sub[1], sub[2], Convert.ToInt32(sub[3]));
                        ReadData.SaveRes(Convert.ToDouble(sub[4]), Convert.ToDouble(sub[5]), Convert.ToDouble(sub[6]));
                        ReadData.SetResultLearn(Convert.ToInt32(sub[8]));
                        data.Add(ReadData);
                    }
                }
                flag = true;
            }
            catch
            {
                flag = false;
            }
        }

        /*public void LearningNeuro()
        {
            ReadInfo();
            if (flag)
            {
                do
                {
                    int res = 1;
                    data[0].SetResult(res);
                    if (CountParams(data[1].RetS_V(), data[0].RetS_V()) > border * wSV ||
                        CountParams(data[1].RetS_E(), data[0].RetS_E()) > border * wSE ||
                        CountParams(data[1].RetS_A(), data[0].RetS_A()) > border * wSA) { res++; }

                    data[1].SetResult(res);
                    for (int i = 2; i < 10; i++)
                    {
                        MdiffSV = CountParams(data[i].RetS_V(), data[0].RetS_V());
                        MdiffSE = CountParams(data[i].RetS_E(), data[0].RetS_E());
                        MdiffSA = CountParams(data[i].RetS_A(), data[0].RetS_A());
                        data[i].SetResult(data[0].RetResult());
                        for (int j = 1; j < i; j++)
                        {
                            diffSV = CountParams(data[i].RetS_V(), data[j].RetS_V());
                            diffSE = CountParams(data[i].RetS_E(), data[j].RetS_E());
                            diffSA = CountParams(data[i].RetS_A(), data[j].RetS_A());
                            if (MdiffSV > diffSV || MdiffSE > diffSE || MdiffSA > diffSA)
                            {
                                data[i].SetResult(data[j].RetResult());
                                MdiffSV = diffSV;
                                MdiffSE = diffSE;
                                MdiffSA = diffSA;
                            }
                        }
                        if (MdiffSV > border * wSV || MdiffSE > border * wSE || MdiffSA > border * wSA)
                        {
                            res++;
                            data[i].SetResult(res);
                        }
                    }

                    bool flag = true;

                    for (int i = 1; i < 10; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (((data[i].RetResultLearn() == data[j].RetResultLearn() && data[i].RetResult() != data[j].RetResult())
                                || (data[i].RetResultLearn() != data[j].RetResultLearn() && data[i].RetResult() == data[j].RetResult())) && flag)
                            {
                                //if ()
                                {
                                    flag = false;
                                    double ErrorSV = CountParamsNonMod(data[i].RetS_V(), data[j].RetS_V());
                                    double ErrorSE = CountParamsNonMod(data[i].RetS_E(), data[j].RetS_E());
                                    double ErrorSA = CountParamsNonMod(data[i].RetS_A(), data[j].RetS_A());
                                    double CorrSV = ErrorSV / BigParams(data[i].RetS_V(), data[j].RetS_V());
                                    double CorrSE = ErrorSE / BigParams(data[i].RetS_E(), data[j].RetS_E());
                                    double CorrSA = ErrorSA / BigParams(data[i].RetS_A(), data[j].RetS_A());
                                    wSV += ErrorSV;
                                    wSE += ErrorSE;
                                    wSA += ErrorSA;
                                    savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}",step, i+1, j+1);
                                    stepslearn.WriteLine(savetext);
                                    break;
                                    
                                }
                                if (!flag) break;
                            }
                        }
                    }

                    if (flag) { DoneLearn = true;  }
                    else { DoneLearn = false;  }
                    
                    step++;
                } while (DoneLearn == false && step < EpochLearn);
                if (DoneLearn) {  savetext = String.Format("Обучение прошло успешно на шаге {0}.", step); }
                else {  savetext = String.Format("Обучение закончилось на конце эпохи. "); }
                stepslearn.WriteLine(savetext);
                stepslearn.Close();
                for (int i = 0; i < data.Count; i++)
                {
                    savetext = String.Format("{0} {1} {2} {3} {4} {5} {6}; истинный результат: {7}; полученный результат: {8}", 
                        data[i].RetSurname(), data[i].RetName(), data[i].RetDadname(), data[i].RetDadname(),
                        data[i].RetS_V(), data[i].RetS_E(), data[i].RetS_A(), data[i].RetResultLearn(), data[i].RetResult());
                    resultlearn.WriteLine(savetext);
                }
                resultlearn.Close();
            }
        }*/

        /*private double CountParams(double Stat, double Dynam)
        {
            double countRes;
            if (Dynam > Stat)
                if (Dynam < 0) if (Stat < 0) countRes = Dynam + Stat; else countRes = Dynam - Stat;
                else if (Stat < 0) countRes = Dynam - Stat; else countRes = Dynam + Stat;
            else if (Dynam < 0) if (Stat < 0) countRes = Stat + Dynam; else countRes = Stat - Dynam;
            else if (Stat < 0) countRes = Stat - Dynam; else countRes = Stat + Dynam;
            if (countRes < 0) return countRes * -1;
            else return countRes;
        }*/

        public void LearningNeuro()
        {
            ReadInfo();
            if (flag)
            {
                do
                {

                    step++;

                    for (int i = 0; i < data.Count; i++)
                    {
                        data[i].SetResult(ResCheck(data[i].RetS_V(), data[i].RetS_E(), data[i].RetS_A()));
                    }

                    double Error;
                    double Correction;
                    double Smooth = 0.07;
                    bool fl = true;
                    for (int i = 1; i < data.Count; i++)
                    {
                        if (fl)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                double ysl1 = data[i].RetS_V(), ysl2 = data[j].RetS_V();
                                double ysl3 = data[i].RetS_E(), ysl4 = data[j].RetS_E();
                                double ysl5 = data[i].RetS_A(), ysl6 = data[j].RetS_A();
                                if (data[i].RetResultLearn() == data[j].RetResultLearn() && data[i].RetResult() != data[j].RetResult())
                                {

                                    if ((ysl1 < wSV && ((ysl2 >= wSV && ysl2 <= wSV) || ysl2 > wSV)) ||
                                        ((ysl1 >= wSV && ysl1 <= wSV) && (ysl2 > wSV || ysl2 <= wSV)) ||
                                        (ysl1 > wSV && ((ysl2 >= wSV && ysl2 <= wSV) || ysl2 < wSV)))
                                    {
                                        if (CountParams(data[i].RetS_V(), data[j].RetS_V()) < wSV)
                                        {
                                            Error = CountParams(data[i].RetS_V(), data[j].RetS_V());
                                            if (Error != 0)
                                                Correction = (Error / wSV) * Smooth;
                                            else
                                                Correction = Smooth;
                                            wSV -= Correction;
                                            fl = false;
                                            savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}; ситуация 1 {3} {4} {5}", step, i + 1, j + 1, wSV, wSE, wSA);
                                            stepslearn.WriteLine(savetext);
                                            break;
                                        }
                                        else
                                        {
                                            Error = CountParams(data[i].RetS_V(), data[j].RetS_V());
                                            if (Error != 0)
                                                Correction = (1 - (wSV / Error)) * Smooth;
                                            else
                                                Correction = Smooth;
                                            wSV += Correction;
                                            fl = false;
                                            savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}; ситуация 2 {3} {4} {5}", step, i + 1, j + 1, wSV, wSE, wSA);
                                            stepslearn.WriteLine(savetext);
                                            break;
                                        }
                                    }
                                    else if ((ysl3 < wSE && ((ysl4 >= wSE && ysl4 <= wSE) || ysl4 > wSE)) ||
                                        ((ysl3 >= wSE && ysl3 <= wSE) && (ysl4 > wSE || ysl4 <= wSE)) ||
                                        (ysl3 > wSE && ((ysl4 >= wSE && ysl4 <= wSE) || ysl4 < wSE)))
                                    {
                                        if (CountParams(data[i].RetS_E(), data[j].RetS_E()) < wSE)
                                        {
                                            Error = CountParams(data[i].RetS_E(), data[j].RetS_E());
                                            if (Error != 0)
                                                Correction = (Error / wSE) * Smooth;
                                            else
                                                Correction = Smooth;
                                            wSE -= Correction;
                                            fl = false;
                                            savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}; ситуация 3", step, i + 1, j + 1);
                                            stepslearn.WriteLine(savetext);
                                            break;
                                        }
                                        else
                                        {
                                            Error = CountParams(data[i].RetS_E(), data[j].RetS_E());
                                            if (Error != 0)
                                                Correction = (1 - (wSE / Error)) *Smooth;
                                            else
                                                Correction = Smooth;
                                            wSE += Correction;
                                            fl = false;
                                            savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}; ситуация 4", step, i + 1, j + 1);
                                            stepslearn.WriteLine(savetext);
                                            break;
                                        }
                                    }
                                    else if ((ysl5 < wSA && ((ysl6 >= wSA && ysl6 <= wSA) || ysl6 > wSA)) ||
                                        ((ysl5 >= wSA && ysl5 <= wSA) && (ysl6 > wSA || ysl6 <= wSA)) ||
                                        (ysl5 > wSA && ((ysl6 >= wSA && ysl6 <= wSA) || ysl6 < wSA)))
                                    {
                                        if (CountParams(data[i].RetS_A(), data[j].RetS_A()) < wSA)
                                        {
                                            Error = CountParams(data[i].RetS_A(), data[j].RetS_A());
                                            if (Error != 0)
                                                Correction = (wSA / Error) * Smooth;
                                            else
                                                Correction = Smooth;
                                            wSA -= Correction;
                                            fl = false;
                                            savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}; ситуация 5", step, i + 1, j + 1);
                                            stepslearn.WriteLine(savetext);
                                            break;
                                        }
                                        else
                                        {
                                            Error = CountParams(data[i].RetS_A(), data[j].RetS_A());
                                            if (Error != 0)
                                                Correction = (1 - (Error / wSA)) * Smooth;
                                            else
                                                Correction = Smooth;
                                            wSA += Correction;
                                            fl = false;
                                            savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}; ситуация 6 {3} {4} {5}", step, i + 1, j + 1, wSV, wSE, wSA);
                                            stepslearn.WriteLine(savetext);
                                            break;
                                        }
                                    }
                                }
                                else if (data[i].RetResultLearn() != data[j].RetResultLearn() && data[i].RetResult() == data[j].RetResult())
                                {
                                    if (CountParams(data[i].RetS_V(), data[j].RetS_V()) < CountParams(data[i].RetS_E(), data[j].RetS_E()) &&
                                         CountParams(data[i].RetS_V(), data[j].RetS_V()) < CountParams(data[i].RetS_A(), data[j].RetS_A()))
                                    {
                                        Error = CountParams(data[i].RetS_V(), data[j].RetS_V());
                                        if (Error != 0)
                                            Correction = (Error / wSV) * Smooth;
                                        else
                                            Correction = Smooth;
                                        wSV -= Correction;
                                        fl = false;
                                        savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}; ситуация 7", step, i + 1, j + 1);
                                        stepslearn.WriteLine(savetext);
                                        break;
                                    }
                                    else if (CountParams(data[i].RetS_E(), data[j].RetS_E()) > CountParams(data[i].RetS_V(), data[j].RetS_V()) &&
                                         CountParams(data[i].RetS_E(), data[j].RetS_E()) > CountParams(data[i].RetS_A(), data[j].RetS_A()))
                                    {
                                        Error = CountParams(data[i].RetS_E(), data[j].RetS_E());
                                        if (Error != 0)
                                        Correction = (Error / wSE) * Smooth;
                                        else
                                            Correction = Smooth;
                                        wSE -= Correction;
                                        fl = false;
                                        savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}; ситуация 8 {3} {4} {5}", step, i + 1, j + 1, wSV, wSE, wSA);
                                        stepslearn.WriteLine(savetext);
                                        break;
                                    }
                                    else if (CountParams(data[i].RetS_A(), data[j].RetS_A()) > CountParams(data[i].RetS_E(), data[j].RetS_E()) &&
                                         CountParams(data[i].RetS_A(), data[j].RetS_A()) > CountParams(data[i].RetS_V(), data[j].RetS_V()))
                                    {
                                        Error = CountParams(data[i].RetS_A(), data[j].RetS_A());
                                        if (Error != 0)
                                            Correction = (Error / wSA) * Smooth;
                                        else
                                            Correction = Smooth;
                                        wSA -= Correction;
                                        fl = false;
                                        savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}; ситуация 9 {3} {4} {5}", step, i + 1, j + 1, wSV, wSE, wSA);
                                        stepslearn.WriteLine(savetext);
                                        break;
                                    }
                                }
                            } 
                        }
                    }

                    if (fl) { DoneLearn = true; }
                    else { DoneLearn = false; }

                    
                } while (DoneLearn == false && step < EpochLearn);
                if (DoneLearn) { savetext = String.Format("Обучение прошло успешно на шаге {0}.", step); }
                else { savetext = String.Format("Обучение закончилось на конце эпохи. {0} {1} {2}", wSV, wSE, wSA); }
                stepslearn.WriteLine(savetext);
                stepslearn.Close();
                for (int i = 0; i < data.Count; i++)
                {
                    savetext = String.Format("{0} {1} {2} {3} {4} {5} {6}; истинный результат: {7}; полученный результат: {8}",
                        data[i].RetSurname(), data[i].RetName(), data[i].RetDadname(), data[i].RetDadname(),
                        data[i].RetS_V(), data[i].RetS_E(), data[i].RetS_A(), data[i].RetResultLearn(), data[i].RetResult());
                    resultlearn.WriteLine(savetext);
                }
                resultlearn.Close();
            }

        }



        private double CountParams(double Stat, double Dynam)
        {
            double countRes = 0;
            if (Dynam > Stat)
                if (Dynam < 0) { if (Stat < 0) { countRes = Dynam - Stat; }  } else { if (Stat < 0) { countRes = Dynam + Stat; } else { countRes = Dynam - Stat; } }
            else
                if (Stat < 0) { if (Dynam < 0) { countRes = Stat - Dynam; } } else { if (Dynam < 0) { countRes = Stat + Dynam; } else { countRes = Stat - Dynam; } }
            return countRes;
        }

        private double CountParamsNonMod(double Stat, double Dynam)
        {
            double countRes;
            //if (Dynam < 0) if (Stat < 0) countRes = Dynam + Stat; else countRes = Dynam - Stat;
            //else if (Stat < 0) countRes = Dynam - Stat; else countRes = Dynam + Stat;
            if (Dynam > Stat)
                countRes = CountParams(Stat, Dynam);
            else
                countRes = -CountParams(Stat, Dynam);
            return countRes;
        }
        private double BigParams(double One, double Two)
        {
            double BigPar;
            if (One > Two) BigPar = One;
            else BigPar = Two;
            if (BigPar < 0) return BigPar * -1;
            else return BigPar;
        }

        public int ResCheck(double S_Vic, double S_Eic, double S_Aic)
        {
             int result = 0;
             //const decimal bord = (4 / 3) - 1;
             const double DownBord = -1;
             const double UpBord = 1;
             
            if (S_Vic < DownBord * wSV && S_Eic < DownBord * wSE && S_Aic < DownBord * wSA) result = 1;
             if (S_Vic < DownBord * wSV && S_Eic < DownBord * wSE && S_Aic >= DownBord * wSA && S_Aic <= UpBord * wSA) result = 2;
             if (S_Vic < DownBord * wSV && S_Eic < DownBord * wSE && S_Aic > UpBord * wSA) result = 3;
             if (S_Vic < DownBord * wSV && S_Eic >= DownBord * wSE && S_Eic <= UpBord * wSE && S_Aic < DownBord * wSA) result = 4;
             if (S_Vic < DownBord * wSV && S_Eic >= DownBord * wSE && S_Eic <= UpBord * wSE && S_Aic >= DownBord * wSA && S_Aic <= UpBord * wSA) result = 5;
             if (S_Vic < DownBord * wSV && S_Eic >= DownBord * wSE && S_Eic <= UpBord * wSE && S_Aic > UpBord * wSA) result = 6;
             if (S_Vic < DownBord * wSV && S_Eic > UpBord * wSE && S_Aic < DownBord * wSA) result = 7;
             if (S_Vic < DownBord * wSV && S_Eic > UpBord * wSE && S_Aic >= DownBord * wSA && S_Aic <= UpBord * wSA) result = 8;
             if (S_Vic < DownBord * wSV && S_Eic > UpBord * wSE && S_Aic > UpBord * wSA) result = 9;
             if (S_Vic >= DownBord * wSV && S_Vic <= UpBord * wSV && S_Eic  < DownBord * wSE && S_Aic < DownBord * wSA) result = 10;
             if (S_Vic >= DownBord * wSV && S_Vic <= UpBord * wSV && S_Eic  < DownBord * wSE && S_Aic >= DownBord * wSA && S_Aic <= UpBord * wSA) result = 11;
             if (S_Vic >= DownBord * wSV && S_Vic <= UpBord * wSV && S_Eic < DownBord * wSE && S_Aic > UpBord * wSA) result = 12;
             if (S_Vic >= DownBord * wSV && S_Vic <= UpBord * wSV && S_Eic >= DownBord * wSE && S_Eic <= UpBord * wSE && S_Aic < DownBord * wSA) result = 13;
             if (S_Vic >= DownBord * wSV && S_Vic <= UpBord * wSV && S_Eic >= DownBord * wSE && S_Eic <= UpBord * wSE && S_Aic >= DownBord * wSA && S_Aic <= UpBord * wSA) result = 14;
             if (S_Vic >= DownBord * wSV && S_Vic <= UpBord * wSV && S_Eic >= DownBord * wSE && S_Eic <= UpBord * wSE && S_Aic > UpBord * wSA) result = 15;
             if (S_Vic >= DownBord * wSV && S_Vic <= UpBord * wSV && S_Eic > UpBord * wSE && S_Aic < DownBord * wSA) result = 16;
             if (S_Vic >= DownBord * wSV && S_Vic <= UpBord * wSV && S_Eic > UpBord * wSE && S_Aic >= DownBord * wSA && S_Aic <= UpBord * wSA) result = 17;
             if (S_Vic >= DownBord * wSV && S_Vic <= UpBord * wSV && S_Eic > UpBord * wSE && S_Aic > UpBord * wSA) result = 18;
             if (S_Vic > UpBord * wSV && S_Eic < DownBord * wSE && S_Aic < DownBord * wSA) result = 19;
             if (S_Vic > UpBord * wSV && S_Eic < DownBord * wSE && S_Aic >= DownBord * wSA && S_Aic <= UpBord * wSA) result = 20;
             if (S_Vic > UpBord * wSV && S_Eic < DownBord * wSE && S_Aic > UpBord * wSA) result = 21;
             if (S_Vic > UpBord * wSV && S_Eic >= DownBord * wSE && S_Eic <= UpBord * wSE && S_Aic < DownBord * wSA) result = 22;
             if (S_Vic > UpBord * wSV && S_Eic >= DownBord * wSE && S_Eic <= UpBord * wSE && S_Aic >= DownBord * wSA && S_Aic <= UpBord * wSA) result = 23;
             if (S_Vic > UpBord * wSV && S_Eic >= DownBord * wSE && S_Eic <= UpBord * wSE && S_Aic > UpBord * wSA) result = 24;
             if (S_Vic > UpBord * wSV && S_Eic > UpBord * wSE && S_Aic < DownBord * wSA) result = 25;
             if (S_Vic > UpBord * wSV && S_Eic > UpBord * wSE && S_Aic >= DownBord * wSA && S_Aic <= UpBord * wSA) result = 26;
             if (S_Vic > UpBord * wSV && S_Eic > UpBord * wSE && S_Aic > UpBord * wSA) result = 27;

             return result; 


           
        }

        

        /* if (CountParams(data[i].RetS_V(), data[j].RetS_V()) > CountParams(data[i].RetS_E(), data[j].RetS_E()) &&
                                         CountParams(data[i].RetS_V(), data[j].RetS_V()) > CountParams(data[i].RetS_A(), data[j].RetS_A()))
                                     {
                                         Error = BigParams(data[i].RetS_V(), data[j].RetS_V()) - CountParams(data[i].RetS_V(), data[j].RetS_V());
                                         Correction = Error / BigParams(data[i].RetS_V(), data[j].RetS_V());
                                         wSV -= Correction;
                                         fl = false;
                                         savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}", step, i + 1, j + 1);
                                         stepslearn.WriteLine(savetext);
                                         break;
                                     }
                                     if (CountParams(data[i].RetS_E(), data[j].RetS_E()) > CountParams(data[i].RetS_V(), data[j].RetS_V()) &&
                                         CountParams(data[i].RetS_E(), data[j].RetS_E()) > CountParams(data[i].RetS_A(), data[j].RetS_A()))
                                     {
                                         Error = BigParams(data[i].RetS_E(), data[j].RetS_E()) - CountParams(data[i].RetS_E(), data[j].RetS_E());
                                         Correction = Error / BigParams(data[i].RetS_E(), data[j].RetS_E());
                                         wSE -= Correction;
                                         fl = false;
                                         savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}", step, i + 1, j + 1);
                                         stepslearn.WriteLine(savetext);
                                         break;
                                     }
                                     if (CountParams(data[i].RetS_A(), data[j].RetS_A()) > CountParams(data[i].RetS_E(), data[j].RetS_E()) &&
                                         CountParams(data[i].RetS_A(), data[j].RetS_A()) > CountParams(data[i].RetS_V(), data[j].RetS_V()))
                                     {
                                         Error = BigParams(data[i].RetS_A(), data[j].RetS_A()) - CountParams(data[i].RetS_A(), data[j].RetS_A());
                                         Correction = Error / BigParams(data[i].RetS_A(), data[j].RetS_A());
                                         wSA -= Correction;
                                         fl = false;
                                         savetext = String.Format("Шаг: {0}, остановка на объекте {1}, не совпадение с объектом {2}", step, i + 1, j + 1);
                                         stepslearn.WriteLine(savetext);
                                         break;
                                     } 
    } */

    }
}
