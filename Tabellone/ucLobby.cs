using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabellone
{
    public partial class ucLobby : UserControl
    {
        public List<CUtente> Utenti { get; set; }
        public ucLobby()
        {
            InitializeComponent();
            Utenti = new List<CUtente>();
        }

       private int indiceUtente(string Username)
        {
            for (int i = 0; i < Utenti.Count; i++)
            {
                if (Utenti[i].Username == Username)
                    return i;
            }
            return -1;
        }
        public int AggiungiUtente(string Username)
        {
            CUtente u = new CUtente(Username, -1);
            if (Utenti.Count() == 30)
                return 1;
            else if (indiceUtente(Username) != -1)
                return 2;
            if (this.tlpLobby.InvokeRequired)
            {
                this.tlpLobby.BeginInvoke((MethodInvoker)delegate () {
                    tlpLobby.Controls["lbl" + Utenti.Count()].Text = Username;
                    tlpLobby.Controls["lbl" + Utenti.Count()].Font = new Font(tlpLobby.Controls["lbl" + Utenti.Count()].Font, FontStyle.Bold);
                    Utenti.Add(u);
                });
            }
            else
            {
                tlpLobby.Controls["lbl" + Utenti.Count()].Text = Username;
                tlpLobby.Controls["lbl" + Utenti.Count()].Font = new Font(tlpLobby.Controls["lbl" + Utenti.Count()].Font, FontStyle.Bold);
                Utenti.Add(u);
            }


            return 0;
        }

        public void RimuoviUtente(string Username)
        {
            int i = indiceUtente(Username);
            if (i == -1)
                return;
            if (this.tlpLobby.InvokeRequired)
            {
                this.tlpLobby.BeginInvoke((MethodInvoker)delegate () {
                    Utenti.RemoveAt(i);

                    for (; i < Utenti.Count(); i++)
                    {
                        tlpLobby.Controls["lbl" + i].Text = Utenti[i].Username;
                    }
                    tlpLobby.Controls["lbl" + Utenti.Count()].Text = "<vuoto>";
                    tlpLobby.Controls["lbl" + Utenti.Count()].Font = new Font(tlpLobby.Controls["lbl" + Utenti.Count()].Font, FontStyle.Regular);
                });
            }
            else
            {
                Utenti.RemoveAt(i);

                for (; i < Utenti.Count(); i++)
                {
                    tlpLobby.Controls["lbl" + i].Text = Utenti[i].Username;
                }
                tlpLobby.Controls["lbl" + Utenti.Count()].Text = "<vuoto>";
                tlpLobby.Controls["lbl" + Utenti.Count()].Font = new Font(tlpLobby.Controls["lbl" + Utenti.Count()].Font, FontStyle.Regular);
            }
            
        }
    }
}
