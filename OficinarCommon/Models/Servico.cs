﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace OficinarCommon.Models;

public partial class Servico
{
    public int Id { get; set; }

    public string NomeServico { get; set; }

    public decimal PrecoHora { get; set; }

    public virtual ICollection<AgendamentoServico> AgendamentoServicos { get; set; } = new List<AgendamentoServico>();
}