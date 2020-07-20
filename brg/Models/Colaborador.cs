using System;
using brg.Models;
using System.Collections.Generic;

namespace BRG.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string Name { get; set; }
        public ICollection<Trilha> Trilhas { get; set; } = new List<Trilha>();

        public Colaborador()
        {

        }

        public Colaborador(int id, string cargo, string departamento, string name)
        {
            Id = id;
            Cargo = cargo;
            Departamento = departamento;
            Name = name;
        }
    }
}
