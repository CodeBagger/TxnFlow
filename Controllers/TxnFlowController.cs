using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TxnFlow.Interfaces.Data_Access;
using TxnFlow.Data;
using TxnFlow.Interfaces.Entities;
using TxnFlow.ServiceLayer;
using TxnFlow.Logic.RuleSet;
using TxnFlow.Interfaces.Business_Rules;
using TxnFlow.Logic.BusinessRules;

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

        public ActionResult AddPerson()
        {
            /*Get new Person template*/
            IDataRepositoryModel DRM = new DataRepositoryModel();
            return View(DRM.Add());
        }

        [HttpPost]
        public ActionResult AddPerson(PersonEntity P)
        {
            /*Add Person*/
            IDataRepositoryModel DRM = new DataRepositoryModel();
            var personManager = new PersonManager();
            var savePersonRules = new SavePersonRules();
            savePersonRules.AddRule(new CanSavePerson(P));
            personManager.AddPerson(P, DRM, savePersonRules);
            return View(DRM.Add());
        }

        //public ActionResult DeletePerson(int id)
        //{
        //    //GEt the person
        //    //DI Container to get the PersonManager

        //    //IDataRepositoryModel drm = new DataRepositoryModel();
        //    //var person = drm.Find(id);
        //    //var personManager = new PersonManager();
        //    //var deletePersonRules = new DeletePersonRules();
        //    //deletePersonRules.AddRule(new CanDeletePerson(person));
        //    //personManager.DeletePerson(person, drm, deletePersonRules);
        //    //return View();
        //}

    }
}