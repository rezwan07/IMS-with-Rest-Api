//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMS_with_Rest_Api.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double price { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore, XmlIgnore]
        public virtual Category Category { get; set; }
    }
}
