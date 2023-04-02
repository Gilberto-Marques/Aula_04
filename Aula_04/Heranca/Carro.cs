
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04.Heranca
{
    //Classe carro herda todos os atributos da classe Veiculo
    public class Carro: Veiculo
    {
        public bool cintoSeguranca;
        public bool arCondicionado;
        public string marcaRadio;
        public string fabricante;

        public string ExibirMarca()
        {
            return "O fabricante deste veiculo é: "+fabricante;
        }

    }
}


