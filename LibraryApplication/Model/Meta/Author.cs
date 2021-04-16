﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.Model.Meta
{
    public class Author : Entity, INamed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int? Id { get; set; }

        public override DateTime CreatedAt { get; set; }

        [Reactive] public override DateTime UpdatedAt { get; set; }

        [Reactive]
        [Required, Index(IsUnique = true), Column(TypeName = "VARCHAR"), MaxLength(256)]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}