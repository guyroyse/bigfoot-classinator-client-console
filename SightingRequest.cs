using System.Runtime.Serialization;
using RestSharp.Serializers;

public class SightingRequest
{
  public string sighting { get; set; }

  public override string ToString()
  {
    return $"{this.GetType().Name}: {this.sighting}";
  }
}
