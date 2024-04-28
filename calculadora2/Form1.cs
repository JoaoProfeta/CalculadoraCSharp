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
    {   public TextBox textBoxModifiers {  get; set; }
        public string Resultado { get; set; }
        public string PegandoSoma { get; set; }
        public Form1()
        {
            InitializeComponent();

            #region caso queira fazer com uma lbl, isso sera necessario :::
    
            //if (String.IsNullOrWhiteSpace(txtResultado.Text))
            //{
            //    txtResultado.Text = "";

            //    return;  // isso faz com que você saia do método e não execute os próximos processamentos
            //}

            //this.lblResultado.Text = "1001010";
            #endregion

            textBoxModifiers = txtResultado;
            textBoxModifiers.Cursor = Cursors.No;
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeComponent();
            textBoxModifiers.Focus();
            
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
                }
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            
            textBoxModifiers.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text += ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            PegandoSoma = textBoxModifiers.Text;
            
            Operar operar = new Operar();
            textBoxModifiers.Text = operar.Calcular(PegandoSoma).ToString();
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string aux = textBoxModifiers.Text;
            if (aux.Length >= 1)
            {
                aux = aux.Remove(aux.Length - 1);
                textBoxModifiers.Text = aux;
            }
            
            
            
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // para não acabar gerando numeros +5, +6, ja são positivos, não precisa do + na frente
            if (textBoxModifiers.Text.Length > 0)
            {
                textBoxModifiers.Text += "+"; 
            }
        }

        private void btnSubitrair_Click(object sender, EventArgs e)
        {
           
                textBoxModifiers.Text += "-";
            
            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //para não existir um *5,*6 na frente da logica
            if (textBoxModifiers.Text.Length > 0)
            { 
                textBoxModifiers.Text += "*";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //para não existir um /5,/6 na frente da logica
            if (textBoxModifiers.Text.Length > 0)
            {
                textBoxModifiers.Text += "/"; 
            }
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            textBoxModifiers.Text = "";
        }

        private void btnIgual_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {

            //para aceitar somente numeros e simbolos
            if (!char.IsDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Se não for um número, um símbolo ou um caractere de controle, ignora a entrada
                e.Handled = true;
            }



            //para exibir o resultado do calculo ao apertar enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                PegandoSoma = textBoxModifiers.Text;

                Operar operar = new Operar();
                textBoxModifiers.Text = operar.Calcular(PegandoSoma).ToString();

            };
            /*
            if(e.KeyChar == (char)Keys.Back)
            {
                string aux = textBoxTestes.Text;
                if (aux.Length >= 1)
                {
                    aux = aux.Remove(aux.Length - 1);
                    textBoxTestes.Text = aux;
                }
            };
            */


            // Armazena a posição atual do cursor
            int cursorPosition = textBoxModifiers.SelectionStart;
            //para apagar o ultimo caractere, e deixar o cursor atras do ultimo caractere
            if (e.KeyChar == (char)Keys.Back)
            {
                // Verifica se há texto no textBox
                if (textBoxModifiers.TextLength > 0 && cursorPosition > 0)
                {
                    //Remove o caractere anterior ao cursor
                    textBoxModifiers.Text = textBoxModifiers.Text.Remove(cursorPosition - 1, 1);

                    // Move o cursor para a posição correta
                    textBoxModifiers.SelectionStart = cursorPosition - 1;

                    // Indica que o evento foi tratado, evitando que o caractere seja inserido
                    e.Handled = true;
                }
            }
            

        }

        private void txtResultado_Click(object sender, EventArgs e)
        {
            
            //ao clicar no txt box, o foco vai apra o fim da string

          
            var positionCursor = textBoxModifiers.SelectionStart;
            if (positionCursor >= 0)
            {
                textBoxModifiers.SelectionStart = textBoxModifiers.Text.Length;
            }
        }
    }
}
