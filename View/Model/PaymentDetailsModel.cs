using System;
using System.Collections.Generic;
using View.Model;

namespace Presenters
{
    public class PaymentDetailsModel: IPaymentDetailsModel
    {
        //emulacja bazy
        public string Name, Surname, CardNumber, CardType, CardCvn, CardExpiry;
        public static List<PaymentDetailsModel> lista;

        static PaymentDetailsModel()
        {
            lista = new List<PaymentDetailsModel>();
            lista.Add(new PaymentDetailsModel { Name = "Imię", Surname = "Nazwisko", CardNumber = "1234 5678 9112 3456", CardCvn = "111", CardExpiry = "10/10", CardType = "Visa" });
            lista.Add(new PaymentDetailsModel { Name = "Imię2", Surname = "Nazwisko2", CardNumber = "2222 5678 9112 3456", CardCvn = "222", CardExpiry = "11/11", CardType = "Mastercard" });

        }


        //właściwe
        public bool StorePaymentsDetail(Tuple<string, string, string, string, string, string> PaymentDetailsList)
        {
            lista.Add(new PaymentDetailsModel { Name = PaymentDetailsList.Item1,
                                                Surname = PaymentDetailsList.Item2,
                                                CardNumber = PaymentDetailsList.Item3,
                                                CardCvn = PaymentDetailsList.Item4,
                                                CardExpiry = PaymentDetailsList.Item5,
                                                CardType = PaymentDetailsList.Item6
            });
            return true;
        }
    }
}