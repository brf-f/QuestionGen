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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Question current_question = new Question();
            Subject.Text = current_question.subject;
        }

        private void subject_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    class Question
    {
        private static Random rnd = new Random();
        private static string[,] QuestionBank =
        {
        {"Physics", "question1"},
        {"Computer Science", "question2"},
        {"Maths", "question3"},
        {"Geo", "question4"}
    };

        public string subject;
        public string question;

        public Question()
        {
            int num = rnd.Next(0, 4);
            subject = QuestionBank[num, 0];
            question = QuestionBank[num, 1];
        }
    }

}