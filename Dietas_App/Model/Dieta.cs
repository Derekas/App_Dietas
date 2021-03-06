using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App.Model
{
    [Table("Dieta")]
    public class Dieta
    {
        [PrimaryKey]
        public int id { get; set; }
        public String nom { get; set; }
        public float calorias_Limite { get; set; }
        public float hidratos_Limite { get; set; }
        public float proteina_Limite { get; set; }
        public float grasas_Limite { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Comida> comidas { get; set; }
    }
}