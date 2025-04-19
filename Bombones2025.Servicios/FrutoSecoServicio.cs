using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios
{
    public class FrutoSecoServicio
    {
        private readonly FrutoSecoRepositorio _frutoSecoRepositorio = null!;
        public FrutoSecoServicio(string ruta)
        {
            _frutoSecoRepositorio=new FrutoSecoRepositorio(ruta);
        }

        public void Borrar(FrutoSeco frutoSecoBorrar)
        {
            _frutoSecoRepositorio.Borrar(frutoSecoBorrar);
        }

        public bool Existe(FrutoSeco frutoSeco)
        {
            return _frutoSecoRepositorio.Existe(frutoSeco);
        }

        public List<FrutoSeco> GetFrutoSecos()
        {
            return _frutoSecoRepositorio.GetFrutoSecos();
        }

        public void Guardar(FrutoSeco frutoSeco)
        {
            if (frutoSeco.FrutoSecoId==0)//si el id es 0 quiere decir que no tiene id por lo que es nuevo entonces se agrega
            {
                _frutoSecoRepositorio.Agregar(frutoSeco);
            }
            else//si no es 0 es porque existe por lo que hay que editarlo
            {
                _frutoSecoRepositorio.Editar(frutoSeco);
            }
        }
    }
}
