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
        //przechowuje widok (interfejs)
        IPaymentDetailsView view;

        public PaymentDetailsPresenter(IPaymentDetailsView view)
        {
            this.view = view;
        }

        public bool StorePaymentDetails()
        {
            PaymentDetailsModel model = new PaymentDetailsModel();
            //tworze listę argumentów:
            Tuple<string, string, string, string, string, string> PaymentDetailsTuple =
                new Tuple<string, string, string, string, string, string>(view.FirstName,
                                                                          view.LastName,
                                                                          view.CardNumber,
                                                                          view.CardCvn,
                                                                          view.CardExpiry,
                                                                          view.CardType);
            return model.StorePaymentsDetail(PaymentDetailsTuple);
        }
    }
}
