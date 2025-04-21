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

        public List<TipoChocolate> GetTipoChocolate()
        {
            return tiposChocolates;
        }

        public bool Existe(TipoChocolate tipoChocolate)
        {
            return tipoChocolate.TipoChocolateId == 0 ? tiposChocolates.Any(tc => tc.NombreTipoChocolate == tipoChocolate.NombreTipoChocolate) :
                tiposChocolates.Any(tc => tc.NombreTipoChocolate == tipoChocolate.NombreTipoChocolate && tc.TipoChocolateId != tipoChocolate.TipoChocolateId);
        }

        public void Agregar(TipoChocolate tipoChocolate)
        {
            tipoChocolate.TipoChocolateId = SetearTipoChocolateId();
            tiposChocolates.Add(tipoChocolate);

            using (var escritor = new StreamWriter(ruta, true)) 
            {
                string linea = ConstruirLinea(tipoChocolate);
                escritor.WriteLine(linea);
            }
        }

        private string ConstruirLinea(TipoChocolate tipoChocolate)
        {
            return $"{tipoChocolate.TipoChocolateId}|{tipoChocolate.NombreTipoChocolate}";
        }

        private int SetearTipoChocolateId()
        {
            return tiposChocolates.Max(tc => tc.TipoChocolateId) + 1;
        }

        public void Borrar(TipoChocolate tipoChocolate)//remplazo nombre del objeto
        {
            TipoChocolate? tipoChocolateBorrar = tiposChocolates.FirstOrDefault(tc => tc.NombreTipoChocolate == tipoChocolate.NombreTipoChocolate);
            if (tipoChocolateBorrar is null)
            {
                return;
            }
            tiposChocolates.Remove(tipoChocolateBorrar);
            var registros = tiposChocolates.Select(tc => ConstruirLinea(tc)).ToArray();
            File.WriteAllLines(ruta, registros);
        }
    }
}
