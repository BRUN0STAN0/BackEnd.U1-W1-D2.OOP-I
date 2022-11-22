using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.U1_W1_D2.OOP_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CV CV = new CV();

            InformazioniPersonali BrunoStano = new InformazioniPersonali();

            BrunoStano.Nome = "Bruno";
            BrunoStano.Cognome = "Stano";
            BrunoStano.Telefono = "3898996461";
            BrunoStano.Email = "brunostano00@pm.me";

            CV.InformazioniPersonali = BrunoStano;

            Studi PeritoTrasportoMarittimo = new Studi();

            PeritoTrasportoMarittimo.Qualifica = "Conduzione Mezzi Navali";
            PeritoTrasportoMarittimo.Istituto = "Istituto Tecnico Nautico";
            PeritoTrasportoMarittimo.Tipo = "Tecnico";
            PeritoTrasportoMarittimo.Dal = new DateTime(2008, 09, 15);
            PeritoTrasportoMarittimo.Al = new DateTime(2013, 06, 15);

            Studi JrFullStack = new Studi();

            JrFullStack.Qualifica = "Junior Full Stack Developer";
            JrFullStack.Istituto = "Epicode School Italia";
            JrFullStack.Tipo = "Attestato";
            JrFullStack.Dal = new DateTime(2022, 08, 29);
            JrFullStack.Al = new DateTime(2023, 02, 25);

            CV.StudiEffettuati.Add(PeritoTrasportoMarittimo);
            CV.StudiEffettuati.Add(JrFullStack);

            Impiego Studente = new Impiego();

            Esperienza JrFullStackEsperienza = new Esperienza();

            JrFullStackEsperienza.Azienda = "Epicode School Italia";
            JrFullStackEsperienza.TitoloLavoro = "Junior Full Stack Developer";
            JrFullStackEsperienza.Dal = new DateTime(2022, 08, 29);
            JrFullStackEsperienza.Al = new DateTime(2023, 02, 25);
            JrFullStackEsperienza.Descrizione = "Studente";
            JrFullStackEsperienza.Compiti = "Studente";

            Studente.Esperienza = JrFullStackEsperienza;

            CV.Impieghi.Add(Studente);

            CV.StampaDettagliCVSuSchermo();
            Console.ReadLine();
        }
        
    }
}
