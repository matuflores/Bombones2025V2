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

        public bool Existe(FrutoSeco frutoSeco)
        {
            return frutoSeco.FrutoSecoId == 0 ? frutosSecos.Any(f => f.NombreFrutoSeco == frutoSeco.NombreFrutoSeco) :
                frutosSecos.Any(f => f.NombreFrutoSeco == frutoSeco.NombreFrutoSeco && f.FrutoSecoId != frutoSeco.FrutoSecoId);
        }//ahi me fijo si el id es cero tengo que ver si no hay un pais con el mismo nombre y si el id es distinto de cero me fijo si en la lista no tengo ese pais con otro ID

        public void Agregar(FrutoSeco frutoSeco)
        {
            frutoSeco.FrutoSecoId = SetearFrutoSecoId();
            frutosSecos.Add(frutoSeco);

            using (var escritor = new StreamWriter(ruta,true))
            {
                string linea = ConstruirLinea(frutoSeco);
                escritor.WriteLine(linea);
            }
        }

        private string ConstruirLinea(FrutoSeco frutoSeco)
        {
            return $"{frutoSeco.FrutoSecoId}|{frutoSeco.NombreFrutoSeco}";
        }

        private int SetearFrutoSecoId()//con este metodo asigno el ID
        {
            return frutosSecos.Max(f => f.FrutoSecoId) + 1;
        }

        public void Editar(FrutoSeco frutoSeco)
        {
            var frutoSecoEditado = frutosSecos.FirstOrDefault(f => f.FrutoSecoId == frutoSeco.FrutoSecoId);
            if (frutoSecoEditado is null)
            {
                return;

            }
            frutoSecoEditado.NombreFrutoSeco = frutoSeco.NombreFrutoSeco;
            var registros = frutosSecos.Select(f => ConstruirLinea(f)).ToArray();//en select es un metodo de LINQ me permite hacer una proyeccion del objeto que estoy trabajando
            File.WriteAllLines(ruta, registros);
        }
    }
}
