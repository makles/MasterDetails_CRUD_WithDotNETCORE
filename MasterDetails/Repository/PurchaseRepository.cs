using MasterDetails.Iinterface;
using MasterDetails.Models;

namespace MasterDetails.Repository
{
    public class PurchaseRepository : IPucchase
    {
        private readonly DatabaseCN _db;
        public PurchaseRepository(DatabaseCN db)
        {
            _db=db;
        }
       
        public PurchaseInfo Create(PurchaseInfo purchaseInfo)
        {
            try
            {
                _db.PurchaseInfos.Add(purchaseInfo);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return purchaseInfo;
        }

        public PurchaseInfo Delete(PurchaseInfo purchaseInfo)
        {
            throw new NotImplementedException();
        }

        public PurchaseInfo GetAll()
        {
            throw new NotImplementedException();
        }

        public PurchaseInfo GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public PurchaseInfo Update(PurchaseInfo purchaseInfo)
        {
            throw new NotImplementedException();
        }
    }
}
