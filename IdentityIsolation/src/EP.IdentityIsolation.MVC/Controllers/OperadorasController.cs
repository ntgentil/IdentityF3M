using Portal.Domain.Interface.Repository;
using System.Web.Mvc;

namespace EP.IdentityIsolation.MVC.Controllers
{
    public class OperadorasController : Controller
    {
        private readonly IOperadoraRepository _operadoraRepository;
        public OperadorasController(IOperadoraRepository operadoraRepository)
        {
            _operadoraRepository = operadoraRepository;
        }

        // GET: Operadoras
        public ActionResult Index()
        {
            var operadoras = _operadoraRepository.ObterTodos();
            return View(operadoras);
        }

        // GET: Operadoras/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Operadoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Operadoras/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Operadoras/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Operadoras/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Operadoras/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Operadoras/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
