using System.ComponentModel.DataAnnotations;

namespace TenantAPI.Models
{
  public class Tenant
  {
    [Key]
    public int TenantId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [Phone]
    public int Phone { get; set; }
    [Required]
    public string ApartmentName { get; set; }
    [Required]
    [StringLength(5, ErrorMessage="Apartment Number must not exceed 5 characters.")]
    public string ApartmentNumber { get; set; }
    public bool IsBackgroundChecked { get; set; }
  }
}