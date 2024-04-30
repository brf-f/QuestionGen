using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_Gen_VS
{
    class Question
    {
        String subject = "Computer Science";
        String question = "Question";
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Question question = new Question();
            Subject.Text = question.subject;
        }

        private void subject_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void question_Click(object sender, EventArgs e)
        {

        }
    }
}
