using System.ComponentModel.DataAnnotations;

namespace CarGarageApi.Models
{
    public class Garage
    {
        private static int Number { get; set; }

        [Key]
        public int Id => Number;
        public string Name { get; set; }
        public string Description { get; set; }
        public int CarInventory {  get; set; }

        public Garage(string name, string description) 
        {
            Name = name;
            Description = description;
            Number = Number++;
        }
    }
}
