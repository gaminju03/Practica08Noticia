using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica08Noticia.Models
{
    public class Noticia
    {

        public int NoticiaID { get; set; }
        [Required(ErrorMessage = "El campo Titulo es Requerido")]
        [StringLength(100, ErrorMessage = "La longitud máxima es de 100")]
        public string Titulo { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Contenido { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
