
namespace Micro_ondas.Model.Dados
{
    public class TratarDados
    {
        public string AumentarPotencia(string valor)
        {
            if (valor == "10")
                return "10";
            valor = valor == null || valor == "" ? "0" : valor;
            return (int.Parse(valor) + 1).ToString();
        }
        public string DiminuirPotencia(string valor)
        {
            if (valor == "")
                return "1";
            if (valor == "1")
                return "1";
            valor = valor == null || valor == "" ? "1" : valor;
            return (int.Parse(valor) - 1).ToString();
        }
        public bool VerificarSeTempoExiste(string valor)
        {
            if (valor == "  :")
                valor = "00:00";
            string[] tempo = valor.Split(':');
            if (int.Parse(tempo[0]) > 60)
                return false;
            if (int.Parse(tempo[1]) > 60)
                return false;
            else
                return true;
        }
        public bool IndentificaInicioRapido(string valor)
        {
            if (valor == "  :")
                return true;
            else
                return false;
        }
        public bool TempoEstaCompleto(string valor)
        {
            

            if (valor.Length != 5 && valor != "  :")
                return false;
            else
                return true;
        }
        public bool PotenciaVazia(string valor)
        {
            if (valor == "" || valor == null)
                return true;
            else
                return false;
        }
        public bool TempoMaximoAquecimento(string valor)
        {
            valor = valor.Replace(":", "");
            if (int.Parse(valor) > 0200)
                return true;
            else
                return false;
        }
        public bool TempoMinimoAquecimento(string valor)
        {
            valor = valor.Replace(":", "");
            if (int.Parse(valor) < 0001)
                return true;
            else
                return false;
        }
        public string TratarTempo(string valor, int segundo, int minuto)
        {
            string resposta = "";
 
            if (minuto.ToString().Length == 1)
            {
                resposta = "0" + minuto + ":" + segundo;
            }
            if (segundo.ToString().Length == 1)
            {
                resposta = minuto + ":" + "0" + segundo;
            }
            if (segundo.ToString().Length == 1 && minuto.ToString().Length == 1)
            {
                resposta = "0" + minuto + ":" + "0" + segundo;
            }
            if (segundo.ToString().Length != 1 && minuto.ToString().Length != 1)
            {
                resposta = minuto + ":" + segundo;
            }
            if (minuto == 0 && segundo == 0)
            {
                return "Aquecido";
            }
            else
                return resposta;
        }
    }
}
