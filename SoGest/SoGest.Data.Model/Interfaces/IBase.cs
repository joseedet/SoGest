﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoGest.Data.Model.Interfaces
{
    public interface IBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public bool Activo { get; set; }

    }
}