﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public static class PatenteStringExtension
    {
        public const string patente_vieja = "^[A-Z]{3}[0-9]{3}$";
        public const string patente_mercosur = "^[A-Z]{2}[0-9]{3}[A-Z]{2}$";

        public static Patente ValidarPatente(this string codigo)
        {
            Patente patente;
            Regex rgx_v = new Regex(PatenteStringExtension.patente_vieja);
            Regex rgx_n = new Regex(PatenteStringExtension.patente_mercosur);
            if (rgx_v.IsMatch(codigo))
            {
                 patente = new Patente(codigo, Patente.Tipo.Vieja);
            }
            else if (rgx_n.IsMatch(codigo))
            {
                patente = new Patente(codigo, Patente.Tipo.Mercosur);
            }
            else
            {
                string error = string.Format("{0} no cumple el formato.", codigo);
                throw new PatenteInvalidException(error);
 
            }
            return patente;

        }

    }
}
