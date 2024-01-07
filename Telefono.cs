using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        private string modelo;
        private string marca;
        private string numTel;
        private int codOper;

        public Telefono( string modelo , string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }

        public string NumTel { get; set; }

        public int CodOper
        {
            get { return codOper; }
            set
            {
                if (value > 0 && value < 4)
                {
                    this.codOper= value;
                }
                else
                {
                    this.codOper= 0;
                }
            }
        }

        //METODO
        public string llamar()
        {
            return "Realizando llamada";
        }
        public string llamar( string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}
