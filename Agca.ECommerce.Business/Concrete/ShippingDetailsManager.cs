using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Concrete
{
    public class ShippingDetailsManager : IShippingDetailsService
    {
        private IShippingDetailsDal _shippingDetailsDal;

        public ShippingDetailsManager(IShippingDetailsDal shippingDetailsDal)
        {
            _shippingDetailsDal = shippingDetailsDal;
        }

        public void Add(ShippingDetails shippingDetails)
        {
            _shippingDetailsDal.Add(shippingDetails);
        }

        public ShippingDetails Get(int shippingDetailsId)
        {
            return _shippingDetailsDal.Get(s => s.Id == shippingDetailsId);
        }
    }
}
