using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Concrete
{
    public class ShipmentManager : IShipmentService
    {
        private IShipmentDal _shipmentDal;

        public ShipmentManager(IShipmentDal shipmentDal)
        {
            _shipmentDal = shipmentDal;
        }

        public void Add(Shipment shipment)
        {
            _shipmentDal.Add(shipment);
        }

        public Shipment Get(int id)
        {
            return _shipmentDal.Get(s=>s.Id == id);
        }

        public Shipment GetByOrderId(int orderId)
        {
            return _shipmentDal.Get(s => s.OrderId == orderId);
        }
    }
}
