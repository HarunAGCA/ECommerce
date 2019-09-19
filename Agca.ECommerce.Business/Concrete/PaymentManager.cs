using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        private IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public void Add(Payment payment)
        {
            _paymentDal.Add(payment);
        }

        public Payment Get(int id)
        {
            return _paymentDal.Get(p=>p.Id == id);
        }
    }
}
