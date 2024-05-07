using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VitrineVirtual.Data;
using VitrineVirtual.Model;

namespace VitrineVirtual.Portal.Core.Controllers
{
    [DbContext(typeof(VitrineVirtualDBContext))]
    public class CadastroProdutoLojaController : Controller
    {
        private readonly VitrineVirtualDBContext db;

        public CadastroProdutoLojaController(VitrineVirtualDBContext contexto)
        {
            db = contexto;
        }

        public IActionResult Index()
        {
            // TODO: Pegar usuário cliente campo texto login, checar empresa usuário pertence e gravar cookie
            // Também pode usar redis de banco
            var listaProdutos = db.CadastroProdutoLoja;
            return View(listaProdutos);
        }

        /// <summary>
        /// Método resposável de filtrar por produto.
        /// </summary>
        /// <param name="pesquisa"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FiltrarPorNome(string pesquisa)
        {
            try
            {
                var produtoSelecionado = db.CadastroProdutoLoja.Where(a => a.Nome_Produto.Contains(pesquisa)).OrderBy(a => a.Nome_Produto).ToList();
                return View(produtoSelecionado);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return RedirectToAction("Index");
            }

        }

        //GET: CADASTRO_PRODUTO_LOJA/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult(400);
            }

            Cadastro_Produto_Loja cadastro_Produto_Loja = db.CadastroProdutoLoja.Find(id);
            cadastro_Produto_Loja.FilePath = db.CadastroProdutoLoja.Find(id).FilePath;

            if (cadastro_Produto_Loja == null)
            {
                return new StatusCodeResult(400);
            }
            return View(cadastro_Produto_Loja);
        }

        // GET: CADASTRO_PRODUTO_LOJA/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: CADASTRO_PRODUTO_LOJA/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cadastro_Produto_Loja cadastro_Produto_Loja, IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (upload != null && upload.Length > 0)
                    {
                        var foto = new FilePath
                        {
                            Nome_Arquivo = Guid.NewGuid().ToString() + Path.GetExtension(upload.FileName),
                            Tipo_Arquivo = Path.GetExtension(upload.FileName)
                        };
                        var caminhoUpload = Path.Combine(Directory.GetCurrentDirectory(), "~/images/uploads", foto.Nome_Arquivo);
                        foto.Caminho_Arquivo = caminhoUpload;
                        using (var stream = new FileStream(caminhoUpload, FileMode.Create))
                        {
                            upload.CopyTo(stream);
                        }
                        cadastro_Produto_Loja.FilePath = new List<FilePath>();
                        cadastro_Produto_Loja.FilePath.Add(foto);

                    }
                    db.CadastroProdutoLoja.Add(cadastro_Produto_Loja);
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
                catch (Exception ex)
                {
                    var result = ex.InnerException.ToString();
                    Log.Error(ex.Message);
                    return RedirectToAction("Index");
                }
            }

            return View(cadastro_Produto_Loja);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult(400);
            }
            Cadastro_Produto_Loja cadastro_Produto_Loja = db.CadastroProdutoLoja.Find(id);
            if (cadastro_Produto_Loja == null)
            {
                return new StatusCodeResult(500);
            }
            return View(cadastro_Produto_Loja);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, IFormFile upload)
        {
            if (id == null)
            {
                return new StatusCodeResult(500);
            }
            var cadProdLojaToUpdate = db.CadastroProdutoLoja.Find(id);
            try
            {
                if (upload != null && upload.Length > 0)
                {
                    var foto = new FilePath
                    {
                        Nome_Arquivo = Guid.NewGuid().ToString() + Path.GetExtension(upload.FileName),
                        Tipo_Arquivo = Path.GetExtension(upload.FileName)
                    };
                    var caminhoUpload = Path.Combine(Directory.GetCurrentDirectory(), "~/images/uploads", foto.Nome_Arquivo);
                    foto.Caminho_Arquivo = caminhoUpload;
                    cadProdLojaToUpdate.FilePath = new List<FilePath> { foto };
                    using (var stream = new FileStream(caminhoUpload, FileMode.Create))
                    {
                        upload.CopyTo(stream);
                    }
                    //upload. CopyTo(foto.Caminho_Arquivo);
                }

                db.Entry(cadProdLojaToUpdate).State = EntityState.Modified;
                db.SaveChanges();
                Log.Info("Registro alterado com sucesso");
                return View(cadProdLojaToUpdate);

            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                Cadastro_Produto_Loja cadastro_Produto_Loja = db.CadastroProdutoLoja.Find(id);
                var caminhoArquivo = db.FilePath.Where(x => x.ID_Cadastro_Prod_Loja == id).ToList();
                if (caminhoArquivo.Count > 0)
                {
                    for (int i = 0; i < caminhoArquivo.Count; i++)
                    {
                        if (caminhoArquivo[i].Caminho_Arquivo != null)
                            System.IO.File.Delete(caminhoArquivo[i].Caminho_Arquivo);

                        db.FilePath.Remove(caminhoArquivo[i]);
                    }
                }

                db.CadastroProdutoLoja.Remove(cadastro_Produto_Loja);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Log.Info(ex.Message);
                return View("Index");
            }
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