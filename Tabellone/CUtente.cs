using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabellone
{
    public class CUtente
    {
        public string Username { get; set; }
        public int NumCartelle { get; set; }
        public CUtente(string Username, int NumCartelle)
        {
            this.NumCartelle = NumCartelle;
            this.Username = Username;
        }
        public CUtente()
        {

        }
        
    }
}
