using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.DAL;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;

        public ProdutoController(ProdutoDAO produtoDAO)
        {
            _produtoDAO = produtoDAO;
        }

        //Métodos dentro de um Controller são chamados de Actions
        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
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
                return View(_produtoDAO.BuscarProdutoPorId(id));
            }
            else
            {
                //Redirecionar para página de erro
            }
            return RedirectToAction("Alterar");
        }


        [HttpPost]
        public IActionResult Cadastrar(Produto p)
        {
            _produtoDAO.Cadastrar(p);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(Produto p)
        {
            _produtoDAO.AlterarProduto(p);
            return RedirectToAction("Index");
        }
    }
}