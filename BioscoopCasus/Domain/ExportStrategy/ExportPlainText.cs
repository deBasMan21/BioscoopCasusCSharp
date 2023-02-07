using System;
using BioscoopCasus.Utils;

namespace BioscoopCasus.Domain.ExportStrategy
{
	public class ExportPlainText: IExportBehaviour
	{
		public ExportPlainText()
		{
		}

        public void Export<T>(T obj)
        {
            FileUtils.ExportPlainText(obj);
        }
    }
}

