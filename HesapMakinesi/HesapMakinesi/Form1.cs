namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public int girilenSayi = 0;
        public bool clearLabel;
        public int firstNumber;
        public char opr;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 1;
            label.Text = label.Text + girilenDeger.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 2;
            label.Text = label.Text + girilenDeger.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 3;
            label.Text = label.Text + girilenDeger.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 4;
            label.Text = label.Text + girilenDeger.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 5;
            label.Text = label.Text + girilenDeger.ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 6;
            label.Text = label.Text + girilenDeger.ToString();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 7;
            label.Text = label.Text + girilenDeger.ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 8;
            label.Text = label.Text + girilenDeger.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 9;
            label.Text = label.Text + girilenDeger.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label.Text = girilenSayi.ToString();
        }

        private void button_sifir_Click(object sender, EventArgs e)
        {
            if (clearLabel == true)
            {
                label.Text = "";
                clearLabel = false;
            }
            if (label.Text == "0") label.Text = "";
            int girilenDeger = 0;
            label.Text = label.Text + girilenDeger.ToString();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button_arti_Click(object sender, EventArgs e)
        {
            opr = '+';
            clearLabel = true;
            firstNumber = Int32.Parse(label.Text);
        }

        private void button_eksi_Click(object sender, EventArgs e)
        {
            opr = '-';
            clearLabel = true;
            firstNumber = Int32.Parse(label.Text);
        }

        private void button_carpi_Click(object sender, EventArgs e)
        {
            opr = '*';
            clearLabel = true;
            firstNumber = Int32.Parse(label.Text);
        }

        private void button_bolme_Click(object sender, EventArgs e)
        {
            opr = '/';
            clearLabel = true;
            firstNumber = Int32.Parse(label.Text);
        }


        private void button_sonuc_Click(object sender, EventArgs e)
        {
            int secondNumber = Int32.Parse(label.Text);
            int sonuc;
            switch (opr)
            {
                case '+':
                    sonuc = firstNumber + secondNumber;
                    break;
                case '-':
                    sonuc = firstNumber - secondNumber;
                    break;
                case '*':
                    sonuc = firstNumber * secondNumber;
                    break;
                case '/':
                    sonuc = firstNumber / secondNumber;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            label.Text = sonuc.ToString();
        }
    }
}