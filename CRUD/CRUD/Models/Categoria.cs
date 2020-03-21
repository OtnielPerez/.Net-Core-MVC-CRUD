using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CRUD.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required (ErrorMessage = "Campo requerido")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Mínimo 3 maximo 50 caracteres")]
        public String Nombre { get; set; }
        [StringLength(256, ErrorMessage ="La descripcion no puede tener mas de 256 caracteres ):")]
        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }
        public Boolean Estado { get; set; }
        
        

    }
}
