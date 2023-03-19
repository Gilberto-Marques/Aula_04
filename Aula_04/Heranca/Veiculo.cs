using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04.Heranca
{
    public class Veiculo
    {
        private string marcaVeiculo;
        private string tipoVeiculo;
        private int numeroAssento;
        private int numeroPortas;
        private bool temMotor;

        public Veiculo(string marcaVeiculo, string tipoVeiculo, int nAssento, int nPortas, bool temMotor)
        { 
            this.marcaVeiculo = marcaVeiculo;
            this.tipoVeiculo = tipoVeiculo;
            numeroAssento = nAssento;
            numeroPortas = nPortas;
            this.temMotor = temMotor;
        }

        public string ExibirTipoVeiculo()
        {
            return "Tipos de Veículos: Carro, Caminhão, Motocicleta, Barco, Avião";
        }
        public string ExibirDados()
        {
            return "EU";
        }

        public string getMarcaVeiculo()
        {
            return marcaVeiculo;
        }
        public void setMarcaVeiculo(string marca)
        {
            marcaVeiculo = marca;
        }

        public string getTipoVeiculo()
        {
            return tipoVeiculo;
        }
        public void setTipoVeiculo(string tipo)
        {
            tipoVeiculo = tipo;
        }

        public int getNumeroAssento()
        {
            return numeroAssento;
        }
        public void setNumeroAssento(int numeroAssento)
        {
            this.numeroAssento = numeroAssento;
        }

        public int getNumeroPortas()
        {
            return this.numeroPortas;
        }
        public void setNumeroPortas(int numeroPortas)
        {
            this.numeroPortas = numeroPortas;
        }

        public bool getTemMotor()
        {
            return temMotor;
        }
        public void setTemMotor(bool temMotor)
        {
            this.temMotor = temMotor;
        }
    }
}
