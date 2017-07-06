using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    interface IPaymentDetailsView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string CardNumber { get; set; }
        string CardExpiry { get; set; }
        string CardType { get; set; }
        string CardCvn { get; set; }

        //powinien być IMHO również event Click.
    }
}
