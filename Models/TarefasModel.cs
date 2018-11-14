using System;

namespace Senai.Projeto.Tarefas.Model {
    public class TarefasModels {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}