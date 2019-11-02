using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        private readonly CategoriaDAO _categoriaDAO;

        public ProdutoController(ProdutoDAO produtoDAO, CategoriaDAO categoriaDAO)
        {
            _produtoDAO = produtoDAO;
            _categoriaDAO = categoriaDAO;
        }

        //Métodos dentro de um Controller são chamados de Actions
        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.ListarTodos());
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = new SelectList
                (_categoriaDAO.ListarTodos(), "CategoriaId", "Nome");
            return View();
        }

        public IActionResult Remover(int? id)
        {
            if (id != null)
            {
                _produtoDAO.RemoverProduto(id);
            }
            else
            {
                //Redirecionar para página de erro
            }
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(int? id)
        {
            
            if (id != null)
            {
                ViewBag.Categorias = new SelectList
                    (_categoriaDAO.ListarTodos(), "CategoriaId", "Nome");
                return View(_produtoDAO.BuscarPorId(id));
            }
            else
            {
                //Redirecionar para página de erro
            }
            return RedirectToAction("Alterar");
        }


        [HttpPost]
        public IActionResult Cadastrar(Produto p, int drpCategorias)
        {
            ViewBag.Categorias = new SelectList(_categoriaDAO.ListarTodos(), "CategoriaId", "Nome");
            if (ModelState.IsValid)
            {
                p.Categoria = _categoriaDAO.BuscarPorId(drpCategorias);

                if (_produtoDAO.Cadastrar(p))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Esse produto já existe!");
                return View(p);
            }
            return View(p);
        }

        [HttpPost]
        public IActionResult Alterar(Produto p)
        {
            _produtoDAO.AlterarProduto(p);
            return RedirectToAction("Index");
        }
    }
}