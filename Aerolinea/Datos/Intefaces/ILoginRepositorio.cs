﻿using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Intefaces
{
    public interface ILoginRepositorio
    {
        Task<bool> ValidarUsuario(Login login);

    }
}
