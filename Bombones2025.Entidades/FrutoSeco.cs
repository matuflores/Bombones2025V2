﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Entidades
{
    public class FrutoSeco//aca remplazo internal por public para poder trabajarlo
    {
        public int FrutoSecoId { get; set; }
        public string NombreFrutoSeco { get; set; } = null!;

        public override string ToString()
        {
            return $"{NombreFrutoSeco}";
        }

    }
}
