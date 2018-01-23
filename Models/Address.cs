using System;
using System.ComponentModel.DataAnnotations;

namespace ContextExperiment.Models
{
    public enum ObjectFormat
    {
        JSON, XML
    }
    
    public class Address
    {
        private const string separator = "+";        
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

        public string FullAddressQuery()
        {
            return this.AddressLine.Replace(" ", separator) + separator
                + this.City.Replace(" ", separator) + separator
                + this.State.Replace(" ", separator) + separator
                + this.Zip.Replace(" ", separator);
        }
    }
}