using System;
using Microsoft.EntityFrameworkCore;
using Phynd.Outreach.DataModels;
namespace Phynd.Outreach.DataMgr
{
    public class PhyndContext : DbContext
    {
        public PhyndContext(DbContextOptions<PhyndContext> options)
        : base(options)
        { }
        public DbSet<CampaignType> CampaignTypes { get; set; }

    }
}
