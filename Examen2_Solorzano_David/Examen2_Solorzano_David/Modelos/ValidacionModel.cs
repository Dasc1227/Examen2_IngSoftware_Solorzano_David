using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2_Solorzano_David.Modelos
{
    public class ValidacionModel
    {
        public Boolean validarEntrada(string ingre)
        {
            if (ingre.Equals(""))
            {
                return false;
            }
            return true;
        }
    }
}
