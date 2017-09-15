using Phynd.Outreach.BusinessInterfaces;
using Phynd.Outreach.BusinessMgr.Extension;
using Phynd.Outreach.DataInterfaces;
using System.Collections.Generic;

namespace Phynd.Outreach.BusinessMgr
{
    public class CampaignManager : ICampaignManager
    {
        private readonly IPhyndRepository _phyndRepository;
        public CampaignManager(IPhyndRepository phyndRepository)
        {
            _phyndRepository = phyndRepository;
        }
        public List<CampaignTypeDTO> GetCampaignTypes()
        {
            return _phyndRepository.GetCampaignTypes().ToDTO();
        }
    }
}
