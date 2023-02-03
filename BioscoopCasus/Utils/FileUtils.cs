using System;
using System.Text.Json;
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
			string json = JsonSerializer.Serialize(obj);

			File.WriteAllText(filePath, json);
		}

		public static void ExportPlainText<T>(T obj) {
			string filePath = Path.Combine(_path, "output.txt");
			File.WriteAllText(filePath, obj?.ToString());
		}
    }
}

