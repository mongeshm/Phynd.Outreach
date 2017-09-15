using Phynd.Outreach.DataModels;
using System;
using System.Collections.Generic;

namespace Phynd.Outreach.DataInterfaces
{
    public interface IPhyndRepository : IDisposable
    {
        List<CampaignType> GetCampaignTypes();
    }
}
