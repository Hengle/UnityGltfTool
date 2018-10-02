﻿using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace UnityGltfTool
{
	public static class ExtensionUtil
	{
		public static T LoadExtension<T>(Dictionary<string, object> extensions, string extensionName)
		{
			object json;
			if (extensions != null && extensions.TryGetValue(extensionName, out json))
				return ((JObject)json).ToObject<T>();

			return default(T);
		}
	}
}
