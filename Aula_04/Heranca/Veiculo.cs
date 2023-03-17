using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04.Heranca
{
    public class Veiculo
    {
        public int numeroAssento;
        public int numeroPortas;
        public bool temMotor;

        public string ExibirDados()
        {
            if(temMotor == true)
            {
                return "Com motor: \nAssentos:" + numeroAssento + "\nPortas:" + numeroPortas;
            }
            else
            {
                return numeroAssento + " " + numeroPortas;
            }
        }
    }
}
