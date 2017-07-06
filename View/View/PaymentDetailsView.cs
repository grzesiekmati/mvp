using Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class PaymentDetailsView : Form, IPaymentDetailsView
    {
        public PaymentDetailsView()
        {
            InitializeComponent();
        }

        #region IPaymentsDetailView implementations
        public string CardCvn
        {
            get
            {
                return tbCardCvn.Text;
            }

            set
            {
                tbCardCvn.Text = value;
            }
        }

        public string CardExpiry
        {
            get
            {
                return tbCardExpiry.Text;
            }

            set
            {
                tbCardExpiry.Text = value;
            }
        }

        public string CardNumber
        {
            get
            {
                return tbCardNumber.Text;
            }

            set
            {
                tbCardNumber.Text = value;
            }
        }

        public string CardType
        {
            get
            {
                return tbCardType.Text;
            }

            set
            {
                tbCardType.Text = value;
            }
        }

        public string FirstName
        {
            get
            {
                return tbName.Text;
            }

            set
            {
                tbName.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return tbSurname.Text;
            }

            set
            {
                tbSurname.Text = value;
            }
        }
        #endregion

        private void saveBttn_Click(object sender, EventArgs e)
        {
            PaymentDetailsPresenter presenter = new PaymentDetailsPresenter(this);

            if(presenter.StorePaymentDetails())
            {
                //OK - dodano
            }
            else
            {
                MessageBox.Show("Wystąpił błąd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
