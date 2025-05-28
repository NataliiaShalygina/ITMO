using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


    public class SampleContext : DbContext
    {
        public SampleContext() : base("SemimarBD") { }
        public DbSet<GuestResponse> GuestResponses { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
