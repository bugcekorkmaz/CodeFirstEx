using CodeFirstEx.Models;
using CodeFirstEx.Models.Context;
using CodeFirstEx.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEx.Controllers
{
    public class StudentController : Controller
    {
        ProjectContext projectContext = new ProjectContext(); 
       
        // GET: StudentController
        public ActionResult Index()
        {
            return View(projectContext.Students.ToList());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            Student student = projectContext.Students.Where(p => p.Id == id).FirstOrDefault();
            return View(student);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                projectContext.Add(student);
                projectContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            Student student = projectContext.Students.Where(p => p.Id == id).FirstOrDefault();
            return View(student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            try
            {
                projectContext.Students.Update(student);
                projectContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var deger = projectContext.Students.Find(id);
                projectContext.Students.Remove(deger);
                projectContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
