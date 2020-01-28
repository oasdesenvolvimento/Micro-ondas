using System.Collections.Generic;
using Micro_ondas.View;

namespace Micro_ondas.Model.Dicionario
{
    public class DicionarioMicroondas : FrmMicroondas
    {
        public Dictionary<int, string> potencia = new Dictionary<int, string>()
        {
            [1] = ".",
            [2] = "..",
            [3] = "...",
            [4] = "....",
            [5] = ".....",
            [6] = "......",
            [7] = ".......",
            [8] = "........",
            [9] = ".........",
            [10] = "..........",
        };
        public Dictionary<string, string> inicioRapido = new Dictionary<string, string>()
        {
            ["tempo"] = "00:30",
            ["potencia"] = "8",
        };
        public Dictionary<string, string> valorBotoes = new Dictionary<string, string>()
        {
            ["btnUm"] = "1",
            ["btnDois"] = "2",
            ["btnTres"] = "3",
            ["btnQuatro"] = "4",
            ["btnCinco"] = "5",
            ["btnSeis"] = "6",
            ["btnSete"] = "7",
            ["btnOito"] = "8",
            ["btnNove"] = "9",
            ["btnZero"] = "0",
        };
    }
}
