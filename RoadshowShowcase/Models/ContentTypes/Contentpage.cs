// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace RoadshowShowcase.Models
{
    public partial class Contentpage
    {
        public string Title { get; set; }
        public IEnumerable<Asset> Headerimage { get; set; }
        public string Content { get; set; }
        public IEnumerable<object> Featuredproject { get; set; }
        public string Footer { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}