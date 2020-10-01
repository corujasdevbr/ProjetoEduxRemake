﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjetoEduxRemake.Domains
{
    public class ProfessorTurma
    {
        [Key]
        public Guid IdProfessorTurma { get; set; }
        public string Descricao { get; set; }
        public Guid IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
        public Guid IdTurma { get; set; }
        [ForeignKey("IdTurma")]
        public Turma Turma { get; set; }

        [JsonIgnore]
        public virtual Turma IdTurmaNavigation { get; set; }
        [JsonIgnore]
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public ProfessorTurma()
        {
            IdProfessorTurma = Guid.NewGuid();
        }

    }
}
