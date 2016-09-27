using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneQuestionQuiz
{
    public partial class frmOneQuestionQuiz : Form
    {
        public frmOneQuestionQuiz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Load(object sender, EventArgs e)
        {

        }

        private void rdbCharlie_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Sorry, incorrect :(";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Try Again :(";
        }

        private void rdbSimba_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Correct! :)";
        }

        private void rdbBandit_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Nice try :(";
        }
    }
}
