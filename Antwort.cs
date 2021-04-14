using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadtInfoTool
{
	class Antwort
	{
		[JsonProperty("distance")] public double Distance { get; set; } //Distance ist die Gesamte Distanz zwischen allen Städten
		[JsonProperty("distances")] public double[] Distances { get; set; } //Distances[] ist die Distanz zwischen zwei städten
		[JsonProperty("stops")] public Stops[] stops { get; set; } 
	}

	class Stops
	{
		//[JsonProperty("City")] public string city { get; set; }
		[JsonProperty("wikipedia")] public Wiki wikipedia { get; set; }
		[JsonProperty("timeZone")] public Zones timeZone { get; set; }
	}

	class Wiki
	{
		[JsonProperty("population")] public long population { get; set; } 
	}

	class Zones
	{
		[JsonProperty("abbr")] public string abbr { get; set; }
	}
}

