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
    public partial class ResultForm : Form
    {
        string result;
        public ResultForm(string text)
        {
            InitializeComponent();
            result = text;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            label1.Text = result;
        }
    }
}
