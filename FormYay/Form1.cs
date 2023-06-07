namespace FormYay
{
    public partial class Form1 : Form
    {
        int datornsTal;
        int antalGissningar;
        public Form1()
        {
            InitializeComponent();

            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);
            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0];
        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);

            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "???";
            antalGissningar = 0;
        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = tbxGissa.Text;
            int gissatTal = int.Parse(gissa);

            if(gissatTal == datornsTal)
            {
                lblResultat.Text = "Korrekt efter " + antalGissningar + " försök.";
                gbxSpelet.Enabled = false;
                gbxSpeldata.Enabled= true;
                btnSpelaIgen.Enabled = true;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + " försök");
                tbxMinaResultat.AppendText(Environment.NewLine);
            }

            else if (gissatTal < datornsTal)
            {
                lblResultat.Text = "För lågt. Försök igen.";
            }
            else
            {
                lblResultat.Text = "För högt. Försök igen.";
            }
        }

        private void btnSpelaIgen_Click(object sender, EventArgs e)
        {
            gbxSpeldata.Enabled = true;
            gbxSpelet.Enabled = false;
            tbxGissa.Text = "";
            lblResultat.Text = "";

            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);

            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "???";
            antalGissningar = 0;
        }
    }
}