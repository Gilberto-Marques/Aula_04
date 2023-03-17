using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string Bairro;
        private string CEP;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, string numero, string bairro, string cep, string cidade, string estado) 
        { 
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
            this.CEP = cep;
            this.Cidade = cidade;
            this.Estado = estado;

        }

        public string EnderecoCompleto()
        {
            return Rua + ", " + Numero + ", " + Bairro + " Cidade: "+Cidade+ "/" ;
        }

        public string EnderecoCurto()
        {
            return Rua + " " + Numero;
        }

        public Endereco BuscaPorCep(string cep)
        {
            return new Endereco("", "", "", cep, "", "");

        }

        public string EstadoPorCidade(string estado)
        {
            if(estado == "SP")
            {
                return "Taquaritinga";
            }
            return Cidade;
        }

        public void InserirNoBanco(Endereco endereco)
        {
            //db.Null.ENDERECO.ADD(endereco
            //db.savechanges();
        }

        public string getRua()
        {
            return Rua;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }

        public string getNumero() 
        {  
            return Numero; 
        }
        public void setNumero(string numero)
        {
            Numero = numero;
        }

        public string getBairro()
        {
            return Bairro;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public string getCep()
        {
            return CEP;
        }
        public void setCep(string cep)
        {
            CEP = cep;
        }

        public string getCidade()
        {
            return Cidade;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }

        public string getEstado()
        {
            return Estado;
        }
        public void setEstado(string estado)
        {
            Estado = estado;
        }
    }


    
}
