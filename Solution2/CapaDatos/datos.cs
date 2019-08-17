using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidad;

namespace CapaDatos
{
    public class datos
    {
        public int login(entidad obj)
        {

            int n;
            string user, pass;
            user = obj.usuario;
            pass = obj.pasword;
            if (user == "alumno")
            {
                if (pass == "123456")
                {
                    n = 1;
                }
                else
                {
                    n = 2;
                }

            }
            else
            {
                n = 2;
            }
            return n;

        }
    }
}
