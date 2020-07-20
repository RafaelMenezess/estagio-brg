using System;
using BRG.Models;



namespace brg.Models
{
    public class Trilha
    {
        public int Id { get; set; }
        public DateTime Prazo { get; set; }
        public Colaborador Colaborador { get; set; }
        public Habilidade Habilidade { get; set; }
        public int ColaboradorId { get; set; }
        public int HabilidadeId { get; set; }

        public Trilha()
        {

        }

        public Trilha(int id, DateTime prazo, Colaborador colaborador, Habilidade habilidade)
        {
            Id = id;
            Prazo = prazo;
            Colaborador = colaborador;
            Habilidade = habilidade;
        }

    }
}
