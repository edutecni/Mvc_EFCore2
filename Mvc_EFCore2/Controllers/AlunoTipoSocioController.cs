using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_EFCore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_EFCore2.Controllers
{
    public class AlunoTipoSocioController : Controller
    {
        private AlunoContext contexto;

        public AlunoTipoSocioController(AlunoContext _alunoContext)
        {
            contexto = _alunoContext;
        }

        public IActionResult Index()
        {
            var infoAluno = contexto.Alunos.Include(tp => tp.TipoSocio);
            return View(infoAluno);
        }
    }
}
