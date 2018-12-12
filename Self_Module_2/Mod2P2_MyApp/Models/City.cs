using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mod2P2_MyApp.Models
{
    [Table("city")]
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
        }

        [Column("city_id")]
        public ushort CityId { get; set; }
        [Required]
        [Column("city", TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Column("country_id")]
        public ushort CountryId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("CountryId")]
        [InverseProperty("City")]
        public Country Country { get; set; }
        [InverseProperty("City")]
        public ICollection<Address> Address { get; set; }
    }
}
