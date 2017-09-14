using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Phynd.Outreach.BusinessInterfaces;
using Microsoft.Extensions.Configuration;

namespace Phynd.Outreach.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CampaignTypeController : Controller
    {
        private readonly ICampaignManager _ICampaignManager;
        IConfiguration _IConfiguration;

        public CampaignTypeController(ICampaignManager campaignManager, IConfiguration iConfiguration)
        {
            _ICampaignManager = campaignManager;
            _IConfiguration = iConfiguration;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<CampaignTypeDTO> Get()
        {
            return _ICampaignManager.GetCampaignTypes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return string.Empty;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
