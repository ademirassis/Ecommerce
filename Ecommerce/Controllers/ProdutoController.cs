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
            ViewBag.Produtos = _produtoDAO.Listar();
            ViewBag.DataHora = DateTime.Now;
            return View();
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
                ViewBag.Produto = _produtoDAO.BuscarProdutoPorId(id);
                //_produtoDAO.AlterarProduto(ViewBag.Produto);
                return View();
            }
            else
            {
                //Redirecionar para página de erro
            }
            return RedirectToAction("Alterar");
        }


        [HttpPost]
        public IActionResult Cadastrar(string txtNome, string txtDescricao, string txtPreco, string txtQuantidade)
        {
            Produto p = new Produto
            {
                Nome = txtNome,
                Descricao = txtDescricao,
                Preco = Convert.ToDouble(txtPreco),
                Quantidade = Convert.ToInt32(txtQuantidade)
            };
            _produtoDAO.Cadastrar(p);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(string txtId, string txtNome, string txtDescricao, string txtPreco, string txtQuantidade)
        {
            Produto p = _produtoDAO.BuscarProdutoPorId(Convert.ToInt32(txtId));

            p.Nome = txtNome;
            p.Descricao = txtDescricao;
            p.Preco = Convert.ToDouble(txtPreco);
            p.Quantidade = Convert.ToInt32(txtQuantidade);

            _produtoDAO.AlterarProduto(p);

            return RedirectToAction("Index");
        }
    }
}