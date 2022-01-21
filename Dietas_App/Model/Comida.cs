using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App.Model
{
    [Table("Comida")]
    public class Comida
    {
        [PrimaryKey]
        public int id { get; set; }
        public String nom { get; set; }

        public String cantidad { get; set; }
        public float calorias { get; set; }
        public float hidratos { get; set; }
        public float proteina { get; set; }
        public float grasas { get; set; }

        [ForeignKey(typeof(Dieta))]
        public int dieta_id { get; set; }

        [ForeignKey(typeof(CategoriaComida))]
        public int categoria_id { get; set; }

    }
}
