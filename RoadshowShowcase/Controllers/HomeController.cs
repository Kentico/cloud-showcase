using RoadshowShowcase.Models;
using KenticoCloud.Delivery;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RoadshowShowcase.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IDeliveryClient deliveryClient) : base(deliveryClient)
        {
            
        }

        public async Task<ViewResult> Index()
        {
            HomeData data = new HomeData();

            // Get the Home ContentPage from Kentico Cloud
            var responseContent = await DeliveryClient.GetItemAsync<Contentpage>("home");
            data.Content = responseContent.Item;

            // Get the KenticoCloudProject items from Kentico Cloud
            var responseProjects = await DeliveryClient.GetItemsAsync<Project>(
                new EqualsFilter("system.type", "project"),
                new OrderParameter("elements.datesubmitted", SortOrder.Descending)
            );
            data.Projects = responseProjects.Items;

            return View(data);
        }
    }
}
