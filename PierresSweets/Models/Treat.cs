using System.Collections.Generic;

namespace PierresSweets.Models
{
  public class Treat
  {
    public Treat()
    {
      this.FlavorTreatJoinEntities = new HashSet<FlavorTreat>();
      this.CustomerTreatJoinEntities = new HashSet<CustomerTreat>();
    }

    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreatJoinEntities { get; }
    public virtual ICollection<CustomerTreat> CustomerTreatJoinEntities { get; set; }
  }
}