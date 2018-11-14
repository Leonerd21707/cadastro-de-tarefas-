using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Projeto.Tarefas.Model;

namespace Senai.Projeto.Tarefas.Controllers {
    public class UsuarioController : Controller {
        [HttpGet]

        public ActionResult Cadastrar () {
            return View ();

        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
            UsuarioModels usuario = new UsuarioModels ();
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.DataCriacao = DateTime.Now;

            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                sw.WriteLine ($"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao}");

            }

            ViewBag.Mensagem = "Usuário Cadastrado";

            return RedirectToAction ("Index", "Login");
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModels usuario = new UsuarioModels ();
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];

            using (StreamReader sr = new StreamReader ("usuarios.csv")) {
                while (!sr.EndOfStream) {
                    string[] dados = sr.ReadLine ().Split (";");

                    if (dados[1] == usuario.Email && dados[2] == usuario.Senha) {

                    }
                }
            }

            return View ();
        }

    }
}