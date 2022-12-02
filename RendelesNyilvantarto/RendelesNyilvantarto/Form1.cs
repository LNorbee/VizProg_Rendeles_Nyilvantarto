using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace RendelesNyilvantarto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //L�trehoz();
            //Lement();
            Bet�lt();
        }

        private void Lement()
        {
            // A dsRendelesNyilvantarto Dataset tartalm�t ki�rjuk a RendelesNyilvantarto.xml -be
            dsRendelesNyilvantarto.WriteXml("RendelesNyilvantarto.xml", XmlWriteMode.IgnoreSchema);
        }

        private void L�trehoz()
        {
            // Egy DateTime objektumot hozunk l�tre, amelyet a DataSet dtRendel�sek t�bla �j rekord felvitel�n�l haszn�lunk fel.
            DateTime utcTime1 = new DateTime(2008, 6, 19, 7, 0, 0);
            // A megadott param�terekel a DataSet t�bl�iba l�trehozunk �j sorokat.
            dsRendelesNyilvantarto.dtRendel�sek.AdddtRendel�sekRow(1, "Test Elek", utcTime1, utcTime1);
            dsRendelesNyilvantarto.dtRendel�sek.AdddtRendel�sekRow(2, "Gipsz Jak�", utcTime1, utcTime1);
            dsRendelesNyilvantarto.dtTerm�kek.AdddtTerm�kekRow(1, "Telev�zi�", "100000", "tv-01");
            dsRendelesNyilvantarto.dtTerm�kek.AdddtTerm�kekRow(2, "R�di�", "20000", "radio-01");
            dsRendelesNyilvantarto.dtRendel�sR�szletei.AdddtRendel�sR�szleteiRow(1, 1);
            dsRendelesNyilvantarto.dtRendel�sR�szletei.AdddtRendel�sR�szleteiRow(2, 1);

        }

        private void Bet�lt()
        {
            // A RendelesNyilvantarto.xml �llom�ny tartalm�t bet�ltj�k a dsRendelesNyilvatarto DataSet-be
            dsRendelesNyilvantarto.ReadXml("RendelesNyilvantarto.xml", XmlReadMode.InferSchema);
        }

        private void tsmiKil�p�s_Click(object sender, EventArgs e)
        {
            // A programb�l kil�p�nk
            Close();
        }

        private void tsmiRendel�sek_Click(object sender, EventArgs e)
        {
            // kattint�sra l�that� lesz a rendel�sek list�ja
            ucTermek.Visible = false;
            ucRendelesFelvetel.Visible = false;
            dgv.Visible = true;
            dgv.Dock= DockStyle.Fill;
            //dgv.DataSource = dsRendelesNyilvantarto.dtRendel�sek;

            //Egy (t�bl�k �sszekapcsol�s�t tartalmaz�)LINQ lek�rdez�ssel megkapjuk eredm�nyk�nt
            // a vev� nev�t, rendel�s k�dj�t, term�kek nev�t, sz�ll�t�si �s rendel�si d�tum�t.
            
            var eredm = from x in dsRendelesNyilvantarto.dtRendel�sek
                        select new
                        {
                            x.Vev�Neve,
                            x.Rendel�sk�d,
                            Term�kek = (from y in dsRendelesNyilvantarto.dtRendel�sR�szletei
                                       where y.Rendel�sK�d == x.Rendel�sk�d
                                       join z in dsRendelesNyilvantarto.dtTerm�kek
                                           on y.Term�kAzonos�t� equals z.Azonos�t�
                                       select z.Term�kN�v).Aggregate("",
                                            (s, val) => s + (s.Length == 0 ? "" : ", ") + val),
                            
                            x.Rendel�siD�tum,
                            x.Sz�ll�t�siD�tum
                        };

            //Az eredm�nyt pedig megjelen�tj�k a DataGridView-ben.
            dgv.DataSource = eredm.ToList();
        }

        private void tsmiTerm�k_Click(object sender, EventArgs e)
        {
            //A DataGridView l�that�s�g�t kikapcsoljuk
            dgv.Visible= false;
            //A Rendel�sfelv�tel user control l�that�s�g�t kikapcsoljuk
            ucRendelesFelvetel.Visible = false;
            //�tadja az �rlapnak az infot
            ucTermek.dsRendelesNyilvantarto = dsRendelesNyilvantarto;
            //A Term�kek User control l�that�s�g�t igazra �ll�tjuk.
            ucTermek.Visible = true;
            // A Rendel�sfelv�tel User Control DockStyle - t Fill - re �ll�tjuk
            ucTermek.Dock = DockStyle.Fill;
        }

        private void tsmMent�s_Click(object sender, EventArgs e)
        {
            // Megh�vjuk a Lement() f�ggv�nyt amivel az XML f�ljt �jra �rjuk.
            Lement();
        }

        private void rendel�sFelv�telToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //A DataGridView l�that�s�g�t kikapcsoljuk
            dgv.Visible = false;
            // A Term�k User Control �rlap l�that�s�g�t kikapcsoljuk
            ucTermek.Visible= false;   
            //�tadja az �rlapnak az infokat
            ucRendelesFelvetel.dsRendelesNyilvantarto = dsRendelesNyilvantarto;
            //A Rendel�sfelv�tel User Control l�that�s�g�t igazra �ll�tjuk
            ucRendelesFelvetel.Visible = true;
            //A Rendel�sfelv�tel User Control DockStyle-t Fill-re �ll�tjuk
            ucRendelesFelvetel.Dock = DockStyle.Fill;
        }
    }
}