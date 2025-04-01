﻿using Bombones2025.Datos.Repositorios;
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

        public List<FrutoSeco> GetFrutoSecos()
        {
            return _frutoSecoRepositorio.GetFrutoSecos();
        }
    }
}
