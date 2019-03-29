using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica08Noticia.Models
{
    public class Categoria
    {

        public int CategoriaID { get; set; }
        [Required]
        public string Nombre { get; set; }

        public virtual ICollection<Noticia> Noticias { get; set; }

    }
}
