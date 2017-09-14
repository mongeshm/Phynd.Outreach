using Phynd.Outreach.BusinessInterfaces;
using Phynd.Outreach.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phynd.Outreach.BusinessMgr.Extension
{
    public static class ExtensionMethod
    {
        public static CampaignTypeDTO ToDTO(this CampaignType campaignType)
        {
            if (campaignType == null) return null;
            return new CampaignTypeDTO()
            {
                CampaingTypeName = campaignType.CampaingTypeName
            };
        }

        public static List<CampaignTypeDTO> ToDTO(this List<CampaignType> lstCampaignType)
        {
            if (lstCampaignType == null) return null;
            return lstCampaignType.Select(ToDTO).ToList();
        }
    }
}
