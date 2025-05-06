using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMotos.Model
{
    public class Moto
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Preco { get; set; }


        public Moto(string marca, string modelo, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Preco = preco;
        }

        

               

    }
}
