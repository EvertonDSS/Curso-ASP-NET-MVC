using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
       
        public ActionResult Index()
        {
            var usuario = new Usuario();
            
            return View(usuario);
        }
        public ActionResult Index(Usuario usuario) {

        }
    }
}