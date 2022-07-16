using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Concrete
{
    public class Feature2
    {
        [Key]
        public int Id { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsSale { get; set; }
        public DateTime CreateDate { get; set; }
        public string Title { get; set; }
        public string CityName { get; set; }
        public string Description { get; set; }
        public int TotalRoomCount { get; set; }
        public int BathCount { get; set; }
        public int BedCount { get; set; }
        public int BuildYear { get; set; }
        public string MainPhoto { get; set; }
        public int SalesManName { get; set; }
        public string OtherImage1 { get; set; }
        public string OtherImage2 { get; set; }
    }
}

