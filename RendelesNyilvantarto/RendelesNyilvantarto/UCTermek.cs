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
        // értéket kap ez a tulajdonság amikor lefut a konsturktor
        public dsRendelesNyilvantarto? dsRendelesNyilvantarto { get; set; }
        bool MentésFolyamatban;
        private dsRendelesNyilvantarto.dtTermékekRow ÚjSor;
        public UCTermek()
        {
            InitializeComponent();
        }

        private void UCTermek_VisibleChanged(object sender, EventArgs e)
        {
            if(!Visible || dsRendelesNyilvantarto == null) return;
            //ha vannak adatok és látható az űrlap akkor az alábbi kód fut le
            cbTermékNév.DataSource = dsRendelesNyilvantarto.dtTermékek;
            cbTermékNév.DisplayMember= "TermékNév";
            cbTermékNév.SelectedIndex= 0;
        }

        private void cbTermékNév_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MentésFolyamatban) return;
            tbTermékNeve.Text = ((cbTermékNév.SelectedItem as DataRowView)?.Row                
                as dsRendelesNyilvantarto.dtTermékekRow)?.TermékNév;
            tbTermékÁra.Text = ((cbTermékNév.SelectedItem as DataRowView)?.Row 
                as dsRendelesNyilvantarto.dtTermékekRow)?.ListaÁr;
            tbTermékKód.Text = ((cbTermékNév.SelectedItem as DataRowView)?.Row 
                as dsRendelesNyilvantarto.dtTermékekRow)?.TermékKód;
            btÚjTermék.Enabled = true;
        }

        private void btMent_Click(object sender, EventArgs e)
        {
            if (tbTermékNeve.Text.Length == 0) return;
            var rekord = (cbTermékNév.SelectedItem as DataRowView)?.Row
                as dsRendelesNyilvantarto.dtTermékekRow;
            if (rekord == null) return;
            MentésFolyamatban = true;
            rekord.TermékNév = tbTermékNeve.Text;
            rekord.TermékKód = tbTermékKód.Text;
            rekord.ListaÁr = tbTermékÁra.Text;
            MentésFolyamatban = false;
            btÚjTermék.Visible = true;
            btMégse.Enabled= false;


        }

        private void btMégse_Click(object sender, EventArgs e)
        {
            //Visible= false;
            if (dsRendelesNyilvantarto == null) return;
            if (ÚjSor!=null)
            dsRendelesNyilvantarto.dtTermékek.RemovedtTermékekRow(ÚjSor);
            btÚjTermék.Visible = true;
            btMégse.Enabled = false;

        }

        private void btÚjTermék_Click(object sender, EventArgs e)
        {
 
            short sorszám;
            if (cbTermékNév.Items.Count == 0)
                sorszám = 1;
            else
            {
                var sor = (cbTermékNév.Items[cbTermékNév.Items.Count - 1] as DataRowView)?.Row
                    as dsRendelesNyilvantarto.dtTermékekRow;
                sorszám = (short)(sor.Azonosító + 1);
            }

            ÚjSor = dsRendelesNyilvantarto.dtTermékek.AdddtTermékekRow(sorszám, "Új termék név",
                "Új ár","Új termékkód");
            cbTermékNév.SelectedIndex=cbTermékNév.Items.Count-1;
            btÚjTermék.Visible = false;
            btMégse.Enabled= true;

        }

        private void btTörlés_Click(object sender, EventArgs e)
        {
            if(dsRendelesNyilvantarto==null) return;
            var TöröltSor = (cbTermékNév.SelectedItem as DataRowView)?.Row as dsRendelesNyilvantarto.dtTermékekRow;
            if(TöröltSor== null) return;
            dsRendelesNyilvantarto.dtTermékek.RemovedtTermékekRow(TöröltSor);
            tbTermékNeve.Text = "";
            tbTermékÁra.Text = "";
            tbTermékKód.Text = "";
            cbTermékNév_SelectedIndexChanged(cbTermékNév, new EventArgs());
            

        }
    }
}
