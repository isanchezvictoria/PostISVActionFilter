using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActionFilter.Models
{
    public class Coche
    {

        public Coche(int id, String marca, String modelo, string color)
        {
            this.IdCoche = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
        }


        public int IdCoche { get; set; }

        public String Marca { get; set; }

        public String Modelo { get; set; }

        public String Color { get; set; }
    }
}