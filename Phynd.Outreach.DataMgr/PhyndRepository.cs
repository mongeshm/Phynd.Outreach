using Phynd.Outreach.DataInterfaces;
using System;
using System.Collections.Generic;
using Phynd.Outreach.DataModels;
using System.Linq;

namespace Phynd.Outreach.DataMgr
{
    public class PhyndRepository : IPhyndRepository
    {
        private PhyndContext _dbContext;

        public PhyndRepository(PhyndContext phyndContext)
        {
            _dbContext = phyndContext;
            _dbContext.Database.EnsureCreated();
        }

        public List<CampaignType> GetCampaignTypes()
        {

            try
            {
                var firstObject = _dbContext.CampaignTypes.SingleOrDefault(k => k.CampaignTypeId == 1);
                
                firstObject.CampaingTypeName = firstObject.CampaingTypeName + "test";
                _dbContext.SaveChanges();
                return _dbContext.CampaignTypes.ToList();

            }
            catch (Exception ex )
            {

            }
            return null;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (_dbContext != null)
                    {
                        _dbContext.Dispose();
                        _dbContext = null;
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~PhyndRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion



    }
}
