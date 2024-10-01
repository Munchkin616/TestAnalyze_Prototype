using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestAnalyze_Prototype
{
    public partial class Testing : Form
    {

        
        public string surname;
        public string name;
        public string dadname;
        public int age;

        public List<int> S_Vi = new List<int>();
        public List<int> S_Ei = new List<int>();
        public List<int> S_Ai = new List<int>();

        int TaskCount = 1;
        int MainTimer = 0;
        int TaskTimer = 0;

        bool fl;

        public DataBank data;
        ResultCoordinator resultCooR;
        TasksTest test;
        ResultForm resform;
        //TasksTest test = new TasksTest();


        public Testing()
        {
            InitializeComponent();
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0} {1} {2} {3} ", surname, name, dadname, age);
            progTimer.Enabled = true;
            label3.Text = "00:00";
            data = new DataBank(surname, name, dadname, age);
            test = new TasksTest();
            test.Tasks(TaskCount);
            label2.Text = test.TaskText;
            groupBox1.Text = "Задание " + TaskCount;
            TestLogic();
        }

        private void TestBut_Click(object sender, EventArgs e)
        {
            if (TaskCount == 11) TestBut.Text = "Завершить";
            fl = true;
            TestResult();
            if (fl == true)
            {
                MainTimer = 0;
                if (TaskCount < test.task_count)
                {
                    TaskCount++;
                    test.Tasks(TaskCount);
                    TestLogic();
                }
                else
                {
                    progTimer.Stop();
                    resultCooR = new ResultCoordinator();
                    resultCooR.CountResult(S_Vi, S_Ei, S_Ai, test.task_count, test.task_count_teo, test.task_count_prac);
                    int temp = resultCooR.ReturnResult();
                    data.SaveRes(resultCooR.ReturSV(), resultCooR.ReturSE(), resultCooR.ReturSA());
                    string savetext = String.Format("Фамилия: {0}, имя: {1}, отчество {2}, возраст: {3} " +
                        "S_V = {4}, S_E = {5}, S_A = {6}. Результат: {7}. Общее время прохожения: {8} мин {9} сек.",
                        data.RetSurname(), data.RetName(), data.RetDadname(), data.RetAge(), data.RetS_V(), data.RetS_E(), data.RetS_A(),
                        data.RetResult(), min, sec);
                    resform = new ResultForm(savetext);

                    StreamWriter SW = new StreamWriter(new FileStream("result.txt", FileMode.Create, FileAccess.Write));
                    SW.Write(savetext);
                    SW.Close();

                    resform.Show();
                    Hide();
                }
            }
            
        }

        private void AnswerCB1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void AnswerCB2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void AnswerCB3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void AnswerCB1_Click(object sender, EventArgs e)
        {
            if (!AnswerCB1.Checked) AnswerCB1.Checked = true;
            else { AnswerCB2.Checked = false; AnswerCB3.Checked = false; }
        }

        private void AnswerCB3_Click(object sender, EventArgs e)
        {
            if (!AnswerCB3.Checked) AnswerCB3.Checked = true;
            else { AnswerCB1.Checked = false; AnswerCB2.Checked = false; }
        }

        private void AnswerCB2_Click(object sender, EventArgs e)
        {
            if (!AnswerCB2.Checked) AnswerCB2.Checked = true;
            else { AnswerCB1.Checked = false; AnswerCB3.Checked = false; }
        }

        int sec = 0; int min = 0;
        private void progTimer_Tick(object sender, EventArgs e)
        {
            
            string left; string right;
            label2.Text = test.TaskText;
            groupBox1.Text = "Задание " + TaskCount;
            MainTimer++;
            if (sec >= 59) { sec = 0; min++; }
            else sec++;

            if (sec < 10) right = ("0" + sec);
            else right = Convert.ToString(sec);
            if (min < 10) left = ("0" + min);
            else left = Convert.ToString(min);

            label3.Text = String.Format("{0}:{1}", left, right);
        }

        private void TestResult()
        {
            bool flag = false;
            
            if (test.typeTP)
            {
                try
                {
                    if (Convert.ToDouble(AnswerTB.Text) == test.GoodAnswer)
                    {
                        S_Ai.Add(1);
                    }
                    else
                    {
                        for (int i = 0; i < test.NormAnswer.Count; i++)
                        {
                            if (!flag && Convert.ToDouble(AnswerTB.Text) == test.NormAnswer[i]) S_Ai.Add(0);
                        }
                        if (!flag) S_Ai.Add(-1);
                        if (MainTimer < test.mintime) S_Vi.Add(1);
                        else if (MainTimer > test.mintime && MainTimer < test.maxtime) S_Vi.Add(0);
                        else if (MainTimer > test.maxtime) S_Vi.Add(-1);
                    }
                    
                }
                catch { fl = false; MessageBox.Show("Вы ввели некорректный ответ! Ответ нужно писать (если нужно) через запятую, без букв и других символов.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else
            {
                if (AnswerCB1.Checked || AnswerCB2.Checked || AnswerCB3.Checked)
                {
                    if (AnswerCB1.Checked)
                    {
                        if (test.GoodAnswer == test.var1) S_Ei.Add(1);
                        else if (test.NormAnswer[0] == test.var1) S_Ei.Add(0);
                        else S_Ei.Add(-1);
                        if (MainTimer < test.mintime) S_Vi.Add(1);
                        else if (MainTimer > test.mintime && MainTimer < test.maxtime) S_Vi.Add(0);
                        else if (MainTimer > test.maxtime) S_Vi.Add(-1);
                    }
                    else if (AnswerCB2.Checked)
                    {
                        if (test.GoodAnswer == test.var2) S_Ei.Add(1);
                        else if (test.NormAnswer[0] == test.var2) S_Ei.Add(0);
                        else S_Ei.Add(-1);

                    }
                    else
                    {
                        if (test.GoodAnswer == test.var3) S_Ei.Add(1);
                        else if (test.NormAnswer[0] == test.var3) S_Ei.Add(0);
                        else S_Ei.Add(-1);
                    }

                    if (MainTimer < test.mintime) S_Vi.Add(1);
                    else if (MainTimer > test.mintime && MainTimer < test.maxtime) S_Vi.Add(0);
                    else if (MainTimer > test.maxtime) S_Vi.Add(-1);

                }
                else { fl = false; MessageBox.Show("Вы не выбрали вариант ответа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
             
        }

        private void TestLogic()
        {
            AnswerTB.Clear();
            AnswerCB1.Checked = false;
            AnswerCB2.Checked = false;
            AnswerCB3.Checked = false;

            if (test.typeTP)
            {
                AnswerCB1.Visible = false;
                AnswerCB2.Visible = false;
                AnswerCB3.Visible = false;
                AnswerTB.Visible = true;
            }
            else
            {

                AnswerCB1.Visible = true;
                AnswerCB1.Text = test.vars1;
                AnswerCB2.Visible = true;
                AnswerCB2.Text = test.vars2;
                AnswerCB3.Visible = true;
                AnswerCB3.Text = test.vars3;
                AnswerTB.Visible = false;
            }
        }
    }
}
