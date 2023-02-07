using System;
namespace BioscoopCasus.Domain.PremiumPriceStrategy
{
	public class StudentPremiumPrice: IPremiumPriceBehaviour
	{
		public StudentPremiumPrice()
		{
		}

		public double GetPremiumPrice(bool isPremium) => isPremium ? 2 : 0;
	}
}

