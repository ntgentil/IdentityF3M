using Portal.Business;
using Portal.Domain.Entities;
using System.Net;
using System.Web.Mvc;

namespace EP.IdentityIsolation.MVC.Controllers
{
    [Authorize]
    public class OperadorasController : Controller
    {
        private OperadoraBussiness _operadoraBussiness;

        public OperadorasController()
        {
            _operadoraBussiness = new OperadoraBussiness();
        }

        public ActionResult Index()
        {
            return View(_operadoraBussiness.GetOperadoras());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operadora operadora = _operadoraBussiness.Get(id);
            if (operadora == null)
            {
                return HttpNotFound();
            }
            return View(operadora);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OperadoraID,Nome,Descricao,ImagemID,TipoOperadoraID")] Operadora operadora)
        {
            if (ModelState.IsValid)
            {
                _operadoraBussiness.AdicionarOperadora(operadora);
                return RedirectToAction("Index");
            }

            return View(operadora);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operadora operadora = _operadoraBussiness.Get(id);
            if (operadora == null)
            {
                return HttpNotFound();
            }
            return View(operadora);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Operadora operadora)
        {
            if (ModelState.IsValid)
            {
                _operadoraBussiness.AlterarOperadora(operadora);
                return RedirectToAction("Index");
            }
            return View(operadora);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operadora operadora = _operadoraBussiness.Get(id);
            if (operadora == null)
            {
                return HttpNotFound();
            }
            return View(operadora);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _operadoraBussiness.DeleteOperadora(id);

            return RedirectToAction("Index");
        }

    }
}
