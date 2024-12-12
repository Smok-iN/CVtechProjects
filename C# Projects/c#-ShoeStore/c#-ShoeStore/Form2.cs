using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__ShoeStore
{
    public partial class Form2 : Form
    {
        public Form2(int UPC, string Item, int Quantity, int Price)
        {
            InitializeComponent();
            int UPC_data = UPC;
            string Item_data = Item;
            int Quantity_data = Quantity;
            int Price_data = Price;

        }
        public class Shoes
        {
            public int UPC { get; set; }
            public string Item { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Shoes> lstShoes = new List<Shoes>();
            lstShoes.Add(new Shoes()
            {
                UPC = Convert.ToInt32(UPC_data),
                Item = Convert.ToString(Item_data),
                Quantity = Convert.ToInt32(Quantity_data),
                Price = Convert.ToInt32(ListPrice_data)
            });
            BindingSource binding = new BindingSource();
            binding.DataSource = lstShoes;

            dataGridView1.DataSource = binding;



        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





    }
}

