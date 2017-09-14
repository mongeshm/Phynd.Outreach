using System;
using System.Collections.Generic;

namespace Phynd.Outreach.BusinessInterfaces
{
    public interface ICampaignManager
    {
        List<CampaignTypeDTO> GetCampaignTypes();
    }
}
