﻿using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Datos.Repositorios
{
    public class PaisRepositorio
    {
        //el atributo privado del repo donde se almacenan los paises
        private List<Pais> paises = new();
        private readonly string ruta = null!;
        public PaisRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
        }
        //el sammury sirve para documentar, tengo que apretar "///"
        /// <summary>
        /// Metodo para enviar la lista de paises a otra capa
        /// </summary>
        /// <returns></returns>
        public List<Pais> GetPais()
        {
            //return paises;
            return paises.OrderBy(p=>p.NombrePais).ToList(); // de esta forma enlisto los paises de manera ordenada por nombre
        }
       
        /// <summary>
        /// falta un metodo para leer los datos del archivo
        /// </summary>
        /// <param name="ruta">Se pasa el nombre del archivo</param>
        private void LeerDatos()//atributo void se usa cuando el metodo no devuelve ningun valor
        {
            if (!File.Exists(ruta))//si no tengo un archivo no retorna nada
            {
                return;
            }
            var registros=File.ReadAllLines(ruta);//aca si el archivo exite, lee todo el archivo y lu guarda en un array(colección de elementos que se almacenan en posiciones contiguas de memoria) de string
            //recorro los registros que estan en el array
            foreach (var registro in registros)
            {
                Pais pais=ConstruirPais(registro);
                paises.Add(pais);//agrego el pais que construi
            }
        }
        /// <summary>
        /// Metodo PRIVADO para obtener un pais
        /// </summary>
        /// <param name="registro">Recibe un string con los datos del pais separados por el |</param>
        /// <returns>Un Pais</returns>
        private Pais ConstruirPais(string registro)
        {
            var campos=registro.Split('|');//toma el registro que es un string y lo pone en otro vector
            var paisId=int.Parse(campos[0]);
            var nombrePais=campos[1];
            return new Pais()
            {
                NombrePais = nombrePais,
                PaisId = paisId,
            };
        }

        private int SetarPaisId()//retoma el pais con ID mmas alto y lo agrego consecutivo
        {
            return paises.Max(p=>p.PaisId)+1;
        }
        public void Agregar(Pais pais)
        {

            pais.PaisId = SetarPaisId();
            paises.Add(pais);// ahora lo tengo que agregar en el archivo
            if (File.Exists(ruta))
            {
                var registros = File.ReadAllText(ruta);
                if (!string.IsNullOrEmpty(registros)&& !registros.EndsWith(Environment.NewLine))
                {
                    File.WriteAllText(ruta, Environment.NewLine);
                }
            }
            using (var escritor = new StreamWriter(ruta, true))//el TRUE le indica el StreamWritter que debe agregar lo que le paso aca
            {//es decir no crear un archivo de nuevo, si no que lo agrega al final
                string linea = ConstruirLinea(pais);
                escritor.WriteLine(linea);
                //pruebasiseguardaenrepositorio
            }
        }

        private string ConstruirLinea(Pais pais)
        {
            return $"{pais.PaisId}|{pais.NombrePais}";
        }
    }
}
