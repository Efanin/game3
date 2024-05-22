namespace game3
{
    public partial class Form1 : Form
    {
        private Mine ironMine;
        private FormMine formIronMine;

        private Mine coalMine;
        private FormMine formCoalMine;
        private int balance = 100;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            ironMine = new("Iron");
            coalMine = new("Coal");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ironMine.Tick();
            coalMine.Tick();
            showBalance();
            if (formIronMine != null)
            {
                formIronMine.Show(ironMine.NameOre, ironMine.Ore.ToString(), ironMine.Worker.ToString());
                ironMine.SellOre(formIronMine, ref balance);
                ironMine.BuyWorker(formIronMine, ref balance);
            }
            if (formCoalMine != null)
            {
                formCoalMine.Show(coalMine.NameOre,coalMine.Ore.ToString(), coalMine.Worker.ToString());
                coalMine.SellOre(formCoalMine, ref balance);
                coalMine.BuyWorker(formCoalMine, ref balance);
            }
        }

        private void pictureBoxIronMine_Click(object sender, EventArgs e)
        {
            formIronMine = new();
            formIronMine.Show();
        }
        private void pictureBoxCoalMine_Click(object sender, EventArgs e)
        {
            formCoalMine = new();
            formCoalMine.Show();
        }


        public void showBalance()
        {
            labelBalance.Text = "Balance: " + balance.ToString() + "$";
        }

       
    }
}
