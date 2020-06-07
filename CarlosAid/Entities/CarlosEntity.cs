using System;

namespace CarlosAid.Entities
{
    public class CarlosEntity
    {
        public string Id { get; set; }
        public string Title { get; set;}
        public string Description { get; set;}
        public DateTime DueDate { get; set; }
        public string Owner { get; set; }
         
    }
}