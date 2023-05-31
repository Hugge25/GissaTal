namespace FormYay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxMinaResultat_TextChanged_1(object sender, EventArgs e)
        {
            MinaResultat.AppendText("Rad 1\n");
            MinaResultat.AppendText("Rad 2\n");
            MinaResultat.AppendText("Rad 3\n");
            MinaResultat.AppendText("Rad 4\n");
        }
    }
}