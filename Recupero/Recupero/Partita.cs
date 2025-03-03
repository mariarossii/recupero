using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupero
{
    class Partita
    {
        private string squadraCasa, squadraFuori;
        private int anno;
        private string risultato;
        private string marcatori;

        public Partita(string squadraCasa, string squadraFuori, int anno, string risultato, string marcatori)
        {
            this.squadraCasa = squadraCasa; 
            this.anno = anno;   
            this.squadraFuori= squadraFuori;    
            this.risultato = risultato; 
            this.marcatori = marcatori;
        }
    }
}
