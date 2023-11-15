

using System.Text.Json.Serialization;

namespace Domain.Models {

    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string? Name { get; set; }
   
        public string? Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<Counter>? Counter { get; set; }
        [JsonIgnore]
        public virtual ICollection<Developer>? Developer { get; set; }
        [JsonIgnore]
        public virtual ICollection<Manager>? Manager { get; set; }    

    }
}
