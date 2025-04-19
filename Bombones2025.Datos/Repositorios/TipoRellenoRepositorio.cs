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

        public bool Existe(TipoRelleno tipoRelleno)
        {
            return tipoRelleno.TipoRellenoId == 0 ? tiposRellenos.Any(t => t.NombreTipoRelleno == tipoRelleno.NombreTipoRelleno) :
                tiposRellenos.Any(t => t.NombreTipoRelleno == tipoRelleno.NombreTipoRelleno && t.TipoRellenoId != tipoRelleno.TipoRellenoId);
        }

        public void Agregar(TipoRelleno tipoRelleno)
        {
            tipoRelleno.TipoRellenoId = SetearTipoDeRellenoId();
            tiposRellenos.Add(tipoRelleno);

            using (var escritor= new StreamWriter(ruta,true))//el TRUE indica que va agregar al final del archivo, no va a sobreescribirlo
            {
                string linea = ConstruirLinea(tipoRelleno);//construyo la linea
                escritor.WriteLine(linea);
            }
        }

        private string ConstruirLinea(TipoRelleno tipoRelleno)
        {
            return $"{tipoRelleno.TipoRellenoId}|{tipoRelleno.NombreTipoRelleno}";
        }

        private int SetearTipoDeRellenoId()
        {
            return tiposRellenos.Max(t => t.TipoRellenoId) + 1;//veo cual es el ID maximo y le sumo 1 para que sea correlativo.
        }

        public void Borrar(TipoRelleno tipoRelleno)//aca le cambio el nombre de tipoRellenoBorrar por tipoRelleno
        {//si no encuentra un TIPO DE RELLENO con ese nombre devuelve un null por eso el ?. El First me trae el primero que trae la condicion que especifica
            TipoRelleno? tipoRellenoBorrar = tiposRellenos.FirstOrDefault(t => t.NombreTipoRelleno == tipoRelleno.NombreTipoRelleno);
            if (tipoRellenoBorrar is null)
            {
                return;
            }
            tiposRellenos.Remove(tipoRellenoBorrar);//RECORDATORIO, CUANDO EL OBJETO ES PLURAL ES DE LA LIST*****
            var registros = tiposRellenos.Select(t => ConstruirLinea(t)).ToArray();//convierte todos los objetos que quedan en la lista a líneas de texto
            File.WriteAllLines(ruta,registros);
        }
    }
}
