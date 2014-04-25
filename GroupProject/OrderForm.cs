using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class OrderForm : Form
    {
        public string AccountNumber { get; private set; }

        public OrderForm(double total)
        {
            InitializeComponent();
            this.total.Text = "Total : $" + total;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            AccountNumber = this.acnbtextbox.Text;
        }
    }
}
