using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Web;

namespace Question_Gen_VS
{
    public partial class Form1 : Form
    {
            private void newQuestion(string chosenSubject)
        {
            Question current_question = new Question(chosenSubject);
            Subject.Text = current_question.subject;
            Question.Text = current_question.question;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Subject.Text = "Subject";
            Console.WriteLine(Subject.Text);
            newQuestion(Subject.Text);
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

        private void reloadImage_Click(object sender, EventArgs e)
        {
            newQuestion(Subject.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Question.Text);
            System.Windows.Forms.MessageBox.Show("Question copied to clipboard");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Create issue
            string encodedTitle = "[Question Issue]";
            string encodedBody = Question.Text;
            string url = $"https://github.com/brf-f/QuestionGen/issues/new?title={encodedTitle}&body={encodedBody}";

            Process.Start(url);
        }
    }

    class Question
    {
        private static Random rnd = new Random();
        private static readonly string[,] QuestionBank =
        {
            //{"Maths", "text"},
        {"Maths", "Getting the absolute value of a complex number"},


            //{"Geo", "text"},
        {"Geo", "2 contrasting case studies for earthquakes"},
        {"Geo", "2 contrasting volcano case studies"},
        {"Geo", "Mass Movement 2 contrasting case studies"},
        {"Geo", "Physical and human factors affecting population distribution at the global scale"},
        {"Geo", "Global patterns and classification of economic development"},
        {"Geo", "Two detailed and cotrasting examples of uneven population distribution"},
        {"Geo", "The consequences of megacity growth for individuals and societies \n[Case study of a contemporary megacity experiencing rapid growth]"},
        {"Geo", "Population change and demographic transition over time, including natural increase, fertility rate, life expectancy, population structure and dependancy ratios\n [Detailed examples of 2 or more contrasting countries]"},
        {"Geo", "The causes & consequences of forced migration and internal displacement\n [Detailed examples of 2 or more forced movements, to include enviromental and political push factors, and consequences for people and places]"},
        {"Geo", "Policies associated with managing population change"},
        {"Geo", "The demographic dividend & ways in which population could be considered a resource when contemplating possible futures\n [One case study of a country benefiting from Demographic Dividend]"},
        {"Geo", "Explain the causes of changes in the global energy balance, and the role of feedback loops"},
        {"Geo", "Impacts of climate change on people and places, including health hazards, migration and ocean transport routes"},
        {"Geo", "Disparities in exposure to climate change risk and vulnerability, including variations in people's location, wealth, social differences (age, gender, education), risk perception\n [Detailed Examples of 2 or more societies with contrasting vulnerability]"},
        {"Geo", "Goverment-led adaptation and mitigation strategies for global climate change"},
        {"Geo", "What is carbon emmission offsetting and trading?"},
        {"Geo", "Explain geo-engineering"},
        {"Geo", "Case study of the response to climate change in one country focusing on the actions of non-govermental stakeholders"},
        {"Geo", "Why could the perspectives and viewpoints differ about the need for, practicality and urgency of action on global climate change"},


            //{"Physics", "text"},
        {"Physics", "Define Lenz's Law"},
        {"Physics", "Defintion of Simple Harmonic Motion"},
        {"Physics", "Definition of Faraday's Law"},
        {"Physics", "Flemming's Left-hand rule"},
        {"Physics", "Right hand grip rule"},
        {"Physics", "Definition of induced e.m.f (in terms of flux )"},
        {"Physics", "How does the period of e.m.f. differ from that of magnetic flux?"},
        {"Physics", "Define Gravitational Force"},
        {"Physics", "Define Graviational Field Strength"},
        {"Physics", "Define Gravitational Potential Energy"},
        {"Physics", "Define Gravitational Potential"},
        {"Physics", "Define Electric Force"},
        {"Physics", "Define Electric Field Strength"},
        {"Physics", "Define Electric Potential Energy"},
        {"Physics", "Define Electric Potential"},
        {"Physics", "What are equipotential surfaces?"},
        {"Physics", "What is the difference between Magnetic Flux and Magnetic Flux Linkage?"},
        {"Physics", "What is flux density?"},


            //{"Comp Sci", "text"},
        {"Comp Sci", "Identify two roles that a computer can perform in a network.  [2]"},
        {"Comp Sci", "(a)   Identify  two reasons why patches may be necessary for an operating system.  [2]\n(b)  Identify two methods that can be used to obtain these patches.  [2]"},
        {"Comp Sci", "Calculate the denary (base 10) equivalent of the hexadecimal number BF.  [2]"},
        {"Comp Sci", "Identify two reasons why fibre optic cable would be preferred over wireless connectivity.  [2]"},
        {"Comp Sci", "Distinguish between a variable and a constant. [2]"},
        {"Comp Sci", "Identify one advantage of using a dedicated operating system on a mobile phone.  [1]"},
        {"Comp Sci", "Identify two characteristics of a dynamic data structure.  [2]"},
        {"Comp Sci", "Sketch a balanced binary tree that would allow the following output when traversed using inorder traversal:Zebra, Tango, Hotel, Foxtrot, Delta, Bravo, Alpha.  [3]"},
        {"Comp Sci", "A school currently has a cabled network but wants to add wireless networking across the whole campus.\n\n(a)  Describe two hardware components the school will need to implement the wireless network.  [4]"},
        {"Comp Sci", "A school currently has a cabled network but wants to add wireless networking across the whole campus.\n\n(b)  Identify two advantages to the students of the new wireless network.  [2]"},
        {"Comp Sci", "There are concerns that unauthorized people could access the data on the wireless network. \n\n(c)  Outline two methods the school could employ to prevent network data from being accessed over their wireless system.  [4]"},
        {"Comp Sci", "The school has decided to implement a virtual private network (VPN) to provide access  to its network.\n\n(d)  Identify two technologies the school would require to provide a VPN.  [2]"},
        {"Comp Sci", "(e)  Explain one benefit to the staff of using a VPN to remotely access the school network.  [3]"},
        {"Comp Sci", "The company’s staff list is now organized in the arrays in alphabetical order.\nA binary search was used to find a specific name in the array.\n\n(c)  Describe the process a binary search would follow to find a record in the surname array.  [4]\n(d)  Outline one benefit of using sub-programmes to implement your algorithms from parts (a) and (b).  [2]"},
        {"Comp Sci", "A business has a range of different computers within the organization, including laptops, desktops and file servers. Wherever possible the organization uses a common operating system on its computers.\n\n(a)  Outline two resource management techniques that are likely to be carried out by the operating system of a desktop computer.  [4]"},
        {"Comp Sci", "(b)  Outline one way the operating system hides the complexity of the hardware from the computer user.  [2]"},
        {"Comp Sci", "Memory requirements and processor speed will vary depending on the tasks required of the computer.\n\n(c)  (i)   Contrast the memory requirements of a laptop computer and a file server.  [2]"},
        {"Comp Sci", "(ii)  Contrast the processor speed requirements of a laptop computer and a file server.  [2]"},
        {"Comp Sci", "The business has decided to implement a computer-based system to switch the room lights on and off automatically. The lights will only be switched on if the level of light is below a specific reading and there are people in the room. The lights will be switched off when the room has been unoccupied for at least five minutes.\n\n(d)  State two types of sensor that are required to control the lighting to ensure it switches on when it is required.  [2]"},
        {"Comp Sci", "The business has decided to implement a computer-based system to switch the room lights on and off automatically. The lights will only be switched on if the level of light is below a specific reading and there are people in the room. The lights will be switched off when the room has been unoccupied for at least five minutes.\n\n(e)  Explain how the system makes use of the data it receives from the sensors to determine when to switch the lights on.  [4]"},
        {"Comp Sci", "The business has decided to implement a computer-based system to switch the room lights on and off automatically. The lights will only be switched on if the level of light is below a specific reading and there are people in the room. The lights will be switched off when the room has been unoccupied for at least five minutes.\n\n(f)  Outline how the system will prevent the lights from being switched off too quickly when it thinks the room is unoccupied.  [2]"},
        {"Comp Sci", "A network is set up with shared printers so that when a user wishes to print, print jobs are sent to a queue until the printer is available.\n\n(a)  Outline why a queue is the appropriate data structure to manage print jobs.  [2]"},
        {"Comp Sci", "(b)  Draw a diagram to show how a print queue may be implemented using a linked list.  [3]"},
        {"Comp Sci", "(c)  Explain why a stack would not be appropriate as a data structure for managing print jobs.  [3]"},
        {"Comp Sci", "(e)  Explain how a stack may be used in the implementation of a recursive function.  [4]"},
        {"Comp Sci", "Human interaction with the computer system includes a range of usability problems.\n\n(a) Define the term usability. [1]"},
        {"Comp Sci", "(b) Identify two methods that could be used to improve the accessibility of a computer system.  [2]"},
        {"Comp Sci", "By making direct reference to the technologies used, explain how a virtual private network (VPN) allows a travelling salesperson to connect securely to their company’s network. [4]"},
        {"Comp Sci", "Construct a truth table for the following Boolean expression. [3]\n\n(A and B) nor C"},
        {"Comp Sci", "A school uses a local area network (LAN) which connects several computers and a printer to a server and allows access to the internet.\n\n(b)  Identify the different clients in this network. [1]"},
        {"Comp Sci", "(c) (i)  Identify one external threat to the security of the school’s computer system. [1] \n\n (ii) State one way to protect the computer system from the threat identified in part (c)(i). [1]"},
        {"Comp Sci", "(a)  Draw an annotated diagram showing how an array can be used to store a stack. [2]"},
        {"Comp Sci", "(b)  Explain how elements in the stack may be reversed using a queue. [4]"},
        {"Comp Sci", "(a) Define the term server. [1]"},
        {"Comp Sci", "A hardware shop supplies a wide variety of bathroom equipment. There are 15 shop assistants who serve customers, 3 office staff who handle the administration, and a manager. A specialized company is asked to design and implement a new computer system for  the shop. \n\n (a) (i)  Identify two different types of users of the system.  [2]  \n (ii)  Explain the role of users in the process of developing the new computer system. [3]"},
        {"Comp Sci", "(b)  Describe why it is useful to produce more than one prototype of the new system.  [2]"},
        {"Comp Sci", "(c) Outline two problems that may occur when transferring data from the old system to the new system. [4]"},
        {"Comp Sci", "The manager of the shop has decided to invest in a computer system which allows customers to make online orders from any place at any time. \n\n (d)  (i)  Explain how two or more customers are able to access the computer system at the same time.  [2]  \n  (ii)  Explain how each customer’s data is secure when two customers access the system at the same time.  [2]"},
        {"Comp Sci", "Outline the function of the:  \n\n  (i)  memory address register [2]"},
        {"Comp Sci", "Outline the function of the:  \n\n  (ii)  memory data register.  [2]"},
        {"Comp Sci", "(d) (i)  Identify two functions of the operating system.  [2]"},
        {"Comp Sci", "(ii)  State where the operating system is held when the computer is turned off.   [1]"},
        {"Comp Sci", "(e)  (i)  Construct a diagram to illustrate the structure of a central processing unit (CPU), clearly showing the flow of data within the CPU. [4]"},
        {"Comp Sci", "(ii)  Identify the part of the CPU which performs decoding.  [1]"},
        {"Comp Sci", "(iii)  Identify the part of the CPU which executes the instruction. [1]"},
        {"Comp Sci", "A control system is used to control sliding doors which automatically open to allow people in and out of a shop. \n\n (a) (i)  Identify one type of sensor in this system. [1]"},
        {"Comp Sci", "(ii) Identify one piece of hardware, other than sensors, that is part of the control system. (Sliding Automated Doors) [1]"},
        {"Comp Sci", "(iii)  With reference to the role of sensors, outline the sequence of steps within the computer control system that will take place when a person approaches the door. (Sliding Automated door) [3]"},
        {"Comp Sci", "(b) (i) Define the term interrupt.   [2] \n (ii)  Describe a situation in this system where an interrupt would occur. (Automated Sliding Doors)   [2]"},
        {"Comp Sci", "(c)  Discuss the contribution of computer control systems in industry where they replace human workers. [6]"},

        {"Comp Sci", "Describe one method of implementation for a new computer system.  [2]" }
    };

        public string subject;
        public string question;

        public Question(string chosenSubject)
        {
            while(true)
            {
                int i = rnd.Next(0, QuestionBank.GetLength(0));
                Console.WriteLine(chosenSubject);
                if ((chosenSubject == "Subject") || (QuestionBank[i, 0] == chosenSubject))
                {
                    subject = QuestionBank[i, 0];
                    question = QuestionBank[i, 1];
                    break;
                }
            }
        }
    }

}