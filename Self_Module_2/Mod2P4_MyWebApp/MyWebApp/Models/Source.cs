using System.Collections.Generic;

namespace MyWebApp.Models {
    public class Film {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre[] Genres { get; set; }
        public bool IsInStore { get; set; }
    }

    public class CreateOrUpdateDTO {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre[] Genres { get; set; }
        public bool IsInStore { get; set; }
        public Operation Operation { get; set; }
    }

    public enum Genre {
        Action,
        Adventure,
        Comedy,
        Drama,
        War
    }

    public enum Operation {
        Create,
        Update,
        Delete
    }
}