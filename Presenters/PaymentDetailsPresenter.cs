using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Presenters
{
    class PaymentDetailsPresenter
    {
        IPaymentDetailsView view;

        public PaymentDetailsPresenter(IPaymentDetailsView view)
        {
            this.view = view;
        }
    }
}
