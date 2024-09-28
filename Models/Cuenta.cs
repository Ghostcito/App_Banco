using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App_Banco.Models
{
    [Table("t_cuenta")]
    public class Cuenta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? TipoCuenta { get; set; }
        public string? Email { get; set; }
        public decimal? Monto { get; set; }

    }
}