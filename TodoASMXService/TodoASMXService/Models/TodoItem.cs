using System;

namespace TodoASMXService.Models
{
    [Serializable]
    public class TodoItem
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public string Department { get; set; }

    }
}
