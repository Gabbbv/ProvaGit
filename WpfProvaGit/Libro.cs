using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProvaGit
{
    internal class Libro
    {
        private string casaEditrice;
        private string titolo;
        private int lunghezza;
        private List<Partita> partite;

        public Libro(string casaEditrice, string titolo, int lunghezza)
        {
            this.casaEditrice = casaEditrice;
            this.titolo = titolo;
            this.lunghezza = lunghezza;
            partite = new List<Partita>();
        }

        public string CasaEditrice
        {
            get { return casaEditrice; }
            set { casaEditrice = value; }
        }

        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public int Lunghezza
        {
            get { return lunghezza; }
            set { lunghezza = value; }
        }

        public List<Partita> Partite
        {
            get { return partite; }
            set { partite = value; }
        }

        public void AggiungiPartita(Partita partita)
        {
            partite.Add(partita);
        }
    }
}
