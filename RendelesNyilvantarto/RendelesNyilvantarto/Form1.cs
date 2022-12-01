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
            dsRendelesNyilvantarto.WriteXml("RendelesNyilvantarto.xml", XmlWriteMode.IgnoreSchema);
        }

        private void L�trehoz()
        {
            DateTime utcTime1 = new DateTime(2008, 6, 19, 7, 0, 0);
            dsRendelesNyilvantarto.dtRendel�sek.AdddtRendel�sekRow(1, "Test Elek", utcTime1, utcTime1);
            dsRendelesNyilvantarto.dtRendel�sek.AdddtRendel�sekRow(2, "Gipsz Jak�", utcTime1, utcTime1);
            dsRendelesNyilvantarto.dtTerm�kek.AdddtTerm�kekRow(1, "Telev�zi�", "100000", "tv-01");
            dsRendelesNyilvantarto.dtTerm�kek.AdddtTerm�kekRow(2, "R�di�", "20000", "radio-01");
            dsRendelesNyilvantarto.dtRendel�sR�szletei.AdddtRendel�sR�szleteiRow(1, 1);
            dsRendelesNyilvantarto.dtRendel�sR�szletei.AdddtRendel�sR�szleteiRow(2, 1);

        }

        private void Bet�lt()
        {
            dsRendelesNyilvantarto.ReadXml("RendelesNyilvantarto.xml", XmlReadMode.InferSchema);
        }

        private void tsmiKil�p�s_Click(object sender, EventArgs e)
        {
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
            dgv.DataSource = eredm.ToList();
        }

        private void tsmiTerm�k_Click(object sender, EventArgs e)
        {
            dgv.Visible= false;
            ucRendelesFelvetel.Visible = false;
            //�tadja az �rlapnak az infot
            ucTermek.dsRendelesNyilvantarto = dsRendelesNyilvantarto;
            ucTermek.Visible = true;
            ucTermek.Dock = DockStyle.Fill;
        }

        private void tsmMent�s_Click(object sender, EventArgs e)
        {
            Lement();
        }

        private void rendel�sFelv�telToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv.Visible = false;
            ucTermek.Visible= false;   
            //�tadja az �rlapnak az infot
            ucRendelesFelvetel.dsRendelesNyilvantarto = dsRendelesNyilvantarto;
            ucRendelesFelvetel.Visible = true;
            ucRendelesFelvetel.Dock = DockStyle.Fill;
        }
    }
}