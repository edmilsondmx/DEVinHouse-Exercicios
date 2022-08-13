﻿using System;
using System.Collections.Generic;

namespace PetsApplication.Api.Models
{
    public partial class Raca
    {
        public Raca()
        {
            Pets = new HashSet<Pet>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
