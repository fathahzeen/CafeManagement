using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.AllUserControls
{
    public partial class UC_AddItems : UserControl
    {

        function fn = new function();
        String query;

        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            query = "insert into item (name,category,price) values ('" + comboBox1.Text + "', '" + textBox1.Text + "', " + textBox2.Text + ")";
            fn.setData(query);
            clearAll();
        }

        public void clearAll()
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddItems_Load(object sender, EventArgs e)
        {

        }
    }
}
