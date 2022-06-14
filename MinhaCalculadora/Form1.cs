using System;
using System.Linq;
using System.Windows.Forms;


namespace MinhaCalculadora
{
    public partial class frm_principal : Form
    {
        //----------------------Definindo as variáveis.------------------------------------
        public double valor_primeiro = 0, valor_segundo = 0, ativador = 1;
        public char operacao, ultimaoperacao = '€';
        public bool primeiraoperacao = true, limpartela = true, limparbotaoigual = true;
        //--------------------------------------------------------------------------------

        
        frm_Historico frm_HistoricoCompleto = new frm_Historico();//Cria um objeto de "frm_Historico" chamado "frm_HistoricoCompleto".

        public void btn_Click_Operacao(object sender, EventArgs e)
        {
            Button btn_operacao = (Button)sender; //Cria um obejto do tipo Button que recebe as mesmas características do "sender" passado como parametro
            
            if (primeiraoperacao)
            {
                if (tb_visor.Text != "" && operacao != '=' )
                {
                    valor_primeiro = Convert.ToDouble(tb_visor.Text);
                }
                else
                {
                    tb_visor.Text = "0";
                }
                switch (btn_operacao.Name) //Verifica qual o nome do botão "btn_operacao" recebido pelo método
                {
                    case "btn_mais":
                        operacao = '+';
                        break;
                    case "btn_menos":
                        operacao = '-';
                        break;
                    case "btn_mult":
                        operacao = '*';
                        break;
                    case "btn_div":
                        operacao = '/';
                        break;
                    case "btn_raiz":
                        operacao = '√';
                        valor_primeiro = Math.Sqrt(valor_primeiro);
                        break;
                    case "btn_quadrado":
                        operacao = '²';
                        valor_primeiro = Math.Pow(valor_primeiro, 2);
                        break;
                    case "btn_fracao":
                        operacao = '\\';
                        valor_primeiro = 1 / valor_primeiro;
                        break;
                    case "btn_porcentagem":
                        operacao = '%';
                        valor_primeiro /= 100;
                        break;
                }
                tb_historico.Text += Convert.ToString(valor_primeiro);
                tb_visor.Clear();
                ultimaoperacao = operacao;
                primeiraoperacao = false;
                btn_Click_Operacao(sender, e);
            }//Primeira operação. Sempre acontece.
            else
            {
                Verifica_Valorsegundo();
                switch (btn_operacao.Name)
                {
                    case "btn_mais": //Sequência de códigos da soma
                        operacao = '+';
                        tb_historico.Text += operacao.ToString() + tb_visor.Text;
                        tb_visor.Text = Convert.ToString(valor_primeiro + valor_segundo);
                        break;
                    case "btn_menos": //Sequência de códigos da subtração
                        operacao = '-';
                        tb_historico.Text += operacao.ToString() + tb_visor.Text;
                        tb_visor.Text = Convert.ToString(valor_primeiro - valor_segundo);
                        break;
                    case "btn_mult": //Sequência de códigos da multiplicação
                        operacao = '*';
                        tb_historico.Text += operacao.ToString() + tb_visor.Text;
                        tb_visor.Text = Convert.ToString(valor_primeiro * valor_segundo);
                        break;
                    case "btn_div": //Sequência de códigos da divisão
                        operacao = '/';
                        tb_historico.Text += operacao.ToString() + tb_visor.Text;
                        tb_visor.Text = Convert.ToString(valor_primeiro / valor_segundo);
                        break;
                    case "btn_raiz": //Sequência de códigos da raiz
                        operacao = '√';
                        if (ultimaoperacao != '√')
                        {
                            tb_historico.Text += ultimaoperacao.ToString() + operacao.ToString() + tb_visor.Text;
                        }
                        else
                        {
                            tb_historico.Text += operacao.ToString() + tb_visor.Text;
                        }
                        valor_segundo = Math.Sqrt(valor_segundo);
                        tb_visor.Text = Convert.ToString(valor_segundo);
                        break;
                    case "btn_quadrado": //Sequência de códigos para elevar ao quadrado
                        operacao = '²';
                        if(ultimaoperacao != '²')
                        {
                            tb_historico.Text += ultimaoperacao.ToString() + tb_visor.Text + operacao.ToString();
                        }
                        else
                        {
                            tb_historico.Text += tb_visor.Text + operacao.ToString();
                        }
                        valor_segundo = Math.Pow(Convert.ToDouble(tb_visor.Text), 2);
                        tb_visor.Text = Convert.ToString(valor_segundo);
                        break;
                    case "btn_fracao": //Sequência de códigos para colocar em fração
                        operacao = '\\';
                        if(ultimaoperacao != '\\')
                        {
                            tb_historico.Text += ultimaoperacao.ToString() + operacao.ToString() + tb_visor.Text;
                        }
                        else
                        {
                            tb_historico.Text += operacao.ToString() + tb_visor.Text;
                        }
                        valor_segundo = Math.Pow(valor_segundo, -1);
                        tb_visor.Text = Convert.ToString(valor_segundo);
                        break;
                    case "btn_porcentagem": //Sequência de códigos para colocar porcentagem
                        operacao = '%';
                        tb_visor.Text = Convert.ToString(Convert.ToDouble(tb_visor.Text) / 100);
                        break;
                }
                if (ativador == 1)
                {
                    tb_historico.Text = tb_historico.Text.Remove(2);
                    ativador = 0;
                }

                ultimaoperacao = operacao;
                limpartela = true;
            }
        }//Acontece somente depois da primeira operação. Aqui é onde a calculadora funciona repetindo as operações.

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_historico.Clear();
            tb_visor.Clear();
            valor_primeiro = 0;
            valor_segundo = 0;
            primeiraoperacao = true;
            ativador = 1;
        }//Evento do botão limpar.

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if(tb_visor.Text != "")
            {
                tb_visor.Text = tb_visor.Text.Remove(tb_visor.Text.Length - 1);
            }
            else
            {
                tb_visor.Text = "0";
            }
        }//Evento do botão apagar.

        private void btn_historico_Click(object sender, EventArgs e)
        {
            frm_HistoricoCompleto.ShowDialog();
        }//Evento do botão Historico.
        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (tb_visor.Text == "")
            {
                tb_visor.Text = "0";
            }
            else if (primeiraoperacao == false)
            {
                switch (operacao)
                {
                    case '+':
                        valor_segundo += Convert.ToDouble(tb_visor.Text);
                        tb_visor.Text = Convert.ToString(valor_primeiro + valor_segundo);
                        break;
                    case '-':
                        valor_segundo += Convert.ToDouble(tb_visor.Text);
                        tb_visor.Text = Convert.ToString(valor_primeiro - valor_segundo);
                        break;
                    case '*':
                        valor_segundo += Convert.ToDouble(tb_visor.Text);
                        tb_visor.Text = Convert.ToString(valor_primeiro * valor_segundo);
                        break;
                    case '/':
                        valor_segundo += Convert.ToDouble(tb_visor.Text);
                        tb_visor.Text = Convert.ToString(valor_primeiro / valor_segundo);
                        break;
                    case '√':
                        tb_visor.Text = Convert.ToString(valor_primeiro + valor_segundo);
                        break;
                    case '²':
                        tb_visor.Text = Convert.ToString(valor_primeiro + valor_segundo);
                        break;
                    case '\\':
                        tb_visor.Text = Convert.ToString(valor_primeiro + valor_segundo);
                        break;
                }
                tb_historico.Clear();
                frm_HistoricoCompleto.tb_historicocompleto.Text += " = " + tb_visor.Text;
                frm_HistoricoCompleto.tb_historicocompleto.Text += Environment.NewLine;
                valor_segundo = 0;
                limparbotaoigual = true;
                primeiraoperacao = true;
            }
        }//Evento do botão Igual.

        private void btn_maismenos_Click(object sender, EventArgs e)
        {
            int j = 0;
            if(tb_visor.Text[j] != '-')
            {
                tb_visor.Text = "-" + tb_visor.Text;
            }
            else if(tb_visor.Text[j] == '-')
            {
                tb_visor.Text = tb_visor.Text.Substring(1);
            }

        }//Evento do botão MaisMenos.

        private void btn_ce_Click(object sender, EventArgs e)
        {
            tb_visor.Text = "0";
        }//Evento do botão CE.

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            bool temvirgula = false;
            if(tb_visor.Text == "")
            {
                tb_visor.Text = "0";
            }
            for (int i = tb_visor.Text.Length; i > 0; i--)
            {
                if(tb_visor.Text[i - 1] == ',')
                {
                    temvirgula = true;
                    break;
                }
            }
            if (temvirgula == false)
            {   
                tb_visor.Text += ",";
            }
            limpartela = false;

        }//Evento do botão VIRGULA.

        private void ClicouBotao(object sender, EventArgs e)
        {
            Button numeros = (Button)sender;
            if(tb_visor.Text == "0")
            {
                tb_visor.Clear();
            }
            if (limpartela == true && primeiraoperacao == false)
            {
                tb_visor.Clear();
                limpartela = false;
            }
            else if (limparbotaoigual)
            {
                tb_visor.Clear();
                limparbotaoigual = false;
            }
            switch (numeros.Name) 
            {
                case "btn_0":
                    tb_visor.Text += "0";
                    break;
                case "btn_1":
                    tb_visor.Text += "1";
                    break;
                case "btn_2":
                    tb_visor.Text += "2";
                    break;
                case "btn_3":
                    tb_visor.Text += "3";
                    break;
                case "btn_4":
                    tb_visor.Text += "4";
                    break;
                case "btn_5":
                    tb_visor.Text += "5";
                    break;
                case "btn_6":
                    tb_visor.Text += "6";
                    break;
                case "btn_7":
                    tb_visor.Text += "7";
                    break;
                case "btn_8":
                    tb_visor.Text += "8";
                    break;
                case "btn_9":
                    tb_visor.Text += "9";
                    break;
            }

        } //Envia os números para o tb_visor.

        /* ------------------------------------------------------- METODOS ----------------------------------------------*/
        public void Verifica_Valorsegundo()
        {
            if (tb_visor.Text == "")
            {
                tb_visor.Text = "0";
            }
            valor_segundo += Convert.ToDouble(tb_visor.Text);
        }// Método que verifica se o "tb_visor" ta vazio e atribui seu valor a variável "valor_segundo".

        public void GuardaHistorico()
        {
            if (primeiraoperacao)
            {
                frm_HistoricoCompleto.tb_historicocompleto.Text += tb_historico.Text + " " + operacao.ToString();
            }
            else
            {
                frm_HistoricoCompleto.tb_historicocompleto.Text += " " + tb_visor.Text;
            }
        }// Método para enviar para o histórico.
        
        /*---------------------------------------------------------------------------------------------------------------*/

        public frm_principal()
        {
            InitializeComponent();
        }//Método construtor do "frm_principal".
    }
}
