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

        public List<Partita> CercaPerAnno(int anno)
        {
            List<Partita> PartiteAnnoDato= new List<Partita> ();

            int i = 0;

            do
            {
                if (partite[i].anno == anno)
                {
                    PartiteAnnoDato.Add(partite[i]);
                }
                i++;

            }while(i== partite.Count ); 

            return PartiteAnnoDato; 
        }

        public List<Partita> CercaSquadra(string squadra)
        {
            List<Partita> PartiteSquadra = new List<Partita>();

            int i = 0;

            do
            {
                if (partite[i].squadaCasa == squadra || partite[i].squadraFuori)
                {
                    PartiteSquadra.Add(partite[i]);
                }
                i++;

            } while (i == partite.Count);
            return PartiteSquadra;
        }

        public int PartiteInserite()
        {
            return partite.Count;
        }

    }
}
