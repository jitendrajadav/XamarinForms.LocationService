using Realms;
using System;

namespace XamarinForms.LocationService.Models
{
    public class LocationModel : RealmObject
    {
        [PrimaryKey]
        public Guid Id { get; set; } = Guid.NewGuid();
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
