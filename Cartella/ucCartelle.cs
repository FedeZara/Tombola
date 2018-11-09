using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartella
{

    public partial class ucCartelle : UserControl
    {
        private static ucCartelle mIstanza;

        public static ucCartelle Istanza
        {
            get
            {
                if (mIstanza == null)
                    mIstanza = new ucCartelle();
                return mIstanza;
            }
        }
        public ucCartelle()
        {
            InitializeComponent();
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
