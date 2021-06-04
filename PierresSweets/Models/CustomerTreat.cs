using System;

namespace PierresSweets.Models
{
  public class CustomerTreat
  {
    public int CustomerTreatId { get; set; }
    public int TreatId { get; set; }
    public int CustomerId { get; set; }

    public virtual Treat Treat { get; set; }
    public virtual ApplicationUser Customer { get; set; }
  }
}