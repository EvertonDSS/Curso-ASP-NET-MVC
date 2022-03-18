using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            var pessoa = new Pessoa() {
                PessoaId = 1,
                Nome = "Everton David",
                Tipo = "Admin"
            };

            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.Nome = pessoa.Nome;
            //ViewBag.Tipo = pessoa.Tipo;

            return View(pessoa);

        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa) {
            

            return View(pessoa);
        }
    }
}