using System;

namespace CoreMvc.Models
{
    public class Instituto
    {
        protected Instituto() => this.Id = Guid.NewGuid();

        public Instituto(string nome)
            : this() => this.Nome = nome;

        public Guid Id { get; private set; }

        public string Nome { get; protected set; }

        public string Descricao { get; set; }

        public DateTime CriadoEm { get; protected set; }

        public DateTime AlteradoEm { get; protected set; }
    }
}