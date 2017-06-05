using System;
using KenticoCloud.Delivery;

namespace RoadshowShowcase.Models
{
    public class CustomTypeProvider : ICodeFirstTypeProvider
    {
        public Type GetType(string contentType)
        {
            switch (contentType)
            {
                case "contentpage":
                    return typeof(Contentpage);
                case "project":
                    return typeof(Project);
                default:
                    return null;
            }
        }
    }
}