using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recupero
{
    internal class Libro
    {
        private string casa;
        private int pagine;
        private string titolo;
        private List<Partita> partite = new List <Partita>();

        public Libro (string casa, int pagine, string titolo, List<Partita> partite)
        {
            this.casa = casa;
            this.pagine = pagine;
            this.titolo = titolo;
            this.partite = partite;
        }

        public void AggiungiPartita(Partita nuovaPartita)
        {
            partite.Add(nuovaPartita);
        }

        public Partita CercaPerAnno(int anno)
        {
            
        }

    }
}
