using System.Text.Json.Serialization;

namespace Banking.API.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Currency { get; set; }
        
        public int Country { get; set; }

        public decimal Balance { get; set; }

        public bool IsActive { get; set; }

        public int PersonId { get; set; }

        /// <summary>
        /// We have to tell the serializer that this should not be serialized due to infinite loop.
        /// Person reference accounts and accounts reference person.
        /// </summary>
        [JsonIgnore]
        public virtual Person Person { get; set; }

    }
}
