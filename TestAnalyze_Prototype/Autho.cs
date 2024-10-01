using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAnalyze_Prototype
{
    
   

    public partial class Autho : Form
    {
        Testing test;



        public Autho()
        {
            InitializeComponent();  
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            bool check = true;
            test = new Testing();
            if (check) { 
                if (SurnameTB.Text.Length > 3 && CheckWord(SurnameTB.Text)) { test.surname = SurnameTB.Text; }
                else { check = false; MessageBox.Show("Введенная фамилия некорректна!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); } 
            }
            if (check)
            {
                if (NameTB.Text.Length > 3 && CheckWord(NameTB.Text)) { test.name = NameTB.Text; }
                else { check = false; MessageBox.Show("Введенное имя некорректно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            if (check) {
                if (DadnameTB.Text.Length > 7 && CheckWord(DadnameTB.Text)) { test.dadname = DadnameTB.Text; }
                else { check = false; MessageBox.Show("Введенное отчество некорректно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); } 
            }
            if (check) { test.age = (Int32)AgeNum.Value; }
            if (check)
            {
                
                this.Hide();
                test.Show();
            }
        }

        private bool CheckWord(string enter)
        {
            string str = enter;
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' ||
                    ch == '7' || ch == '8' || ch == '9' || ch == ' ' || ch == '.' || ch == ',' || ch == '!' ||
                    ch == '?' || ch == '/' || ch == '<' || ch == '>' || ch == '@' || ch == '"' || ch == '#' ||
                    ch == '№' || ch == ';' || ch == '$' || ch == '%' || ch == '^' || ch == ':' || ch == '&' ||
                    ch == '*' || ch == '(' || ch == ')' || ch == '-' || ch == '_' || ch == '+' || ch == '=' ||
                    ch == '|' || ch == '{' || ch == '[' || ch == '}' || ch == ']') { flag = false; break; }
            }
            return flag;
        }

        
    }
}
