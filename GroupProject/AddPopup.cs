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
    public partial class AddPopup : Form
    {
        public AddPopup()
        {
            InitializeComponent();
            this.AddButtonOk.DialogResult = DialogResult.OK;
            this.AddButtonCancel.DialogResult = DialogResult.Cancel;
        }

        private void QuantityQuestionInput_ValueChanged(object sender, EventArgs e)
        {
        }

        public void SetProductName(string productName)
        {
            this.QuantityQuestionLabel.Text = "How many " + productName + " do you want?";
        }

        public int ProductQuantity
        {
            get { return (int) this.QuantityQuestionInput.Value; }
            set { if (value >= 0) this.QuantityQuestionInput.Value = value; }
        }
    }
}