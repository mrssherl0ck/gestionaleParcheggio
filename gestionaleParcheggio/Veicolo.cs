using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gestionaleParcheggio
{
    internal class Veicolo
    {  //Campi
        public string targa;
        public string entrata;
        public string uscita;

        //Obiettivo lettura e scrittura
        public DateTime dataOraEntrata { get; set; } = DateTime.Now;
        public DateTime? dataOraUscita { get; set; } = null;

        //Costruttori
        public Veicolo(string targa)
        { this.targa = targa; }
        /*string entrata, string uscita, DateTime dataOraEntrata, DateTime? dataOraUscita)
        {
            this.dataOraEntrata = dataOraEntrata;
            this.dataOraUscita = dataOraUscita;
            this.targa = targa;
            this.entrata = entrata;
            this.uscita = uscita;
        }*/

    }
}
