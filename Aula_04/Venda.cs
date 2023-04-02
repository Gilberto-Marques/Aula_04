using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04
{
    internal class Venda
    {
        private int Id;
        private string Data;

        public Venda(int id, string data) 
        {
            Id = id;
            Data = data;
        }

        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }

        public string getData()
        {
            return Data;
        }
        public void setData(string data ) 
        {
            Data = data;
        }


    }
}
