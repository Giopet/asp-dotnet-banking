using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Banking.API.Models;

public class Account
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public int Currency { get; set; }

    [Required]
    public int Country { get; set; }

    public decimal Balance { get; set; }

    public bool IsActive { get; set; }

    /// <summary>
    /// Required for POST/PUT method to give a value.
    /// </summary>
    [Required]
    public int PersonId { get; set; }

    /// <summary>
    /// We have to tell the serializer that this should not be serialized due to infinite loop.
    /// Person reference accounts and accounts reference person.
    /// We make it nullable, otherwise we will have bad request response when we try to call a POST/PUT method.
    /// </summary>
    [JsonIgnore]
    public virtual Person? Person { get; set; }

}
