using Domain.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Renda : EntityBase
    {
        public Pessoa Pessoa { get; set; }
        public int Valor { get; set; }
    }
}