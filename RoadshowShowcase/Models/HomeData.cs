using System.Collections.Generic;

namespace RoadshowShowcase.Models
{
    public class HomeData
    {
        public Contentpage Content { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}
