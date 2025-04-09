using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;

namespace Bombones2025.Servicios
{
    public class PaisServicio//se encarga de manejar los repositorios,cambio nombre
    {
        private readonly PaisRepositorio _paisRepositorio = null!;

        public PaisServicio(string ruta)//cuando se instancia el pais servicio va a instanciar el repositorio
        {
            _paisRepositorio = new PaisRepositorio(ruta);
        }

        public void Borrar(Pais pais)
        {
            _paisRepositorio.Borrar(pais);
        }


        //hacerme de intermediario entre la capa de datos.
        public List<Pais> GetPaises()
        {
            return _paisRepositorio.GetPais();//los paises se los pide al repositorio.
        }

        public void Guardar(Pais pais)
        {
            _paisRepositorio.Agregar(pais);
        }
    }
}
