using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProvaGit
{
    class Partita
    {
        private string squadraCasa;
        private string squadraTrasferta;
        private int anno;
        private int golSq1;
        private int golSq2;
        private List<string> marcatori;

        public Partita(string squadraCasa, string squadraTrasferta, int anno, int golSq1, int golSq2)
        {
            this.squadraCasa = squadraCasa;
            this.squadraTrasferta = squadraTrasferta;
            this.anno = anno;
            this.golSq1 = golSq1;
            this.golSq2 = golSq2;
            this.marcatori = new List<string>;
        }

        public string SquadraCasa { get => squadraCasa; set => squadraCasa = value; }
        public string SquadraTrasferta { get => squadraTrasferta; set => squadraTrasferta = value; }
        public int Anno { get => anno; set => anno = value; }
        public int GolSq1 { get => golSq1; set => golSq1 = value; }
        public int GolSq2 { get => golSq2; set => golSq2 = value; }
        public List<string> Marcatori { get => marcatori; set => marcatori = value; }

        public override string ToString()
        {
            string s = squadraCasa + " - " + squadraTrasferta + " " + golSq1 + " - " + golSq2 + " " + anno + "\n";
            foreach (string m in marcatori)
            {
                s += m + "\n";
            }
            return s;
        }
    }
}
