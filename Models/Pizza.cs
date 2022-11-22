using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
        public string Image { get; set; }
        public float Cost { get; set; }
        public bool Available { get; set; }

        public Pizza(string name, string description, string image, float cost, bool available)
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Cost = cost;
            this.Available = available;
        }
    }
}
