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
            tbxMinaResultat.AppendText("Rad 1\n");
            tbxMinaResultat.AppendText("Rad 2\n");
            tbxMinaResultat.AppendText("Rad 3\n");
            tbxMinaResultat.AppendText("Rad 4\n");
        }
    }
}