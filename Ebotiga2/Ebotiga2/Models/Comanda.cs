using System;
using System.Collections.Generic;
using System.Text;

namespace Ebotiga2.DataModel
{
    internal class Comanda
    {

        private string Id;
        private string estado;

        public List<string> IDComanda {

            get
            {
                var lista = new List<string>();
                lista.Add(Id);
                lista.Add(estado);
                return lista;
            }

            set {
                Id = "new";
                estado = "new";
            }
        }



        public void crear_comanda()
        {

            Id = this.buscar_ultima_comanda();
            estado = "modificado";


        }


        public string completar_comanda()
        {

            return estado = "completada";

        }


        public void anular_comanda( string estado)
        {
            estado = "anulada";

        }


        public string buscar_ultima_comanda()
        {

            return GetRandomNumber(0, 10000).ToString();

        }


        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
