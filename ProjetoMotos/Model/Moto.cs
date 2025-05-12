using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Bitmap URLImage { get; set; }


        public Moto(string marca, string modelo, double preco, Bitmap urlImagem)
        {
            Marca = marca;
            Modelo = modelo;
            Preco = preco;
            URLImage = urlImagem;
        }

        public Moto() { }

        

               

    }
}
