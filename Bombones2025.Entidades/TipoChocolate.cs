using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Entidades
{
    public class TipoChocolate
    {
        public int TipoChocolateId { get; set; }

        public string NombreTipoChocolate { get; set; } = null!;

        public override string ToString()
        {
            return $"{NombreTipoChocolate}";
        }
    }
}
