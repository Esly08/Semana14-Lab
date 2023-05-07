namespace _1308723_AhorcadoEslyAjsivinac
{
    public partial class Form1 : Form
    {
        string _palabraBase = "COPA";
        int _letra;
        int _malas;
        int _buenas;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int _CantLenlaP = 0;
                if (textBox2.Text == "")
                {
                    textBox2.Text = textBox1.Text;
                }
                else
                {
                    textBox2.Text = textBox2.Text + " , " + textBox1;
                }

                do
                {
                    if (_CantLenlaP == 0)
                    {
                        _letra = _palabraBase.IndexOf(textBox1.Text);
                    }
                    else
                    {
                        _letra = _palabraBase.IndexOf(textBox1.Text, _letra + 1);
                    }

                    //muestra = mostrarletra(_letra);
                    if (_buenas == _palabraBase.Length)
                    {
                        MessageBox.Show("Ganaste! FELICIDADES");
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Sigue intentando!");
                    }
                    if (muestra)
                    {
                        _CantLenlaP += 1;
                    }
                } while (muestra);
                
                if (_CantLenlaP == 0)
                {
                    _malas += 1;
                    MessageBox.Show("Es incorrecto");
                }
            }
            textBox1.Text = "";
            textBox1.Focus();
        }

        public bool mostrarletra(int _letra)
        {
            bool resultado = true;
            _buenas += 1;

            switch (_letra)
            {
                case 0:
                    label1.Visible = true;
                    break;
                case 1:
                    label2.Visible = true;
                    break;
                case 2:
                    label3.Visible = true;
                    break;
                case 3:
                    label4.Visible = true;
                    break;
                default:
                    _buenas -= 1;
                    resultado = false;
                    break;
            }
            return resultado;
        }
    }
}