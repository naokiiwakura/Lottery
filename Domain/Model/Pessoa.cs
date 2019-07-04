using Domain.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Pessoa : EntityBase
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}