using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApps
{
	static class ProjectManager
	{
		public static void SaveToFile(Project data, string filename)
		{
			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(filename))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, data);
			}

		}
		public static Project LoadFromFile(string filename)
		{
			JsonSerializer serializer = new JsonSerializer();
			using (StreamReader sr = new StreamReader(filename))
			using (JsonReader reader = new JsonTextReader(sr))
			{
				return (Project)serializer.Deserialize<Project>(reader);
			}

		}

	}
}
