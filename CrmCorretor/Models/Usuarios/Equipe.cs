using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrmCorretor.Models.Usuarios
{
    public class Equipe
    {
        [Key]
        public int IdEquipe { get; set; }
        public string? NomeEquipe { get; set; }
        public int IdGerente { get; set; }
        [ForeignKey("IdGerente")]
        public Usuario? Gerente { get; set; }
        public ICollection<Usuario>? Membros { get; set; } = new List<Usuario>();
    }
}