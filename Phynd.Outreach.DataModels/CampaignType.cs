using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Phynd.Outreach.DataModels
{
    [Table("ProviderOutreach.CampaignTypes")]
    public class CampaignType
    {
        public int CampaignTypeId { get; set; }
        public string CampaingTypeName { get; set; }

        [ConcurrencyCheck]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime TimeStamp { get; set; }
    }
}
