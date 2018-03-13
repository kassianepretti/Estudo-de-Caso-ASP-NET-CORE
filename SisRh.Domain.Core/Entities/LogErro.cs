using System;

namespace SisRh.Domain.Core.Entities
{
    public class LogErro : Entity
    {
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string CodUsuario { get; set; }

        public override string ToString()
        {
            return string.Format(Properties.Resources.MSG_ERROR, this.Codigo.ToString());
        }
    }
}
