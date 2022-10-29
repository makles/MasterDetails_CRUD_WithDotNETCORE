using MasterDetails.Iinterface;
using MasterDetails.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasterDetails.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly IPucchase _pucchase;
        private readonly DatabaseCN _db;
        public PurchaseController(IPucchase pucchase, DatabaseCN db)
        {
            _pucchase=pucchase;
            _db=db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            PurchaseInfo purchaseInfo = new PurchaseInfo();
            purchaseInfo.PurchaseDetails.Add(new PurchaseDetails() { PurchaseDtlsId = 1 });
            return View(purchaseInfo);
        }

        [HttpPost]
        public IActionResult Create( PurchaseInfo purchaseInfo)
        {
            
            try
            {
                _pucchase.Create(purchaseInfo);
            }
            catch (Exception ex)
            {

                throw;
            }

          return  RedirectToAction(nameof(Index));
        }
    }
}
