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
            //Ha látható a Rendelés felvétel user control és a DataSet nem üres akkor átadjuk
            //a checkedListboxnak DataSource tuldajdonságának a dtTermékek tábla tartalmát
            cLBTermékek.DataSource = dsRendelesNyilvantarto.dtTermékek;
            //Kiválasztjuk, hogy a TermékNév oszlop jelenjen meg a checkedListboxban.
            cLBTermékek.DisplayMember = "TermékNév";
            if (dsRendelesNyilvantarto.dtTermékek.Count != 0)
                cLBTermékek.SelectedIndex= 0;
        }

        private void btRendeles_Click(object sender, EventArgs e)
        {
            // Megvizsgáljuk hogy a vevő neve beviteli mező nem üres
            if(tbVevőNeve.Text.Length == 0) return;
            // Megvizsgáljuk, hogy a Rendelések táblában létezik-e már rendelés,
            // ha nem akkor alapértlemeztten a sorszám 1-el fog kezdődni
            short sorszám;
            if (dsRendelesNyilvantarto.dtRendelések.Count == 0)
                sorszám = 1;
            else
            {               
                sorszám = (short)(dsRendelesNyilvantarto.dtRendelések.Count + 1);
            }
            //Létrehozunk egy DateTime objektumot amit paraméterül adunk a Rendelések Tábla hozzáadásánál
            DateTime utcTime1 = new DateTime(2008, 6, 19, 7, 0, 0);
            dsRendelesNyilvantarto.dtRendelések.AdddtRendelésekRow(sorszám, tbVevőNeve.Text, utcTime1, utcTime1);
            //A forciklus segítségével bejárjuk a checkedListBox -t. 
            //Megvizsgáljuk, melyik van bejelölve és azokat a termékeket fogjuk berakni
            //a Rendelések Részletei táblában az új rendelés azonosító párjával.
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
