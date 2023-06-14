using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EventoAcessivelApp.Domain.Models
{
    [Table("interprete")]
    public class Interprete
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("foto")]
        public string Foto { get; set; } = "";

        [Column("nome")]
        public string Nome { get; set; } = "";

        [Column("email")]
        public string Email { get; set; } = "";

        [Column("senha")]
        public string Senha { get; set; } = "";

        [Column("idade")]
        public int Idade { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; } = "";

        [Column("cidade")]
        public string Cidade { get; set; } = "";

        [Column("estado")]
        public string Estado { get; set; } = "";

        [Column("descricao")]
        public string Descricao { get; set; } = "";

        [Column("curriculo")]
        public string Curriculo { get; set; } = "";

        [NotMapped]
        [Display(Name = "Currículo")]
        public IFormFile? CurriculoFile { get; set; }

        [NotMapped]
        [Display(Name = "Foto")]
        public IFormFile? FotoFile { get; set; }
    }
}