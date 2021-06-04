using System.Collections.Generic;

namespace PierresSweets.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.FlavorTreatJoinEntities = new HashSet<FlavorTreat>();
      this.Treats = new HashSet<Treat>();
    }

    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreatJoinEntities { get; set; }
    public virtual ICollection<Treat> Treats { get; set; }
  }
}