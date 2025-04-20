using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Datos.Repositorios
{
    public class TipoChocolateRepositorio
    {
        private List<TipoChocolate> tiposChocolates = new();
        private readonly string ruta = null!;

        public TipoChocolateRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos(ruta);
        }

        private void LeerDatos(string ruta)
        {
            if (!File.Exists(ruta))
            {
                return;
            }
            var registros=File.ReadAllLines(ruta);

            foreach (var registro in registros)
            {
                TipoChocolate tipoChocolate = ConstruirTipoChocolate(registro);
                tiposChocolates.Add(tipoChocolate);
            }
        }

        private TipoChocolate ConstruirTipoChocolate(string registro)
        {
            var campos=registro.Split('|');
            var tipoChocolateId=int.Parse(campos[0]);
            var nombreTipoChocolate = campos[1];
            return new TipoChocolate()
            {
                NombreTipoChocolate = nombreTipoChocolate,
                TipoChocolateId = tipoChocolateId,
            };
        }
    }
}
