using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TxnFlow.Data;
using TxnFlow.Implementations;
using TxnFlow.Interfaces.DataAccess;
using TxnFlow.Interfaces.Entities;

namespace TxnFlow.Controllers
{



    public class TxnFlowController : Controller
    {
        // GET: TxnFlow
        public ActionResult Index()
        {
            /*Get list of Person*/
            IDataRepositoryModel DRM = new DataRepositoryModel();
            return View(DRM.GetAllPeople());
        }
    }
}