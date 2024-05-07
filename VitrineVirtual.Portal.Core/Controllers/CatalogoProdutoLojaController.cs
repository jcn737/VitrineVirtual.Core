using Microsoft.AspNetCore.Mvc;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using VitrineVirtual.Data;
using VitrineVirtual.Model;

namespace VitrineVirtual.WEB.Controllers
{
    public class CatalogoProdutoLojaController : Controller
    {
        private VitrineVirtualDBContext db;

        // GET: Catalogo_Produto_Loja
        public ActionResult Index()
        {
            // TODO: Pegar usuário cliente campo texto login, checar empresa usuário pertence e gravar cookie
            // Também pode usar redis de banco
            var listaProdutos = db.CadastroProdutoLoja.ToList();
            return View(listaProdutos);
        }

        // GET: Catalogo_Produto_Loja/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult(400);
            }
            Cadastro_Produto_Loja catalogo_Produto_Loja = db.CadastroProdutoLoja.Find(id);
            if (catalogo_Produto_Loja == null)
            {
                return new StatusCodeResult(500);
            }
            return View(catalogo_Produto_Loja);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
