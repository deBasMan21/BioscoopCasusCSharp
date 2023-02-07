using System;
namespace BioscoopCasus.Domain.ExportStrategy
{
	public interface IExportBehaviour
	{
		public void Export<T>(T obj);
	}
}
