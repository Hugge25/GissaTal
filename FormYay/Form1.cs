namespace FormYay
{
    public partial class Form1 : Form
    {
        int datornsTal;
        int antalGissningar;
        public Form1()
        {
            InitializeComponent();

            lbxSt�rstaTalet.Items.Add(10);
            lbxSt�rstaTalet.Items.Add(20);
            lbxSt�rstaTalet.SelectedItem = lbxSt�rstaTalet.Items[0];

        }

        private void tbxMinaResultat_TextChanged_1(object sender, EventArgs e)
        {
            tbxMinaResultat.AppendText("Rad 1\n");
            tbxMinaResultat.AppendText("Rad 2\n");
            tbxMinaResultat.AppendText("Rad 3\n");
            tbxMinaResultat.AppendText("Rad 4\n");
        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            string st�rstaTal = lbxSt�rstaTalet.SelectedItem.ToString();
            int st�rst = int.Parse(st�rstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, st�rst + 1);

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

            }
        }
    }
}