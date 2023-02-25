using Capitulo01.Data;
using Capitulo01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01.Controllers
{
    public class InstituicaoController : Controller
    {
        private readonly IESContext _context;

        public InstituicaoController(IESContext context)
        {
            _context = context;
        }

        //private static IList<Instituicao> instituicoes = new List<Instituicao>()
        //{
        //    new Instituicao()   
        //    {
        //        InstituicaoID = 1,
        //        Nome = "UniParaná",
        //        Endereco = "Paraná"
        //    },
        //    new Instituicao()
        //    {
        //        InstituicaoID = 2,
        //        Nome = "UniSanta",
        //        Endereco = "Santa Catarina"
        //    },
        //    new Instituicao()
        //    {
        //        InstituicaoID = 3,
        //        Nome = "UniSãoPaulo",
        //        Endereco = "São	Paulo"
        //    },
        //    new Instituicao()
        //    {
        //        InstituicaoID = 4,
        //        Nome = "UniSulgrandense",
        //        Endereco = "Rio	Grande do Sul"
        //    },
        //    new Instituicao()
        //    {
        //        InstituicaoID = 5,
        //        Nome = "UniCarioca",
        //        Endereco = "Rio	de Janeiro"
        //    }
        //};

        //// GET: Index
        //public IActionResult Index()
        //{
        //    return View(instituicoes.OrderBy(i => i.InstituicaoID));
        //}

        public async Task<IActionResult> Index()
        {
            return View(await _context.Instituicoes.OrderBy(c => c.InstituicaoID).ToListAsync());
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Instituicao instituicao)
        //{
            
        //    if (instituicoes.Count < 1)
        //    {
        //        instituicao.InstituicaoID = 1;
        //    }
        //    else
        //    {
        //        instituicao.InstituicaoID = instituicoes.Select(i => i.InstituicaoID).Max() + 1;
        //    }
        //    instituicoes.Add(instituicao);

        //    return RedirectToAction(nameof(Index));
        //}

        //public ActionResult Edit(long id)
        //{
        //    return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit (Instituicao instituicao)
        //{
        //    //instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
        //    //instituicoes.Add(instituicao);
        //    instituicoes[instituicoes.IndexOf(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First())] = instituicao;
        //    return RedirectToAction(nameof(Index));
        //}

        //public ActionResult Details(int id)
        //{
        //    return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        //}

        //public ActionResult Delete(int id)
        //{
        //    return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(Instituicao instituicao)
        //{
        //    instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
