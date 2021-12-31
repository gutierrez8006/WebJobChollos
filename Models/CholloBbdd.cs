using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebJobChollos.Models
{
    [Table("CHOLLOS")]
    public class CholloBbdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCHOLLO")]
        public int IdChollo { get; set; }

        [Column("TITULO")]
        public String Titular { get; set; }

        [Column("ENLACE")]
        public String Enlace { get; set; }

        [Column("DESCRIPCION")]
        public String Descripcion { get; set; }

        [Column("FECHA")]
        public DateTime Fecha { get; set; }

        [Column("CATEGORIA")]
        public String Categoria { get; set; }
    }
}
