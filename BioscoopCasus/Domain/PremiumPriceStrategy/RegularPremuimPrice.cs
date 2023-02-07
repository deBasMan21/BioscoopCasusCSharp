using System;
namespace BioscoopCasus.Domain.PremiumPriceStrategy
{
	public class RegularPremuimPrice: IPremiumPriceBehaviour
	{
		public RegularPremuimPrice()
		{
		}

		public double GetPremiumPrice(bool isPremium) => isPremium ? 3 : 0;
	}
}

