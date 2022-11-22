using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D2.OOP_I
{
    internal class InformazioniPersonali
    { 
        // ESEMPIO
        // private string _nome;
        // public string Nome
        // {
        //    get { return _nome; }
        //    set { _nome = value; }
        // }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}
