using System;

namespace Senai.Projeto.Tarefas.Model {
    public class UsuarioModels {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}