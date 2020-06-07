using System;
using System.Collections.Generic;
using System.Linq;
using CarlosAid.Entities;
using CarlosAid.Models;

namespace CarlosAid.Services
{
    public class CarlosService
    {
        private List<CarlosEntity> _carlosList = new List<CarlosEntity>();

        public IEnumerable<CarlosEntity> GetCarlos()
        {
            return _carlosList;
        }

        public string AddCarlos(CarlosModel model)
        {
            if(model is null) throw new ArgumentNullException(message: "todo item cannot be null", null);

            var carlos = new CarlosEntity
            {
                Id = Guid.NewGuid().ToString(),
                Title = model.Title,
                Description = model.Description,
                DueDate = model.DueDate,
                Owner = model.Owner,
            };
            _carlosList.Add(carlos);

            return carlos.Id;
        }
    
        public string UpdateCarlos(CarlosModel model)
        {
            var carlos4Update = _carlosList.Where(c => c.Id == model.Id).FirstOrDefault();
            if(carlos4Update is null) throw new ArgumentOutOfRangeException(message: "No todo item with this id found", null);

            if(!string.IsNullOrWhiteSpace(model.Title))
            {
                carlos4Update.Title = model.Title;
            }

            if(!string.IsNullOrWhiteSpace(model.Description))
            {
                carlos4Update.Title = model.Description;
            }

            if(model.DueDate != carlos4Update.DueDate)
            {
                carlos4Update.DueDate = model.DueDate;
            }
            return carlos4Update.Id;
        }
    }
}