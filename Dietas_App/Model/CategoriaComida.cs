using System;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App.Model
{
    [Table("Categoria")]
    public class CategoriaComida
    {
        [PrimaryKey]
        public int id { get; set; }
        public String nom { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Comida> comidas { get; set; }
    }
}
