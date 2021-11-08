namespace MVCClinica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medico")]
    public partial class Medico
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(50)]
        public string Especialidad { get; set; }

        public int NroMatricula { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Ciudad { get; set; }
    }
}
