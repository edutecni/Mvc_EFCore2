using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_EFCore2.Models;

namespace Mvc_EFCore2.Controllers
{
    public class TesteController : Controller
    {
        private AlunoContext _context;

        public TesteController(AlunoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var alunos = _context.Alunos.ToList();
            return View(alunos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("AlunoId, Nome, Sexo, Email, Nascimento, Foto, Texto")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(aluno);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = _context.Alunos.SingleOrDefault(a => a.AlunoId == id);

            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, [Bind("AlunoId, Nome, Sexo, Email, Nascimento, Foto, Texto")] Aluno aluno)
        {
            if (id == null || id != aluno.AlunoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluno);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {

                    if (!AlunoExists(aluno.AlunoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(aluno);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = _context.Alunos.SingleOrDefault(a => a.AlunoId == id);

            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = _context.Alunos.SingleOrDefault(a => a.AlunoId == id);

            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id, Aluno _aluno)
        {
            if (id == null || id != _aluno.AlunoId)
            {
                return NotFound();
            }

            var aluno = _context.Alunos.SingleOrDefault(a => a.AlunoId == _aluno.AlunoId);
            if (aluno == null)
            {
                return NotFound();
            }

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }

        private bool AlunoExists(int id)
        {
            return _context.Alunos.Any(a => a.AlunoId == id);
        }
    }
}