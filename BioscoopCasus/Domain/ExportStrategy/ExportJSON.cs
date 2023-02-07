using System;
using BioscoopCasus.Utils;

namespace BioscoopCasus.Domain.ExportStrategy
{
	public class ExportJSON: IExportBehaviour
	{
		public ExportJSON()
		{
		}

        public void Export<T>(T obj)
        {
            FileUtils.ExportJSON(obj);
        }
    }
}

