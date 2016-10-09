using HttpRequests.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HttpRequests.Context
{
    public class RequestContext : DbContext
    {
        public DbSet<RequestInformation> RequestInformation { get; set; }
        public DbSet<MovieHouse> MovieHouses { get; set; }
    }
}