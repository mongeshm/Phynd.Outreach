using Phynd.Outreach.DataInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Phynd.Outreach.DataModels;
using System.Linq;

namespace Phynd.Outreach.DataMgr
{
    public class PhyndRepository : IPhyndRepository
    {
        private readonly PhyndContext _dbContext;

        public PhyndRepository(PhyndContext phyndContext)
        {
            _dbContext = phyndContext;
            _dbContext.Database.EnsureCreated();
        }

        public List<CampaignType> GetCampaignTypes()
        {
            return _dbContext.CampaignTypes.ToList() ;
        }
        
    }
}
