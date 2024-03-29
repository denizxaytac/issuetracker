﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IssueTracker.Models;

namespace IssueTracker.Data
{
    public class IssueTrackerContext : DbContext
    {
        public IssueTrackerContext (DbContextOptions<IssueTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<IssueTracker.Models.Project>? Project { get; set; }
        public DbSet<IssueTracker.Models.Issue>? Issue { get; set; }
        public DbSet<IssueTracker.Models.User>? User { get; set; }
        public DbSet<IssueTracker.Models.Comment>? Comment { get; set; }
    }
}
