using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Googlemaps.Models
{
    public class GoogleMapContext:DbContext
    {
        public GoogleMapContext():base("name=ConString")
        {

        }
        public DbSet<GoogleMap> GoogleMaps { get; set; }
    }
}