
namespace Micro_ondas.Controller.Dados
{
    public class TratarDados
    {
        public string AumentarPotencia(string valor)
        {
            return new Model.Dados.TratarDados().AumentarPotencia(valor);
        }
        public bool VerificarSeTempoExiste(string valor)
        {
            return new Model.Dados.TratarDados().VerificarSeTempoExiste(valor);
        }
        public string DiminuirPotencia(string valor)
        {
            return new Model.Dados.TratarDados().DiminuirPotencia(valor);
        }
        public bool IndentificaInicioRapido(string valor)
        {
            return new Model.Dados.TratarDados().IndentificaInicioRapido(valor);
        }
        public bool TempoEstaCompleto(string valor)
        {
            return new Model.Dados.TratarDados().TempoEstaCompleto(valor);
        }
        public bool PotenciaVazia(string valor)
        {
            return new Model.Dados.TratarDados().PotenciaVazia(valor);
        }
        public bool TempoMaximoAquecimento(string valor)
        {
            return new Model.Dados.TratarDados().TempoMaximoAquecimento(valor);
        }
        public bool TempoMinimoAquecimento(string valor)
        {
            return new Model.Dados.TratarDados().TempoMinimoAquecimento(valor);
        }
        public string TratarTempo(string valor, int segundo, int minuto)
        {
            return new Model.Dados.TratarDados().TratarTempo(valor, segundo, minuto);
        }
    }
}
