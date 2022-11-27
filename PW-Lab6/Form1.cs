using static System.Net.Mime.MediaTypeNames;

namespace PW_Lab6
{
    public partial class Form1 : Form
    {
        public static Form1 form1Instance;
        public Form1()
        {
            InitializeComponent();
            form1Instance = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}