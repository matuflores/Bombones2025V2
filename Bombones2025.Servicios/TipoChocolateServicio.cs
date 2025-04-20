using Bombones2025.Datos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios
{
    public class TipoChocolateServicio
    {
        private readonly TipoChocolateRepositorio _tipoChocolateRepositorio = null!;

        public TipoChocolateServicio(string ruta)
        {
            _tipoChocolateRepositorio = new TipoChocolateRepositorio(ruta);
        }


    }
}
