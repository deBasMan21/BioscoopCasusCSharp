using System;
using System.Text.Json;
using System.Xml;
using BioscoopCasus.Domain;

namespace BioscoopCasus.Utils
{
	public class FileUtils
	{
		private FileUtils()
		{
		}

		private static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

		public static void ExportJSON<T>(T obj) {
			string filePath = Path.Combine(_path, "output.json");
			JsonSerializerOptions options = new()
            {
				WriteIndented = true
			};

			string json = JsonSerializer.Serialize(obj, options);

			File.WriteAllText(filePath, json);
		}

		public static void ExportPlainText<T>(T obj) {
			string filePath = Path.Combine(_path, "output.txt");
			File.WriteAllText(filePath, obj?.ToString());
		}
    }
}

