using ApplicationCore.Domain;
using ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
	public class PackService : IPackService
	{
		public decimal CalPrixTotal(Pack pack)
		{
			decimal prixTotal = pack.Activities.Sum(a => (decimal)a.Prix) * pack.NbPlaces;
			return prixTotal;
		}

		public decimal PourcentageDesPacks(IEnumerable<Pack> packs)
		{
			decimal longDurPacks = packs.Count(p => p.Duree > 7);
			decimal totalPacks = packs.Count();

			if (totalPacks == 0)
			{
				return 0;
			}

			decimal percentage = (longDurPacks / totalPacks) * 100;
			return percentage;
		}
	}
}
