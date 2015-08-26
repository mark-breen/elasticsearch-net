﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest
{

	[JsonObject]
	[JsonConverter(typeof(WarmerMappingJsonConverter))]
	public class WarmerMapping
	{
		public string Name { get; internal set; }

		public IEnumerable<TypeName> Types { get; internal set; }

		public ISearchRequest Source { get; internal set; }

	}
}