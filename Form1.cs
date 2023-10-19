namespace gif_animado
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

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, C;

            A = int.Parse(valor1.Text);
            B = int.Parse(valor2.Text);
            C = int.Parse(valor3.Text);

            if (A > B)
                if (A > C)
                    if (B > C)
                    {
                        n1.Text = A.ToString();
                        n2.Text = B.ToString();
                        n3.Text = C.ToString();
                    }
                    else
                    {
                        n1.Text = A.ToString();
                        n2.Text = C.ToString();
                        n3.Text = B.ToString();
                    }
                else
                {
                    n1.Text = C.ToString();
                    n2.Text = A.ToString();
                    n3.Text = B.ToString();
                }
            else
            {
                if (B > C)
                {
                    if (A > C)
                    {
                        n1.Text = B.ToString();
                        n2.Text = A.ToString();
                        n3.Text = C.ToString();
                    }
                    else
                    {
                        n1.Text = B.ToString();
                        n2.Text = C.ToString();
                        n3.Text = A.ToString();
                    }
                }
                else
                {
                    n1.Text = C.ToString();
                    n2.Text = B.ToString();
                    n3.Text = A.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor1.Text = " ";
            valor2.Text = " ";
            valor3.Text = " ";
            n1.Text = " ";
            n2.Text = " ";
            n3.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}