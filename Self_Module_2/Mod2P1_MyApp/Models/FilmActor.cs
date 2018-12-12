using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mod2P1_MyApp.Models
{
    [Table("film_actor")]
    public partial class FilmActor
    {
        [Column("actor_id")]
        public ushort ActorId { get; set; }
        [Column("film_id")]
        public ushort FilmId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("ActorId")]
        [InverseProperty("FilmActor")]
        public Actor Actor { get; set; }
        [ForeignKey("FilmId")]
        [InverseProperty("FilmActor")]
        public Film Film { get; set; }
    }
}
