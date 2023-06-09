using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
	public class Pack
	{
		public int PackId { get; set; }
		public int NbPlaces { get; set; }
		public int Duree { get; set; }
		public DateTime DateDebut { get; set; }
		public string IntitulePack { get; set; }
		public virtual ICollection<Activite> Activities { get; set; }
	}
}
