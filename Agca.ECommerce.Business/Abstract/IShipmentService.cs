using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Abstract
{
    public interface IShipmentService
    {
        Shipment Get(int id);
        void Add(Shipment shipment);
        Shipment GetByOrderId(int orderId);
    }
}
