using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое
{
	internal class Contragent
	{
		public int contragent_id {  get; private set; }
		public string contragent_name { get; private set; }
		public string inn { get; private set; }
		public string kpp { get; private set; }

		public Contragent(int contragent_id, string contragent_name, string inn, string kpp)
		{
			this.contragent_id = contragent_id;
			this.contragent_name = contragent_name;
			this.inn = inn;
			this.kpp = kpp;
		}
	}
}
