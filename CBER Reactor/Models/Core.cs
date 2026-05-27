using System.Reflection.Metadata.Ecma335;

namespace CBER_Reactor.Models;

internal class Core
{
    public string? Name { get; set; }
    public Metadata Data { get; set; }
    public double? Temperature { get; set; }
    public long? Pressure { get; set; }

}
