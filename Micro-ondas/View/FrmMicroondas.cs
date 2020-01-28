using System;
using System.Windows.Forms;

namespace Micro_ondas.View
{
    public partial class FrmMicroondas : Form
    {
        private int clickLimpar = 0;
        private int minuto = 0;
        private int segundo = 0;
        private int X = 0;
        private int Y = 0;
        private string tempo = "";
        public FrmMicroondas()
        {
            InitializeComponent();
        }
        #region Mover Tela
        private void AcrescentarEixoMouse()
        {
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        private void DecrementarEixoMouse()
        {
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
        private void frmMicroondas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            AcrescentarEixoMouse();
        }

        private void frmMicroondas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            DecrementarEixoMouse();
        }
        #endregion
        #region Executar tempo
        private void Timer_Tick(object sender, EventArgs e)
        {
            TxtPotencia.Text = new Controller.Dicionario.DicionarioTempoPotencia().RetornaPontoPorPotencia(int.Parse(txtPotenciaValor.Text));
            --segundo;
            if (minuto > 0)
            {

                if (segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            var respostaTempo = new Controller.Dados.TratarDados().TratarTempo(TxtEntrada.Text, segundo, minuto);
            TxtEntrada.Text = respostaTempo;
            if (respostaTempo == "Aquecido")
            {
                Time.Stop();
                LimparDados();
                TxtPotencia.Text = "Aquecido";
            }
        }
        #endregion
        #region Valores botões
        private void btnUm_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnUm.Name.ToString());
            TxtEntrada.Text = tempo;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnDois.Name.ToString());
            TxtEntrada.Text = tempo;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnTres.Name.ToString());
            TxtEntrada.Text = tempo;
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnQuatro.Name.ToString());
            TxtEntrada.Text = tempo;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnCinco.Name.ToString());
            TxtEntrada.Text = tempo;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnSeis.Name.ToString());
            TxtEntrada.Text = tempo;
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnSete.Name.ToString());
            TxtEntrada.Text = tempo;
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnOito.Name.ToString());
            TxtEntrada.Text = tempo;
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnNove.Name.ToString());
            TxtEntrada.Text = tempo;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            tempo = tempo + new Controller.Dicionario.DicionarioTempoPotencia().ValorBotao(btnZero.Name.ToString());
            TxtEntrada.Text = tempo;
        }
        #endregion
        #region Separar Tempo
        private void SepararTempo()
        {
            string[] tempo = TxtEntrada.Text.Split(':');
            segundo = int.Parse(tempo[1]);
            minuto = int.Parse(tempo[0]);
        }
        private void SepararTempoInicioRapido()
        {
            string[] tempo = new Controller.Dicionario.DicionarioTempoPotencia().InicioRapido("tempo").Split(':');
            segundo = int.Parse(tempo[1]);
            minuto = int.Parse(tempo[0]);
        }
        #endregion
        #region Iniciar e Parar
        private void btnIniciar_Click_1(object sender, EventArgs e)
        {

            if (new Controller.Dados.TratarDados().IndentificaInicioRapido(TxtEntrada.Text) == true)
            {
                SepararTempoInicioRapido();
                txtPotenciaValor.Text = new Controller.Dicionario.DicionarioTempoPotencia().InicioRapido("potencia");
                Time.Start();
                return;
            }
            if (new Controller.Dados.TratarDados().TempoEstaCompleto(TxtEntrada.Text) == false || new Controller.Dados.TratarDados().VerificarSeTempoExiste(TxtEntrada.Text) == false)
            {
                MessageBox.Show("Tempo incorreto por favor tente novamente", "OK");
                LimparDados();
                return;
            }
            if (new Controller.Dados.TratarDados().PotenciaVazia(txtPotenciaValor.Text) == true)
            {
                MessageBox.Show("Por favor indique a pôtencia desejada", "OK");
                return;
            }
            if (new Controller.Dados.TratarDados().TempoMaximoAquecimento(TxtEntrada.Text) == true || new Controller.Dados.TratarDados().TempoMinimoAquecimento(TxtEntrada.Text) == true)
            {
                MessageBox.Show("Tempo maximo de aquecimento é de 02:00 min e o tempo minimo é de 00:01 min", "OK");
                LimparDados();
                return;
            }
            else
            {
                SepararTempo();
                Time.Start();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            clickLimpar = clickLimpar + 1;
            if (clickLimpar >= 2)
                LimparDados();
            Time.Stop();
            tempo = null;
        }
        #endregion
        #region Potência
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            txtPotenciaValor.Text = new Controller.Dados.TratarDados().AumentarPotencia(txtPotenciaValor.Text);
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            txtPotenciaValor.Text = new Controller.Dados.TratarDados().DiminuirPotencia(txtPotenciaValor.Text);
        }
        #endregion
        #region Limpar Dados
        private void LimparDados()
        {
            TxtPotencia.Clear();
            TxtEntrada.Clear();
            tempo = null;
            clickLimpar = 0;
        }
        #endregion
        #region Load
        private void FrmMicroondas_Load(object sender, EventArgs e)
        {
            txtPotenciaValor.ReadOnly = true;
            txtPotenciaValor.Text = "1";
        }
        #endregion
    }
}
