using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrmCorretor.Models.Usuarios
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string? NomeUsuario { get; set; }
        public string? EmailUsuario { get; set; }
        public string? SenhaUsuario { get; set; }
        public int CargoId { get; set; }
        [ForeignKey("CargoId")]
        public Cargo? Cargo { get; set; }
        public int IdEquipe { get; set; }
        [ForeignKey("IdEquipe")]
        public Equipe? Equipe { get; set; }
        public string? NumeroCreci { get; set; }

    }
}