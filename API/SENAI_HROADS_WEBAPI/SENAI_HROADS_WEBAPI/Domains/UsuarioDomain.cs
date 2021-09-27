using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_hroads_webAPI.Domains
{
    public partial class Usuario
    {
        public short IdUsuario { get; set; }
        public short? IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O E-Mail é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória")]
        public string Senha { get; set; }

        public virtual Tipousuario IdTipoUsuarioNavigation { get; set; }
    }
}