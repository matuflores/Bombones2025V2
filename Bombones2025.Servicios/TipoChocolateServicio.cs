using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;
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

        public bool Existe(TipoChocolate tipoChocolate)
        {
            return _tipoChocolateRepositorio.Existe(tipoChocolate);
        }

        public List<TipoChocolate> GetTipoCholates()
        {
            return _tipoChocolateRepositorio.GetTipoChocolate();
        }

        public void Guardar(TipoChocolate tipoChocolate)
        {
            if (tipoChocolate.TipoChocolateId==0)
            {
                _tipoChocolateRepositorio.Agregar(tipoChocolate);
            }
            else
            {
                //_tipoChocolateRepositorio.Editar(tipoChocolate);
            }
        }
    }
}
