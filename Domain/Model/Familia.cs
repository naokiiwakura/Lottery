using Domain.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Familia : EntityBase
    {
        public List<Pessoa> Pessoas { get; set; }
        public List<Renda> Rendas { get; set; }
        public string Status { get; set; }
    }
}