using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios
{
    public class TipoRellenoServicio
    {
        private readonly TipoRellenoRepositorio _tipoRellenoRepositorio = null!;

        public TipoRellenoServicio(string ruta)
        {
            _tipoRellenoRepositorio = new TipoRellenoRepositorio(ruta);
        }

        public List<TipoRelleno> GetTipoRellenos()
        {
            return _tipoRellenoRepositorio.GetTipoRellenos();
        }
    }
}
