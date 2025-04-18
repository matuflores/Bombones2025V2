using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Datos.Repositorios
{
    public class TipoRellenoRepositorio//public
    {
        private List<TipoRelleno> tiposRellenos = new();
        private readonly string ruta = null!;

        public TipoRellenoRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
        }

        private void LeerDatos()
        {
            if (!File.Exists(ruta))//si no tengo un archivo no retorna nada
            {
                return;
            }
            var registros = File.ReadAllLines(ruta);//aca si el archivo exite, lee todo el archivo y lu guarda en un array(colección de elementos que se almacenan en posiciones contiguas de memoria) de string
            //recorro los registros que estan en el array
            foreach (var registro in registros)
            {
                TipoRelleno tipoRelleno = ConstruirTipoRelleno(registro);
                tiposRellenos.Add(tipoRelleno);//agrego el tipo de relleno que construi
            }
        }

        private TipoRelleno ConstruirTipoRelleno(string registro)
        {
            throw new NotImplementedException();
        }
    }
}
