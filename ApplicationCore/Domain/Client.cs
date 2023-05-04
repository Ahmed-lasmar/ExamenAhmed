using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
	public class Client
	{
		public string Login { get; set; }
		[Required]
		[DataType(DataType.Password)]

		public string Password { get; set; }
		public string Photo { get; set; }
		[Key]
		public int Identifiant { get; set; }
		public virtual Conseilleur Conseilleur { get; set; }

		[ForeignKey("Conseilleur")]
         public int ConseilleurFK { set; get; }
	}
}
