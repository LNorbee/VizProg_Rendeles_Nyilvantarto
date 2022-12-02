using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace RendelesNyilvantarto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Létrehoz();
            //Lement();
            Betölt();
        }

        private void Lement()
        {
            // A dsRendelesNyilvantarto Dataset tartalmát kiírjuk a RendelesNyilvantarto.xml -be
            dsRendelesNyilvantarto.WriteXml("RendelesNyilvantarto.xml", XmlWriteMode.IgnoreSchema);
        }

        private void Létrehoz()
        {
            // Egy DateTime objektumot hozunk létre, amelyet a DataSet dtRendelések tábla új rekord felvitelénél használunk fel.
            DateTime utcTime1 = new DateTime(2008, 6, 19, 7, 0, 0);
            // A megadott paraméterekel a DataSet tábláiba létrehozunk új sorokat.
            dsRendelesNyilvantarto.dtRendelések.AdddtRendelésekRow(1, "Test Elek", utcTime1, utcTime1);
            dsRendelesNyilvantarto.dtRendelések.AdddtRendelésekRow(2, "Gipsz Jakó", utcTime1, utcTime1);
            dsRendelesNyilvantarto.dtTermékek.AdddtTermékekRow(1, "Televízió", "100000", "tv-01");
            dsRendelesNyilvantarto.dtTermékek.AdddtTermékekRow(2, "Rádió", "20000", "radio-01");
            dsRendelesNyilvantarto.dtRendelésRészletei.AdddtRendelésRészleteiRow(1, 1);
            dsRendelesNyilvantarto.dtRendelésRészletei.AdddtRendelésRészleteiRow(2, 1);

        }

        private void Betölt()
        {
            // A RendelesNyilvantarto.xml állomány tartalmát betöltjük a dsRendelesNyilvatarto DataSet-be
            dsRendelesNyilvantarto.ReadXml("RendelesNyilvantarto.xml", XmlReadMode.InferSchema);
        }

        private void tsmiKilépés_Click(object sender, EventArgs e)
        {
            // A programból kilépünk
            Close();
        }

        private void tsmiRendelések_Click(object sender, EventArgs e)
        {
            // kattintásra látható lesz a rendelések listája
            ucTermek.Visible = false;
            ucRendelesFelvetel.Visible = false;
            dgv.Visible = true;
            dgv.Dock= DockStyle.Fill;
            //dgv.DataSource = dsRendelesNyilvantarto.dtRendelések;

            //Egy (táblák összekapcsolását tartalmazó)LINQ lekérdezéssel megkapjuk eredményként
            // a vevõ nevét, rendelés kódját, termékek nevét, szállítási és rendelési dátumát.
            
            var eredm = from x in dsRendelesNyilvantarto.dtRendelések
                        select new
                        {
                            x.VevõNeve,
                            x.Rendeléskód,
                            Termékek = (from y in dsRendelesNyilvantarto.dtRendelésRészletei
                                       where y.RendelésKód == x.Rendeléskód
                                       join z in dsRendelesNyilvantarto.dtTermékek
                                           on y.TermékAzonosító equals z.Azonosító
                                       select z.TermékNév).Aggregate("",
                                            (s, val) => s + (s.Length == 0 ? "" : ", ") + val),
                            
                            x.RendelésiDátum,
                            x.SzállításiDátum
                        };

            //Az eredményt pedig megjelenítjük a DataGridView-ben.
            dgv.DataSource = eredm.ToList();
        }

        private void tsmiTermék_Click(object sender, EventArgs e)
        {
            //A DataGridView láthatóságát kikapcsoljuk
            dgv.Visible= false;
            //A Rendelésfelvétel user control láthatóságát kikapcsoljuk
            ucRendelesFelvetel.Visible = false;
            //átadja az ûrlapnak az infot
            ucTermek.dsRendelesNyilvantarto = dsRendelesNyilvantarto;
            //A Termékek User control láthatóságát igazra állítjuk.
            ucTermek.Visible = true;
            // A Rendelésfelvétel User Control DockStyle - t Fill - re állítjuk
            ucTermek.Dock = DockStyle.Fill;
        }

        private void tsmMentés_Click(object sender, EventArgs e)
        {
            // Meghívjuk a Lement() függvényt amivel az XML fáljt újra írjuk.
            Lement();
        }

        private void rendelésFelvételToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //A DataGridView láthatóságát kikapcsoljuk
            dgv.Visible = false;
            // A Termék User Control ûrlap láthatóságát kikapcsoljuk
            ucTermek.Visible= false;   
            //átadja az ûrlapnak az infokat
            ucRendelesFelvetel.dsRendelesNyilvantarto = dsRendelesNyilvantarto;
            //A Rendelésfelvétel User Control láthatóságát igazra állítjuk
            ucRendelesFelvetel.Visible = true;
            //A Rendelésfelvétel User Control DockStyle-t Fill-re állítjuk
            ucRendelesFelvetel.Dock = DockStyle.Fill;
        }
    }
}