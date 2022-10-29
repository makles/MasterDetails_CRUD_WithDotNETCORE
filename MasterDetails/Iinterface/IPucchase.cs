using MasterDetails.Models;

namespace MasterDetails.Iinterface
{
    public interface IPucchase
    {
        public PurchaseInfo GetAll();
        public PurchaseInfo GetbyId(int id);
        public PurchaseInfo Create(PurchaseInfo purchaseInfo);
        public PurchaseInfo Update(PurchaseInfo purchaseInfo);
        public PurchaseInfo Delete(PurchaseInfo purchaseInfo);
    }
}
