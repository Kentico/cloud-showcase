using KenticoCloud.Delivery;
using Microsoft.AspNetCore.Mvc;

namespace RoadshowShowcase.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(IDeliveryClient deliveryClient)
        {
            DeliveryClient = deliveryClient;
        }

        protected IDeliveryClient DeliveryClient { get; }
    }
}
