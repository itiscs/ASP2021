using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClientSecond.Models;
using WebApiClientSecond.Services;

namespace WebApiClientSecond.Controllers
{
    public class TodosController : Controller
    {

        MyApiService serv = new MyApiService();
        // GET: TodosController
        

        public async Task<ActionResult> Index()
        {
            return View(await serv.GetTodos());
        }

        // GET: Users/Details/5
        public async Task<ActionResult> Details(int id)
        {

            return View(await serv.GetTodoByID(id));
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Name", "IsComplete")] ToDo todo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await serv.AddUser(todo);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TodosController/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todo = await serv.GetTodoByID(Convert.ToInt64(id));
            if (todo == null)
            {
                return NotFound();
            }
            return View(todo);
        }

        // POST: TodosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind("Id,Name,IsComplete")] ToDo todo)
        {
            if (id != todo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await serv.EditUser(id, todo);
                return RedirectToAction(nameof(Index));
            }
            return View(todo);
        }

        // GET: TodosController/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todo = await serv.GetTodoByID(Convert.ToInt64(id));
            if (todo == null)
            {
                return NotFound();
            }
            return View(todo);
        }

        // POST: TodosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            await serv.DeleteUser(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
