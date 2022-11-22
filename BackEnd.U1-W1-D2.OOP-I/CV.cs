using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D2.OOP_I
{
    internal class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; } = new List<Studi>();
        public List<Impiego> Impieghi { get; set; } = new List<Impiego>();


        public void StampaDettagliCVSuSchermo() {

            Console.Write($"\n" +
                            $"--------------{InformazioniPersonali.Nome} {InformazioniPersonali.Cognome}-------------\n" +
                            $"\n" +
                            $"+ INFORMAZIONI PERSONALI:\n" +
                            $"Nome: {InformazioniPersonali.Nome}\n" +
                            $"Cognome: {InformazioniPersonali.Cognome}\n" +
                            $"Email: {InformazioniPersonali.Email}\n" +
                            $"Telefono: {InformazioniPersonali.Telefono}\n" +
                            $"\n");

            Console.WriteLine("+ STUDI E FORMAZIONE");
            foreach (Studi item in StudiEffettuati) {
                Console.Write($"\n" +
                            
                            $"Istituto: {item.Istituto}\n" +
                            $"Qualifica: {item.Qualifica}\n" +
                            $"Tipo: {item.Tipo}\n" +
                            $"Dal {item.Dal} al {item.Al}\n" +
                            $"\n");
            }

            Console.WriteLine("+ ESPERIENZE PROFESSIONALI");
            foreach (Impiego item in Impieghi)
            {
                Console.Write($"\n" +
                            
                            $"Presso: {item.Esperienza.Azienda}\n" +
                            $"Tipo di lavoro: {item.Esperienza.TitoloLavoro}\n" +
                            $"Compito: {item.Esperienza.Compiti}\n" +
                            $"Dal {item.Esperienza.Dal} al {item.Esperienza.Al} \n\n");
            }
        }
    }
}
