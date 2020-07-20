using brg.Models.Enums;
using System.Collections.Generic;


namespace brg.Models
{
    public class Habilidade
    {
        public int Id { get; set; }
        public TipoHabilidade Tipo { get; set; }
        public string Nome { get; set; }
        public ICollection<Trilha> Trilhas { get; set; } = new List<Trilha>();

        public Habilidade()
        {

        }

        public Habilidade(int id, TipoHabilidade tipo, string nome)
        {
            Id = id;
            Tipo = tipo;
            Nome = nome;
        }
    }
}
