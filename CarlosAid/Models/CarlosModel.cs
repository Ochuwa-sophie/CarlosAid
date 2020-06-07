using System;

namespace CarlosAid.Models
{
    public class CarlosModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Owner { get; set; }
    }
}