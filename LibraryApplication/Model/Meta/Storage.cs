﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReactiveUI;

namespace LibraryApplication.Model.Meta
{
    public class Storage : ReactiveObject, IAuditable, INamed, IIdentified
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [Required, Index(IsUnique = true), Column(TypeName = "VARCHAR"), MaxLength(256)]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}