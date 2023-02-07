using System;
namespace BioscoopCasus.Domain.PremiumPriceStrategy
{
	public interface IPremiumPriceBehaviour
	{
		public double GetPremiumPrice(bool isPremium);
	}
}

