namespace T2___Practicando_con_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "TEXTO CAMBIADO!";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }
    }
}
