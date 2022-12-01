using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RendelesNyilvantarto
{
    public partial class ucRendelesFelvetel : UserControl
    {
        public dsRendelesNyilvantarto? dsRendelesNyilvantarto { get; set; }
        bool MentésFolyamatban;
        public ucRendelesFelvetel()
        {
            InitializeComponent();
        }

        private void ucRendelesFelvetel_VisibleChanged(object sender, EventArgs e)
        {
            if(!Visible || dsRendelesNyilvantarto == null) return;
            cLBTermékek.DataSource = dsRendelesNyilvantarto.dtTermékek;
            cLBTermékek.DisplayMember = "TermékNév";
            cLBTermékek.SelectedIndex= 0;
        }

        private void btRendeles_Click(object sender, EventArgs e)
        {
            if(tbVevőNeve.Text.Length == 0) return;
            //var clbRekord =
            short sorszám;
            if (dsRendelesNyilvantarto.dtRendelések.Count == 0)
                sorszám = 1;
            else
            {               
                sorszám = (short)(dsRendelesNyilvantarto.dtRendelések.Count + 1);
            }
            DateTime utcTime1 = new DateTime(2008, 6, 19, 7, 0, 0);
            dsRendelesNyilvantarto.dtRendelések.AdddtRendelésekRow(sorszám, tbVevőNeve.Text, utcTime1, utcTime1);

            foreach (object itemChecked in cLBTermékek.CheckedItems)
            {
               
                    DataRowView? castedItem = itemChecked as DataRowView;
                    string termékAzonosító = castedItem["Azonosító"].ToString();
                    dsRendelesNyilvantarto.dtRendelésRészletei.AdddtRendelésRészleteiRow
                        (sorszám, short.Parse(termékAzonosító));
                
            }
             
                



        }
    }
}
