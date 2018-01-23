using System;
using System.ComponentModel.DataAnnotations;

namespace ContextExperiment.Models;
{
    public class Address
    {
        public Address (string addressLine, string city, string state, string zip)
        {
            this.AddressLine = addressLine;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}