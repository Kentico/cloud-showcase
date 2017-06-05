using System.Linq;

namespace RoadshowShowcase.Models
{
    public partial class Contentpage
    {
        public Project TopProject => Featuredproject.Cast<Project>().First();
    }
}
