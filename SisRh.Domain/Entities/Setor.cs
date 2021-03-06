﻿using SisRh.Domain.Core.Entities;
using System.Collections.Generic;

namespace SisRh.Domain.Entities
{
    public class Setor : Entity
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual IEnumerable<Empregado> Empregados { get; set; }

        public string SiglaNome
        {
            get
            {
                return Sigla + " - " + Nome;
            }
        }
    }
}
