using System.Linq;
using TxnFlow.Data;
using TxnFlow.Interfaces.Data_Access;
using TxnFlow.Interfaces.Entities;
using TxnFlow.Logic.BusinessRules;
using TxnFlow.Logic.RuleSet;
using TxnFlow.ServiceLayer;

namespace TxnFlow.Controllers
{
    /// <summary>
    /// There are few ways things can be done here.
    /// 1. Use a Service Layer that orchestrates the actions. This is were you can use concrete objects can be used if need be.
    /// 2. Another option is to use Dependency Injection to control the actions and the concrete implementations
    /// 3. You can use a combination of both the above
    /// Not sure which pattern you are move comfortable with.
    /// </summary>

    public class TxnFlowController : Controller
    {
        // GET: TxnFlow
        public ActionResult Index()
        {
            /*Get list of Person*/
            IDataRepositoryModel DRM = new DataRepositoryModel();
            return View(DRM.GetAllPeople());
        }

        public ActionResult DeletePerson(int id)
        {
            //GEt the person
            //DI Container to get the PersonManager

            IDataRepositoryModel drm = new DataRepositoryModel();
            var person = drm.Find(id);
            var personManager = new PersonManager();
            var deletePersonRules = new DeletePersonRules();
            deletePersonRules.AddRule(new CanDeletePerson(person));
            personManager.DeletePerson(person, drm, deletePersonRules);
        }
    }
}