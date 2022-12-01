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
            dsRendelesNyilvantarto.WriteXml("RendelesNyilvantarto.xml", XmlWriteMode.IgnoreSchema);
        }

        private void Létrehoz()
        {
            DateTime utcTime1 = new DateTime(2008, 6, 19, 7, 0, 0);
            dsRendelesNyilvantarto.dtRendelések.AdddtRendelésekRow(1, "Test Elek", utcTime1, utcTime1);
            dsRendelesNyilvantarto.dtRendelések.AdddtRendelésekRow(2, "Gipsz Jakó", utcTime1, utcTime1);
            dsRendelesNyilvantarto.dtTermékek.AdddtTermékekRow(1, "Televízió", 100000, "tv-01");
            dsRendelesNyilvantarto.dtTermékek.AdddtTermékekRow(2, "Rádió", 20000, "radio-01");
            dsRendelesNyilvantarto.dtRendelésRészletei.AdddtRendelésRészleteiRow(1, 1);
            dsRendelesNyilvantarto.dtRendelésRészletei.AdddtRendelésRészleteiRow(2, 1);

        }

        private void Betölt()
        {
            dsRendelesNyilvantarto.ReadXml("RendelesNyilvantarto.xml", XmlReadMode.InferSchema);
        }

        private void tsmiKilépés_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiRendelések_Click(object sender, EventArgs e)
        {
            // kattintásra látható lesz a rendelések listája
            dgv.Visible = true;
            dgv.Dock= DockStyle.Fill;
            //dgv.DataSource = dsRendelesNyilvantarto.dtRendelések;

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
            dgv.DataSource = eredm.ToList();
        }
    }
}