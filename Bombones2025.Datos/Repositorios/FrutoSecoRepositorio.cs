using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Datos.Repositorios
{
    public class FrutoSecoRepositorio
    {
        private List<FrutoSeco> frutosSecos = new();
        private readonly string ruta = null!;

        public FrutoSecoRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos(ruta);
        }

        public List<FrutoSeco> GetFrutoSecos()
        {
            return frutosSecos;
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
                FrutoSeco frutoSeco = ConstruirFrutoSeco(registro);
                frutosSecos.Add(frutoSeco);
            }
        }

        
        private FrutoSeco ConstruirFrutoSeco(string registro)
        {
            var campos=registro.Split('|');
            var frutoSecoId = int.Parse(campos[0]);
            var nombreFrutoSeco = campos[1];
            return new FrutoSeco()
            {
                NombreFrutoSeco = nombreFrutoSeco,
                FrutoSecoId = frutoSecoId,
            };
        }
    }
}
