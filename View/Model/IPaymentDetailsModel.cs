using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    interface IPaymentDetailsModel
    {
        //string Name { get; set; }
        //string Surname { get; set; }
        //string CardNumber { get; set; }
        //string CardType { get; set; }
        //string CardCvn { get; set; }
        //string CardExpiry { get; set; }

        bool StorePaymentsDetail(Tuple<string, string, string, string, string, string> PaymentDetailsList);
    }
}
