﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ecommerce.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            Usuario u = new Usuario();
            if (TempData["Endereco"] != null)
            {
                string resultado = TempData["Endereco"].ToString();
                Endereco endereco = JsonConvert.DeserializeObject<Endereco>(resultado);
                u.Endereco = endereco;
            }
            return View(u);
        }

        [HttpPost]
        public IActionResult BuscarCep(Usuario u)
        {
            string url = "http://viacep.com.br/ws/" + u.Endereco.Cep + "/json";

            WebClient client = new WebClient();

            TempData["Endereco"] = client.DownloadString(url);

            return RedirectToAction(nameof(Cadastrar));

            //string resultado = client.DownloadString(url);
            //Endereco endereco = JsonConvert.DeserializeObject<Endereco>(resultado);
            //Transportar dados entre IActions
            //TempData["Endereco"] = endereco;
            // return RedirectToAction("Cadastrar");
        }



    }
}