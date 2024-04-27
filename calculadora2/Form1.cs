using calculadora2.calc;
using calculadora2.Calc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using TextBox = System.Windows.Forms.TextBox;

namespace calculadora2
{
    public partial class Form1 : Form
    {   public TextBox textBoxTestes {  get; set; }
        public string Resultado { get; set; }
        public string PegandoSoma { get; set; }
        public Form1()
        {
            InitializeComponent();

            //if (String.IsNullOrWhiteSpace(txtResultado.Text))
            //{
            //    txtResultado.Text = "";

            //    return;  // isso faz com que você saia do método e não execute os próximos processamentos
            //}

            //this.lblResultado.Text = "1001010";


            
            textBoxTestes = txtResultado;
            
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeComponent();
            textBoxTestes.Focus();
            foreach (Control control in Controls)
            {
                // Verifica se o controle é um botão
                if (control is System.Windows.Forms.Button)
                {
                    // Faz alguma ação com o botão, por exemplo, selecioná-lo
                    System.Windows.Forms.Button button = (System.Windows.Forms.Button)control;

                    button.BackColor = ColorTranslator.FromHtml("#6c757d");
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    //button.Location = new System.Drawing.Point((this.ClientSize.Width - button.Size.Width) / 2, (this.ClientSize.Height - button.Size.Height) / 2);


                    // seleciona o botão
                    // Ou faça qualquer outra coisa com o botão...
                }
            }

            



        }
        private void lblResultado_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btnEntrarSairLeave(object sender, EventArgs e)
        {
            

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            
            textBoxTestes.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            PegandoSoma = textBoxTestes.Text;
            
            Operar operar = new Operar();
            textBoxTestes.Text = operar.Calcular(PegandoSoma).ToString();
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string aux = textBoxTestes.Text;
            if (aux.Length >= 1)
            {
                aux = aux.Remove(aux.Length - 1);
                textBoxTestes.Text = aux;
            }
            
            
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "+";
        }

        private void btnSubitrair_Click(object sender, EventArgs e)
        {
            if (textBoxTestes.Text.Length >= 0)
            {
                textBoxTestes.Text += "-";
            }
            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "/";
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text = "";
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            textBoxTestes.Text += "%";
        }
    }
}
