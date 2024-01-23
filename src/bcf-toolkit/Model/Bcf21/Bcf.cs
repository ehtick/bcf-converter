using System.Collections.Concurrent;

namespace BcfToolkit.Model.Bcf21;

public partial class Bcf : IBcf {
  [System.ComponentModel.DataAnnotations.RequiredAttribute]
  public ConcurrentBag<Markup> Markups { get; set; }

  public ProjectExtension? Project { get; set; }

  public Version? Version { get; set; }
}