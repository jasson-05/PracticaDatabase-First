﻿using System;
using System.Collections.Generic;

namespace Practica20250306.AppWebMVCDatabase_First.Models;

public partial class Departamento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }
}
