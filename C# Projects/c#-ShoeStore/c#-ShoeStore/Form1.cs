using System.Security.Cryptography.X509Certificates;

namespace c__ShoeStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void View_Inventory_Click(object sender, EventArgs e)
        {
            int UPC = Convert.ToInt32(UPC_input.Text);
            string Item = Item_input.Text;
            int Quantity = Convert.ToInt32(Quantity_input.Text);
            int Price = Convert.ToInt32(Price_input.Text);
            Form2 frm2 = new Form2(UPC, Item, Quantity, Price);
            frm2.Show();
        }

        private void Add_Inventory_Click(object sender, EventArgs e)
        {
            int UPC = Convert.ToInt32(UPC_input.Text);
            string Item = Item_input.Text;
            int Quantity = Convert.ToInt32(Quantity_input.Text);
            int Price = Convert.ToInt32(Price_input.Text);
            Form2 frm2 = new Form2(UPC, Item, Quantity, Price);
            frm2.Show();
        }
        
    }

    }

