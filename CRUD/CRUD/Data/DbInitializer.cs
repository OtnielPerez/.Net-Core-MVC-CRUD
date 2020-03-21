using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD.Data
{
    public class DbInitializer
    {
        //Comprobar si existen categorias
        public static void Inicializar (CRUDContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programacion (:", Descripcion="Encontraras algo interensante para ver en cuarentena", Estado=true}
            };
            foreach(Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}
