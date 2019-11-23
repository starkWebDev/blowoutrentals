﻿using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlowOut.DAL
{
    public class BlowOutContext : DbContext
    {
        public BlowOutContext() : base("BlowOutContext")
        {

        }

        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}