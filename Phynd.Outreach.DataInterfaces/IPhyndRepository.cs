using Phynd.Outreach.DataModels;
using System.Collections.Generic;

namespace Phynd.Outreach.DataInterfaces
{
    public interface IPhyndRepository
    {
        List<CampaignType> GetCampaignTypes();
    }
}
