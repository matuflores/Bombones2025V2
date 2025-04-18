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
            var campo=registro.Split('|');//separo al registro en donde encuentre la condicion indicada
            var tipoRellenoId = int.Parse(campo[0]);//asigno el valor del campo 0 al atributo tipoRellenoId (como se que es un entero tengo que convert)
            var nombreTipoRelleno = campo[1];
            return new TipoRelleno()//este metodo me va a devolver un nuevo tipo de relleno con su id y su nombre
            {
                NombreTipoRelleno = nombreTipoRelleno,
                TipoRellenoId=tipoRellenoId
            };
        }

        public List<TipoRelleno> GetTipoRellenos()
        {
            return tiposRellenos;
        }
    }
}
