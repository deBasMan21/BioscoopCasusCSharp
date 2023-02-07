using System;
namespace BioscoopCasus.Domain
{
	public enum CustomerType
	{
		STUDENT,
		REGULAR
	}

	public static class CustomerExtensions
	{
		public static bool IsStudent(this CustomerType type)
        {
			return type == CustomerType.STUDENT;
        }
	}
}

