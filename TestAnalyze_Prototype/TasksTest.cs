using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnalyze_Prototype
{
    class TasksTest
    {

        const int alg_teo = 2;
        const int alg_prac = 3;
        const int geo_teo = 2;
        const int geo_prac = 2;
        const int log_teo = 1;
        const int log_prac = 2;
        



        public string TaskText;
        //public string TaskFormule;
        public double GoodAnswer;
        public List<double> NormAnswer = new List<double>();
        public int mintime; public int maxtime;
        public int var1 = 1, var2 = 2, var3 = 3;
        public string vars1, vars2, vars3;
        public bool typeTP;
        public int task_count = 12;
        public int task_count_teo = alg_teo + geo_teo + log_teo;
        public int task_count_prac = alg_prac + geo_prac + log_prac;
        bool flag;


        Random rnd = new Random();
        int rndint;

        public void Tasks(int TaskNumber)
        {
            switch (TaskNumber)
            {
                case 1: {
                        typeTP = true;
                        NormAnswer.Clear();
                        mintime = 60; maxtime = 120;
                        do
                        {
                            flag = false;
                            double chs1,chs2; double zn1, zn2;
                            int ysl1, ysl2;
                            rndint = rnd.Next(2, 11);
                            ysl1 = rndint % 3; ysl2 = rndint % 7;
                            if (ysl1 != 0 && ysl2 != 0)
                            {
                                zn1 = rndint;
                                rndint = rnd.Next(2, 11);
                                ysl1 = rndint % 3; ysl2 = rndint % 7;
                                if (ysl1 != 0 && ysl2 != 0)
                                {
                                    zn2 = rndint;
                                    chs1 = rnd.Next(1, 21);
                                    chs2 = rnd.Next(1, 21);
                                    if (chs1/zn1 < chs2/zn2)
                                    {
                                        double temp = chs2; chs2 = chs1; chs1 = temp; temp = zn2; zn2 = zn1; zn1 = temp;
                                    }
                                    rndint = rnd.Next(1, 3);
                                    if (rndint == 1)
                                    {
                                        TaskText = String.Format("Вычислите: {0}/{1} + {2}/{3}. Ответ с дробью писать через запятую.", chs1, zn1, chs2, zn2);
                                        GoodAnswer = (chs1 / zn1) + (chs2 / zn2);
                                        NormAnswer.Add(GoodAnswer * zn1 * zn2);
                                        NormAnswer.Add(GoodAnswer * zn1);
                                        NormAnswer.Add(GoodAnswer * zn2);
                                        NormAnswer.Add(GoodAnswer * 10);
                                        flag = true;
                                    }
                                    else 
                                    {
                                        TaskText = String.Format("Вычислите: {0}/{1} - {2}/{3}. Ответ с дробью писать через запятую.", chs1, zn1, chs2, zn2);
                                        GoodAnswer = (chs1 / zn1) - (chs2 / zn2);
                                        NormAnswer.Add(GoodAnswer * zn1 * zn2);
                                        NormAnswer.Add(GoodAnswer * zn1);
                                        NormAnswer.Add(GoodAnswer * zn2);
                                        NormAnswer.Add(GoodAnswer * 10);
                                        flag = true;
                                    }
                                }
                            }
                        }
                        while (flag == false);
                        break; 
                        }
                case 2:
                    {
                        typeTP = false;
                        NormAnswer.Clear();
                        mintime = 30; maxtime = 60;
                        double chs1, chs2, chs3; double zn1, zn2, zn3; double mn;
                        do {
                        flag = false;
                        rndint = rnd.Next(1, 4);
                        switch (rndint)
                        {
                            case 1:
                                {
                                    zn1 = rnd.Next(1, 10);
                                    if (zn1 % 3 == 0 || zn1 % 7 == 0)
                                    {
                                        chs1 = rnd.Next(1, 21);
                                        if (chs1 % 3 != 0 && chs1 % 7 != 0 && zn1 != 2 && zn1 != 4 && zn1 != 5 && zn1 != 8)
                                        {
                                            mn = rnd.Next(2, 11);
                                            chs1 *= mn;
                                            zn1 *= mn;
                                            
                                                GoodAnswer = var1; vars1 = (chs1 + "/" + zn1);
                                                zn2 = rnd.Next(1, 10);
                                                if (zn2 % 3 == 0 || zn2 % 7 == 0)
                                                {
                                                    mn = rnd.Next(2, 11);
                                                    chs2 = zn2 * mn;
                                                    chs2 *= mn;
                                                    zn2 *= mn;
                                                    NormAnswer.Add(var2); vars2 = (chs2 + "/" + zn2);
                                                    zn3 = rnd.Next(1, 10);
                                                    chs3 = rnd.Next(1, 11);
                                                    if ((zn3 % 3 != 0 && zn3 % 7 != 0) || chs3 % zn3 ==0)
                                                    {
                                                        mn = rnd.Next(1, 21);
                                                        zn3 *= mn;
                                                        chs3 *= mn;
                                                        vars3 = (chs3 + "/" + zn3);
                                                        TaskText = "Какая из нижеприведенных дробей является иррациональной?";
                                                        flag = true;
                                                    }
                                                }
                                            
                                        }
                                    }
                                        break;
                                    }
                            case 2: 
                                {
                                    zn2 = rnd.Next(1, 10);
                                    if (zn2 % 3 == 0 || zn2 % 7 == 0)
                                    {
                                        chs2 = rnd.Next(1, 21);
                                        if (chs2 % 3 != 0 && chs2 % 7 != 0 && zn2 != 2 && zn2 != 4 && zn2 != 5 && zn2 != 8)
                                        {
                                            mn = rnd.Next(2, 11);
                                            chs2 *= mn;
                                            zn2 *= mn;
                                            
                                                GoodAnswer = var2; vars2 = (chs2 + "/" + zn2);
                                                zn3 = rnd.Next(1, 10);
                                                if (zn3 % 3 == 0 || zn3 % 7 == 0)
                                                {
                                                    mn = rnd.Next(2, 11);
                                                    chs3 = zn3 * mn;
                                                    chs3 *= mn;
                                                    zn3 *= mn;
                                                    NormAnswer.Add(var3); vars3 = (chs3 + "/" + zn3);
                                                    zn1 = rnd.Next(1, 10);
                                                    chs1 = rnd.Next(1, 11);
                                                    if ((zn1 % 3 != 0 && zn1 % 7 != 0) || chs1 % zn1 == 0)
                                                    {
                                                        mn = rnd.Next(1, 21);
                                                        zn1 *= mn;
                                                        chs1 *= mn;
                                                        vars1 = (chs1 + "/" + zn1);
                                                        TaskText = "Какая из нижеприведенных дробей является иррациональной?";
                                                        flag = true;
                                                    }
                                                }
                                            
                                        }
                                    }

                                    break; 
                                }
                            case 3: 
                                {
                                    zn3 = rnd.Next(1, 10);
                                    if (zn3 % 3 == 0 || zn3 % 7 == 0)
                                    {
                                        chs3 = rnd.Next(1, 21);
                                        if (chs3 % 3 != 0 && chs3 % 7 != 0 && zn3 != 2 && zn3 != 4 && zn3 != 5 && zn3 != 8)
                                        {
                                            mn = rnd.Next(2, 11);
                                            chs3 *= mn;
                                            zn3 *= mn;
                                            
                                                GoodAnswer = var3; vars3 = (chs3 + "/" + zn3);
                                                zn1 = rnd.Next(1, 10);
                                                if (zn1 % 3 == 0 || zn1 % 7 == 0)
                                                {
                                                    mn = rnd.Next(2, 11);
                                                    chs1 = zn1 * mn;
                                                    chs1 *= mn;
                                                    zn1 *= mn;
                                                    NormAnswer.Add(var1); vars1 = (chs1 + "/" + zn1);
                                                    zn2 = rnd.Next(1, 10);
                                                    chs2 = rnd.Next(1, 11);
                                                    if ((zn2 % 3 != 0 && zn2 % 7 != 0) || chs2 % zn2 == 0)
                                                    {
                                                        mn = rnd.Next(1, 21);
                                                        zn2 *= mn;
                                                        chs2 *= mn;
                                                        vars2 = (chs2 + "/" + zn2);
                                                        TaskText = "Какая из нижеприведенных дробей является иррациональной?";
                                                        flag = true;
                                                    }
                                                }
                                            
                                        }
                                    }
                                    break; 
                                }
                        }
                        }
                        while (flag == false);
                        break;
                    }
                case 3:
                    {
                        typeTP = true;
                        NormAnswer.Clear();
                        int speed, time, length, time1, time2, time3, length1, length2, length3;
                        mintime = 120; maxtime = 240;
                        do
                        {
                            flag = false;
                            speed = rnd.Next(10, 41);
                            time1 = rnd.Next(2, 5);
                            time2 = rnd.Next(2, 5);
                            time3 = rnd.Next(2, 5);
                            time = time1 + time2 + time3;
                            length1 = speed * time1;
                            length2 = speed * time2;
                            length3 = speed * time3;
                            length = speed * time;
                            GoodAnswer = length2;
                            NormAnswer.Add(length3);
                            NormAnswer.Add(time2);
                            TaskText = String.Format("Автобус двигается из одного города в другой, по пути " +
                            "проезжая две остановки. Известно, что расстояние между городами {0} км, а общее время " +
                            "поездки составило {1} часов. Найдите расстояние между первой и второй остановкой, если " +
                            "между началом пути и первой остановкой расстояние {2} км, а время поездки от второй " +
                            "остановки до конечного города составило {3} часов. Учитывайте, что автобус проехал мимо " +
                            "две остановки, не задерживаясь ни на одной из них.", length, time, length1, time3);
                            flag = true;
                            
                        }
                        while (flag == false);
                        break;
                    }
                case 4:
                    {
                        typeTP = false;
                        NormAnswer.Clear();
                        mintime = 30; maxtime = 60;
                        
                        do
                        {
                            flag = false;
                            rndint = rnd.Next(1, 4);
                            switch(rndint)
                            {
                                case 1:
                                    {
                                        TaskText = "Какая функция из нижеперечисленных имеет график гиперболы";

                                        rndint = rnd.Next(1, 4);
                                        switch (rndint)
                                        {
                                            case 1:
                                                {
                                                    rndint = rnd.Next(1, 11);
                                                    GoodAnswer = var1; vars1 = (rndint + "/x");
                                                    do
                                                    {
                                                        rndint = rnd.Next(1, 4);
                                                    } while (rndint != 1);
                                                    {
                                                        if (rndint == var2)
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var2); vars2 = String.Format("({0}*(x+x))/x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars3 = String.Format("x*{0}x", rndint);
                                                            
                                                        }
                                                        else
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var3); vars3 = String.Format("({0}*(x+x))/x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars2 = String.Format("x*{0}x", rndint);
                                                            
                                                        }
                                                    }
                                                    flag = true;
                                                    break;
                                                    
                                                }
                                            case 2:
                                                {
                                                    rndint = rnd.Next(1, 11);
                                                    GoodAnswer = var2; vars2 = (rndint + "/x");
                                                    rndint = rnd.Next(1, 4);
                                                    do
                                                    {
                                                        rndint = rnd.Next(1, 4);
                                                    } while (rndint != 2);
                                                    {
                                                        if (rndint == var1)
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var1); vars1 = String.Format("({0}*(x+x))/x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars3 = String.Format("x*{0}x", rndint);
                                                        }
                                                        else
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var3); vars3 = String.Format("({0}*(x+x))/x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars1 = String.Format("x*{0}x", rndint);
                                                        }
                                                    }
                                                    flag = true;
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    rndint = rnd.Next(1, 11);
                                                    GoodAnswer = var3; vars3 = (rndint + "/x");
                                                    rndint = rnd.Next(1, 4);
                                                    do
                                                    {
                                                        rndint = rnd.Next(1, 4);
                                                    } while (rndint != 3);
                                                    {
                                                        if (rndint == var2)
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var2); vars2 = String.Format("({0}*(x+x))/x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars1 = String.Format("x*{0}x", rndint);
                                                        }
                                                        else
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var1); vars1 = String.Format("({0}*(x+x))/x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars2 = String.Format("x*{0}x", rndint);
                                                        }
                                                    }
                                                    flag = true;
                                                    break;
                                                }
                                        }
                                        break; 
                                    }
                                case 2:
                                    {
                                        TaskText = "Какая функция из нижеперечисленных имеет график параболлы";
                                        rndint = rnd.Next(1, 4);
                                        switch (rndint)
                                        {
                                            case 1:
                                                {
                                                    rndint = rnd.Next(1, 11);
                                                    GoodAnswer = var1; vars1 = String.Format("x*({0}+x)", rndint);
                                                    do
                                                    {
                                                        rndint = rnd.Next(1, 4);
                                                    } while (rndint != 1);
                                                    {
                                                        if (rndint == var2)
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var2); vars2 = String.Format("x+({0}*x)", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars3 = String.Format("x/{0}", rndint);

                                                        }
                                                        else
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var3); vars3 = String.Format("x+({0}*x)", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars2 = String.Format("x/{0}", rndint);

                                                        }
                                                    }
                                                    flag = true;
                                                    break;

                                                }
                                            case 2:
                                                {
                                                    rndint = rnd.Next(1, 11);
                                                    GoodAnswer = var2; vars2 = String.Format("x*({0}+x)", rndint);
                                                    do
                                                    {
                                                        rndint = rnd.Next(1, 4);
                                                    } while (rndint != 2);
                                                    {
                                                        if (rndint == var1)
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var1); vars1 = String.Format("x+({0}*x)", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars3 = String.Format("x/{0}", rndint);
                                                        }
                                                        else
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var3); vars3 = String.Format("x+({0}*x)", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars1 = String.Format("x/{0}", rndint);
                                                        }
                                                    }
                                                    flag = true;
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    rndint = rnd.Next(1, 11);
                                                    GoodAnswer = var3; vars3 = String.Format("x*({0}+x)", rndint);
                                                    do
                                                    {
                                                        rndint = rnd.Next(1, 4);
                                                    } while (rndint != 3);
                                                    {
                                                        if (rndint == var2)
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var2); vars2 = String.Format("x+({0}*x)", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars1 = String.Format("x/{0}", rndint);
                                                        }
                                                        else
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var1); vars1 = String.Format("x+({0}*x)", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars2 = String.Format("x/{0}", rndint);
                                                        }
                                                    }
                                                    flag = true;
                                                    break;
                                                }
                                        }       break;
                                    }
                                case 3:
                                    {
                                        TaskText = "Какая функция из нижеперечисленных имеет график кубический";
                                        rndint = rnd.Next(1, 4);
                                        switch (rndint)
                                        {
                                            case 1:
                                                {
                                                    rndint = rnd.Next(1, 11);
                                                    GoodAnswer = var1; vars1 = String.Format("{0}x * ({1} + {2} + x) * x", rndint, rndint + 3, rndint * 2);
                                                    do
                                                    {
                                                        rndint = rnd.Next(1, 4);
                                                    } while (rndint != 1);
                                                    {
                                                        if (rndint == var2)
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var2); vars2 = String.Format("(x*x*x)/{0}x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars3 = String.Format("(x+{0})*x", rndint);

                                                        }
                                                        else
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var3); vars3 = String.Format("(x*x*x)/{0}x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars2 = String.Format("(x+{0})*x", rndint);

                                                        }
                                                    }
                                                    flag = true;
                                                    break;

                                                }
                                            case 2:
                                                {
                                                    rndint = rnd.Next(1, 11);
                                                    GoodAnswer = var2; vars2 = String.Format("{0}x * ({1} + {2} + x) * x", rndint, rndint + 3, rndint * 2);
                                                    do
                                                    {
                                                        rndint = rnd.Next(1, 4);
                                                    } while (rndint != 2);
                                                    {
                                                        if (rndint == var1)
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var1); vars1 = String.Format("(x*x*x)/{0}x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars3 = String.Format("(x+{0})*x", rndint);
                                                        }
                                                        else
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var3); vars3 = String.Format("(x*x*x)/{0}x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars1 = String.Format("(x+{0})*x", rndint);
                                                        }
                                                    }
                                                    flag = true;
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    rndint = rnd.Next(1, 11);
                                                    GoodAnswer = var3; vars3 = String.Format("{0}x * ({1} + {2} + x) * x", rndint, rndint + 3, rndint * 2);
                                                    do
                                                    {
                                                        rndint = rnd.Next(1, 4);
                                                    } while (rndint != 3);
                                                    {
                                                        if (rndint == var2)
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var2); vars2 = String.Format("(x*x*x)/{0}x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars1 = String.Format("(x+{0})*x", rndint);
                                                        }
                                                        else
                                                        {
                                                            rndint = rnd.Next(1, 11);
                                                            NormAnswer.Add(var1); vars1 = String.Format("(x*x*x)/{0}x", rndint);
                                                            rndint = rnd.Next(1, 11);
                                                            vars2 = String.Format("(x+{0})*x", rndint);
                                                        }
                                                    }
                                                    flag = true;
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                            }
                        } while (flag == false);
                            break;
                    }
                case 5:
                    {
                        typeTP = true;
                        NormAnswer.Clear();
                        int x, coff1, coff2, a1, a2, x1, x2;
                        mintime = 120; maxtime = 180;
                        do
                        {
                            flag = false;
                            x = rnd.Next(1, 11);
                            coff1 = rnd.Next(1, 6);
                            a1 = x * rnd.Next(1, 4);
                            x1 = coff1 * x + a1;
                            coff2 = rnd.Next(5, 11);
                            a2 = coff2 * x - x1;
                            x2 = coff2 * x * a2;
                            if (x2 > x1)
                            {
                                GoodAnswer = x;
                                NormAnswer.Add((a2 + a1) / (coff2 + coff1));
                                NormAnswer.Add((a2 - a1) / (coff2 + coff1));
                                NormAnswer.Add((a2 - a1) / (coff2 - coff1));
                                TaskText = String.Format("Решите уравнение: {0}x + {1} = {2}x - {3}",
                                coff1, a1, coff2, a2);
                                flag = true;
                            }
                        } while (flag == false);
                            break;
                    }
                case 6:
                    {
                        typeTP = false;
                        NormAnswer.Clear();
                        string gs = "", ns = "", bs = "";
                        const string
                        gs1 = "У ромба все стороны равны",
                        gs2 = "В равностороннем треугольнике площадь равна произведению половины любой стороны на её высоту",
                        gs3 = "В прямоугольном треугольнике гипотенуза меньше суммы его катетов",
                        ns1 = "У ромба все диагонали равны",
                        ns2 = "В равнобедренном треугольнике площадь равна произведению половины любой стороны на её высоту",
                        ns3 = "В прямоугольном треугольнике гипотенуза равна сумме его катетов",
                        bs1 = "У ромба одинаковые углы",
                        bs2 = "В любом треугольнике площадь равна произведению половины любой стороны на её высоту",
                        bs3 = "В прямоугольном треугольнике гипотенуза больше суммы его катетов";
                        mintime = 60; maxtime = 120;
                            do
                            {
                            flag = false;
                            rndint = rnd.Next(1, 4);
                            switch(rndint)
                            {
                                case 1: 
                                    {
                                        gs = gs1;
                                        do
                                        {
                                            rndint = rnd.Next(1, 4);
                                        } while (rndint != 1);
                                            if (rndint == 2)
                                            {
                                                ns = ns2;
                                                bs = bs3;
                                            }
                                        else
                                            {
                                                ns = ns3;
                                                bs = bs2;
                                            }
                                        break; 
                                    }
                                case 2:
                                    {
                                        gs = gs2;
                                        rndint = rnd.Next(1, 4);
                                        do
                                        {
                                            rndint = rnd.Next(1, 4);
                                        } while (rndint != 2);
                                        if (rndint == 1)
                                            {
                                                ns = ns1;
                                                bs = bs3;
                                            }
                                            else
                                            {
                                                ns = ns3;
                                                bs = bs1;
                                            }
                                        break;
                                    }
                                case 3:
                                    {
                                        gs = gs3;
                                        do
                                        {
                                            rndint = rnd.Next(1, 4);
                                        } while (rndint != 3);
                                        if (rndint == 1)
                                            {
                                                ns = ns1;
                                                bs = bs2;
                                            }
                                            else
                                            {
                                                ns = ns2;
                                                bs = bs1;
                                            }
                                        break;
                                    }
                            }

                            rndint = rnd.Next(1, 4);
                            switch (rndint)
                            {
                                case 1:
                                    {
                                        GoodAnswer = var1; vars1 = "1";
                                        rndint = rnd.Next(1, 4);
                                        if (rndint != 1)
                                            if (rndint == 2)
                                            {
                                                NormAnswer.Add(var2); vars2 = "2";
                                                vars3 = "3";
                                                TaskText = String.Format("Среди указанных ниже утверждений - выберите верное: 1) {0} 2) {1} 3) {2}", gs, ns, bs);
                                                flag = true;
                                            }
                                            else
                                            {
                                                NormAnswer.Add(var3); vars3 = "3";
                                                vars2 = "2";
                                                TaskText = String.Format("Среди указанных ниже утверждений - выберите верное: 1) {0} 2) {1} 3) {2}", gs, bs, ns);
                                                flag = true;
                                            }
                                        break;
                                    }
                                case 2:
                                    {
                                        GoodAnswer = var2; vars2 = "2";
                                        rndint = rnd.Next(1, 4);
                                        if (rndint != 2)
                                            if (rndint == 1)
                                            {
                                                NormAnswer.Add(var1); vars1 = "1";
                                                vars3 = "3";
                                                TaskText = String.Format("Среди указанных ниже утверждений - выберите верное: 1) {0} 2) {1} 3) {2}", ns, gs, bs);
                                                flag = true;
                                            }
                                            else
                                            {
                                                NormAnswer.Add(var3); vars3 = "3";
                                                vars1 = "1";
                                                TaskText = String.Format("Среди указанных ниже утверждений - выберите верное: 1) {0} 2) {1} 3) {2}", bs, gs, ns);
                                                flag = true;
                                            }
                                        break;
                                    }
                                case 3:
                                    {
                                        GoodAnswer = var3; vars3 = "3";
                                        rndint = rnd.Next(1, 4);
                                        if (rndint != 3)
                                            if (rndint == 1)
                                            {
                                                NormAnswer.Add(var1); vars1 = "1";
                                                vars2 = "2";
                                                TaskText = String.Format("Среди указанных ниже утверждений - выберите верное: 1) {0} 2) {1} 3) {2}", ns, bs, gs);
                                                flag = true;
                                            }
                                            else
                                            {
                                                NormAnswer.Add(var2); vars2 = "2";
                                                vars1 = "1";
                                                TaskText = String.Format("Среди указанных ниже утверждений - выберите верное: 1) {0} 2) {1} 3) {2}", bs, ns, gs);
                                                flag = true;
                                            }
                                        break;
                                    }
                            }
                        } while (flag == false);
                                break;
                    }
                case 7:
                    {
                        typeTP = true;
                        NormAnswer.Clear();
                        double r, P, S; double pi = 3.14;
                        mintime = 120; maxtime = 180;
                        do
                        {
                            flag = false;
                            
                            r = rnd.Next(2, 11);
                            P = pi * 2 * r;
                            S = pi * r * r;
                            rndint = rnd.Next(1, 3);
                            if (rndint == 1)
                            {
                                GoodAnswer = P;
                                NormAnswer.Add(P / 2);
                                NormAnswer.Add(P * 2);
                                TaskText = String.Format("Найдите периметр окружности, если её площадь равна {0}." +
                                    "π считать как 3.14. Ответ с дробью писать через запятую.", S);
                                flag = true;
                            }
                            else
                            {
                                GoodAnswer = S;
                                NormAnswer.Add(S / r);
                                NormAnswer.Add(S * r);
                                TaskText = String.Format("Найдите площадь окружности, если её периметр равен {0}." +
                                    "π считать как 3.14. Ответ с дробью писать через запятую.", P);
                                flag = true;
                            }
                        } while (flag == false);
                            break;
                    }
                case 8:
                    {
                        typeTP = false;
                        NormAnswer.Clear();
                        
                        mintime = 30; maxtime = 60;
                        do
                        {
                            flag = false;
                            string sg = "π * r * r", sn = "π * D * D", sb = "4 * π * r", pg = "π * D", pn = "π * r", pb = "r * D";
                            rndint = rnd.Next(1, 3);
                            if (rndint == 1)
                            {
                                TaskText = "Из ниже перечисленных вариантов выберите формулу расчёта площади круга";
                                rndint = rnd.Next(1, 4);
                                switch (rndint)
                                {
                                    case 1:
                                        {
                                            GoodAnswer = var1; vars1 = sg;
                                            rndint = rnd.Next(1, 4);
                                            do
                                            {
                                                rndint = rnd.Next(1, 4);
                                            } while (rndint != 1);
                                            if (rndint == 2)
                                                {
                                                    NormAnswer.Add(var2); vars2 = sn;
                                                    vars3 = sb;
                                                   
                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var3); vars3 = sn;
                                                    vars2 = sb;
                                                    
                                                    flag = true;
                                                }
                                            break;
                                        }
                                    case 2:
                                        {
                                            GoodAnswer = var2; vars2 = sg;
                                            rndint = rnd.Next(1, 4);
                                            do
                                            {
                                                rndint = rnd.Next(1, 4);
                                            } while (rndint != 2);
                                            if (rndint == 1)
                                                {
                                                    NormAnswer.Add(var1); vars1 = sn;
                                                    vars3 = sb;
                                                    
                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var3); vars3 = sn;
                                                    vars1 = sb;
                                                    
                                                    flag = true;
                                                }
                                            break;
                                        }
                                    case 3:
                                        {
                                            GoodAnswer = var3; vars3 = sg;
                                            do
                                            {
                                                rndint = rnd.Next(1, 4);
                                            } while (rndint != 3);
                                            if (rndint == 1)
                                                {
                                                    NormAnswer.Add(var1); vars1 = sn;
                                                    vars2 = sb;
                                                    
                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var2); vars2 = sn;
                                                    vars1 = sb;
                                                    
                                                    flag = true;
                                                }
                                            break;
                                        }
                                        
                                }
                            }
                            else
                            {
                                TaskText = "Из ниже перечисленных вариантов выберите формулу расчёта периметра круга";
                                rndint = rnd.Next(1, 4);
                                switch (rndint)
                                {
                                    case 1:
                                        {
                                            GoodAnswer = var1; vars1 = pg;
                                            rndint = rnd.Next(1, 4);
                                            if (rndint != 1)
                                                if (rndint == 2)
                                                {
                                                    NormAnswer.Add(var2); vars2 = pn;
                                                    vars3 = pb;

                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var3); vars3 = pn;
                                                    vars2 = pb;

                                                    flag = true;
                                                }
                                            break;
                                        }
                                    case 2:
                                        {
                                            GoodAnswer = var2; vars2 = pg;
                                            rndint = rnd.Next(1, 4);
                                            if (rndint != 2)
                                                if (rndint == 1)
                                                {
                                                    NormAnswer.Add(var1); vars1 = pn;
                                                    vars3 = pb;

                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var3); vars3 = pn;
                                                    vars1 = pb;

                                                    flag = true;
                                                }
                                            break;
                                        }
                                    case 3:
                                        {
                                            GoodAnswer = var3; vars3 = pg;
                                            rndint = rnd.Next(1, 4);
                                            if (rndint != 3)
                                                if (rndint == 1)
                                                {
                                                    NormAnswer.Add(var1); vars1 = pn;
                                                    vars2 = pb;

                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var2); vars2 = pn;
                                                    vars1 = pb;

                                                    flag = true;
                                                }
                                            break;
                                        }

                                }
                            }
                        } while (flag == false);
                            break;
                    }
                case 9:
                    {
                        typeTP = true;
                        NormAnswer.Clear();
                        double str, polstr, vis, square;
                        mintime = 120; maxtime = 180;
                        do
                        {
                            flag = false;
                            str = rnd.Next(10, 21);
                            polstr = str / 2;
                            vis = Math.Sqrt(Math.Pow(str, 2) - Math.Pow(polstr, 2));
                            square = (polstr * vis) / Math.Sqrt(3);
                            GoodAnswer = square;
                            NormAnswer.Add(square * 2);
                            NormAnswer.Add(square / 2);
                            TaskText = String.Format("Найдите площадь в равностороннем треугольнике со стороной {0}, деленную на √3", str);
                            flag = true;
                        } while (flag == false);
                            break;
                    }
                case 10:
                    {
                        typeTP = false;
                        NormAnswer.Clear();

                        mintime = 90; maxtime = 120;
                        do
                        {
                            flag = false;
                            string sg  = "b - a < 0", sn = "a/b > 1", sb = "b - a > 1", pg = "y - x -z < 0", pn = "-y < (-x)-z", pb = "y - z > x";
                            rndint = rnd.Next(1, 3);
                            if (rndint == 1)
                            {
                                TaskText = "Имеется неравенство a>b. Из ниже перечисленных вариантов выберите неравенство, которое следует из первого.";
                                rndint = rnd.Next(1, 4);
                                switch (rndint)
                                {
                                    case 1:
                                        {
                                            GoodAnswer = var1; vars1 = sg;
                                            rndint = rnd.Next(1, 4);
                                            if (rndint != 1)
                                                if (rndint == 2)
                                                {
                                                    NormAnswer.Add(var2); vars2 = sn;
                                                    vars3 = sb;

                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var3); vars3 = sn;
                                                    vars2 = sb;

                                                    flag = true;
                                                }
                                            break;
                                        }
                                    case 2:
                                        {
                                            GoodAnswer = var2; vars2 = sg;
                                            rndint = rnd.Next(1, 4);
                                            if (rndint != 2)
                                                if (rndint == 1)
                                                {
                                                    NormAnswer.Add(var1); vars1 = sn;
                                                    vars3 = sb;

                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var3); vars3 = sn;
                                                    vars1 = sb;

                                                    flag = true;
                                                }
                                            break;
                                        }
                                    case 3:
                                        {
                                            GoodAnswer = var3; vars3 = sg;
                                            rndint = rnd.Next(1, 4);
                                            if (rndint != 3)
                                                if (rndint == 1)
                                                {
                                                    NormAnswer.Add(var1); vars1 = sn;
                                                    vars2 = sb;

                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var2); vars2 = sn;
                                                    vars1 = sb;

                                                    flag = true;
                                                }
                                            break;
                                        }

                                }
                            }
                            else
                            {
                                TaskText = "Имеется неравенство y - x > z. Из ниже перечисленных вариантов выберите неравенство, которое не следует из первого.";
                                rndint = rnd.Next(1, 4);
                                switch (rndint)
                                {
                                    case 1:
                                        {
                                            GoodAnswer = var1; vars1 = pg;
                                            rndint = rnd.Next(1, 4);
                                            if (rndint != 1)
                                                if (rndint == 2)
                                                {
                                                    NormAnswer.Add(var2); vars2 = pn;
                                                    vars3 = pb;

                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var3); vars3 = pn;
                                                    vars2 = pb;

                                                    flag = true;
                                                }
                                            break;
                                        }
                                    case 2:
                                        {
                                            GoodAnswer = var2; vars2 = pg;
                                            rndint = rnd.Next(1, 4);
                                            if (rndint != 2)
                                                if (rndint == 1)
                                                {
                                                    NormAnswer.Add(var1); vars1 = pn;
                                                    vars3 = pb;

                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var3); vars3 = pn;
                                                    vars1 = pb;

                                                    flag = true;
                                                }
                                            break;
                                        }
                                    case 3:
                                        {
                                            GoodAnswer = var3; vars3 = pg;
                                            rndint = rnd.Next(1, 4);
                                            if (rndint != 3)
                                                if (rndint == 1)
                                                {
                                                    NormAnswer.Add(var1); vars1 = pn;
                                                    vars2 = pb;

                                                    flag = true;
                                                }
                                                else
                                                {
                                                    NormAnswer.Add(var2); vars2 = pn;
                                                    vars1 = pb;

                                                    flag = true;
                                                }
                                            break;
                                        }

                                }
                            }
                        } while (flag == false);
                        break;
                    }
                case 11:
                    {
                        typeTP = true;
                        NormAnswer.Clear();
                        double sum, part, procent;
                        mintime = 75; maxtime = 150;
                        do
                        {
                            flag = false;
                            sum = rnd.Next(1, 21) * 100;
                            rndint = rnd.Next(1, 6);
                            procent = (double)rndint / 10;
                            part = sum * procent;
                            GoodAnswer = procent;
                            NormAnswer.Add(procent + 0.1);
                            NormAnswer.Add(procent - 0.1);
                            TaskText = String.Format("На заводе было произведено {0} деталей. Из них {1} оказались с браком. " +
                                "Какова вероятность брака. Ответ писать в виде десятичной дроби (через запятую).", sum, part);
                            flag = true;
                        } while (flag == false);
                            break;
                    }
                case 12:
                    {
                        typeTP = true;
                        NormAnswer.Clear();
                        mintime = 180; maxtime = 300;
                        do
                        {
                            flag = false;
                            double procent, answer, custans; int sum, proccount; int ysl1, ysl2, ysl3, ysl4; string proc;
                            procent = rnd.Next(5, 31);
                            ysl1 = (int)procent % 3; ysl2 = (int)procent % 7; ysl3 = (int)procent % 5; ysl4 = (int)procent % 10;
                            if ((ysl1 != 0 && ysl2 != 0) && (ysl3 == 0 || ysl4 == 0))
                            {
                                proc = Convert.ToString(procent);
                                procent /= 100;
                                sum = rnd.Next(1, 51) * 1000;
                                answer = sum;
                                custans = answer;
                                proccount = rnd.Next(2, 5);
                                rndint = rnd.Next(1, 3);
                                if (rndint == 1)
                                {
                                    for (int i = 1; i <= proccount; i++)
                                    {
                                        answer += sum * procent;
                                    }
                                    for (int i = 1; i <= proccount; i++)
                                    {
                                        custans *= (1 + procent);
                                    }
                                    GoodAnswer = answer;
                                    NormAnswer.Add(answer + sum * procent);
                                    NormAnswer.Add(answer - sum * procent);
                                    NormAnswer.Add(custans);
                                    TaskText = String.Format("Некий предприниматель положил на накопительный счёт {0} под процент {1}% на {2} года. " +
                                        "Какая сумма получится в итоге, если проценты начисляются от изначально положенной на счёт суммы?", sum, proc, proccount);
                                    flag = true;
                                }
                                else
                                {
                                    for (int i = 1; i <= proccount; i++)
                                    {
                                        answer *= (1 + procent);
                                    }
                                    for (int i = 1; i <= proccount; i++)
                                    {
                                        custans += sum * procent;
                                    }
                                    GoodAnswer = answer;
                                    NormAnswer.Add(answer / (1 + procent));
                                    NormAnswer.Add(answer / (1 - procent));
                                    NormAnswer.Add(custans);
                                    TaskText = String.Format("Некий предприниматель положил на накопительный счёт {0} под процент {1}% на {2} года. " +
                                        "Какая сумма получится в итоге, если проценты начисляются от имеющейся на счёте суммы? (Дробный ответ писать через запятую)", sum, proc, proccount);
                                    flag = true;
                                }
                            }
                        }
                        while (flag == false);
                        break;
                    }
                default: break;
            }
        }

    }

}
