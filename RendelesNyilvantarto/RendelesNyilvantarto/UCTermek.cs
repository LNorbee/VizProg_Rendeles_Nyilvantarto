using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RendelesNyilvantarto
{
    public partial class UCTermek : UserControl
    {
        // A tipushoz kérdőjel segítéségével automatiusan 0
        // értéket rendel ez a tulajdonság amikor lefut a konsturktor
        public dsRendelesNyilvantarto? dsRendelesNyilvantarto { get; set; }
        bool MentésFolyamatban;
        // deklarálunk egy private dtTermékRow típusú adatagot.
        private dsRendelesNyilvantarto.dtTermékekRow ÚjSor;
        public UCTermek()
        {
            InitializeComponent();
        }

        private void UCTermek_VisibleChanged(object sender, EventArgs e)
        {
            if(!Visible || dsRendelesNyilvantarto == null) return;
            //ha vannak adatok és látható az űrlap akkor az alábbi kód fut le
            //Átadjuk a combo boxnak a dtTermék tábla tartamát
            cbTermékNév.DataSource = dsRendelesNyilvantarto.dtTermékek;
            //A combo boxban csak a Termék Nevét jelenítjük meg.
            cbTermékNév.DisplayMember= "TermékNév";
            //Ha a termékek száma nem 0 csak akkor választjuk ki a 0. indexűt
            if(dsRendelesNyilvantarto.dtTermékek.Count !=0)
            cbTermékNév.SelectedIndex= 0;
        }

        private void cbTermékNév_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MentésFolyamatban) return;
            //Ha a mentés nincs folyamatban akkor a text boxoknak átadjuk a kiválasztott termék adatait.
            //kettős típuskonverzióval
            tbTermékNeve.Text = ((cbTermékNév.SelectedItem as DataRowView)?.Row                
                as dsRendelesNyilvantarto.dtTermékekRow)?.TermékNév;
            tbTermékÁra.Text = ((cbTermékNév.SelectedItem as DataRowView)?.Row 
                as dsRendelesNyilvantarto.dtTermékekRow)?.ListaÁr;
            tbTermékKód.Text = ((cbTermékNév.SelectedItem as DataRowView)?.Row 
                as dsRendelesNyilvantarto.dtTermékekRow)?.TermékKód;
            //Az új Termék gombot újra láthatóvá tesszük.
            btÚjTermék.Enabled = true;
        }

        private void btMent_Click(object sender, EventArgs e)
        {
            if (tbTermékNeve.Text.Length == 0) return;
            // a rekordnak átadjuk a combo boxban kiválszott termék adatait.
            var rekord = (cbTermékNév.SelectedItem as DataRowView)?.Row
                as dsRendelesNyilvantarto.dtTermékekRow;
            // Ha üres és nincs kiválasztva akkor return
            if (rekord == null) return;
            MentésFolyamatban = true;
            // A rekord objektumnak átadjuk a termék jellemzőit
            rekord.TermékNév = tbTermékNeve.Text;
            rekord.TermékKód = tbTermékKód.Text;
            rekord.ListaÁr = tbTermékÁra.Text;
            MentésFolyamatban = false;
            //Az új Termék gombot újra láthatóvá tesszük.
            btÚjTermék.Visible = true;
            //A mégse gombot nem elérhetővé tesszük.
            btMégse.Enabled= false;


        }

        private void btMégse_Click(object sender, EventArgs e)
        {
            //Visible= false;
            if (dsRendelesNyilvantarto == null) return;
            //Ha az újsor objektum létezik akkor töröljük a Termékek táblából
            if (ÚjSor!=null)
            dsRendelesNyilvantarto.dtTermékek.RemovedtTermékekRow(ÚjSor);
            //Az új Termék gombot újra láthatóvá tesszük.
            btÚjTermék.Visible = true;
            //A mégse gombot nem elérhetővé tesszük.
            btMégse.Enabled = false;

        }

        private void btÚjTermék_Click(object sender, EventArgs e)
        {
 
            //Megvizsgáljuk hogy az combo boxban van-e termék,
            //ha nincs akkor a sorszám 1-el fog kezdődni (Az új termék azonsítója)
            short sorszám;
            if (cbTermékNév.Items.Count == 0)
                sorszám = 1;
            else
            {
                var sor = (cbTermékNév.Items[cbTermékNév.Items.Count - 1] as DataRowView)?.Row
                    as dsRendelesNyilvantarto.dtTermékekRow;
                sorszám = (short)(sor.Azonosító + 1);
            }
            //hozzáadjuk a Termékek táblához az új terméket és átadjuk az újsor dtTermékekRow típusnak
            ÚjSor = dsRendelesNyilvantarto.dtTermékek.AdddtTermékekRow(sorszám, "Új termék név",
                "Új ár","Új termékkód");
            //a combobox-ot átugrik az új termék sorára
            cbTermékNév.SelectedIndex=cbTermékNév.Items.Count-1;
            //Az új Termék gombot láthatatlanná tesszük.
            btÚjTermék.Visible = false;
            //A mégse gombot elérhetővé tesszük.
            btMégse.Enabled= true;

        }

        private void btTörlés_Click(object sender, EventArgs e)
        {
            //megvizsgáljuk hogy a Dataset nem üres
            if(dsRendelesNyilvantarto==null) return;
            //A töröltsor objektum megkapja a kiválasztott objektumot
            var TöröltSor = (cbTermékNév.SelectedItem as DataRowView)?.Row as dsRendelesNyilvantarto.dtTermékekRow;
            //Ha üres akkor return
            if(TöröltSor== null) return;
            //Töröljük a sort a dtTermék táblából és a text boxoból is
            dsRendelesNyilvantarto.dtTermékek.RemovedtTermékekRow(TöröltSor);
            tbTermékNeve.Text = "";
            tbTermékÁra.Text = "";
            tbTermékKód.Text = "";
            //Meghívjuk újra a combo boxra selectedindex change függvényt, így újra feltölti a text boxokat.

            cbTermékNév_SelectedIndexChanged(cbTermékNév, new EventArgs());
            //Az új Termék gombot láthatatlanná tesszük.
            btÚjTermék.Visible = true;
            //A mégse gombot elérhetővé tesszük.
            btMégse.Enabled = false;


        }
    }
}
