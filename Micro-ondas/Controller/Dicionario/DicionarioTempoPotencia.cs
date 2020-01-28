
namespace Micro_ondas.Controller.Dicionario
{
    public class DicionarioTempoPotencia
    {
        public string RetornaPontoPorPotencia(int valor)
        {
            var Dic = new Model.Dicionario.DicionarioMicroondas().potencia;
            return Dic[valor];
        }
        public string InicioRapido(string valor)
        {
            return new Model.Dicionario.DicionarioMicroondas().inicioRapido[valor];
        }
        public string ValorBotao(string valor)
        {
            return new Model.Dicionario.DicionarioMicroondas().valorBotoes[valor];
        }
    }
}
