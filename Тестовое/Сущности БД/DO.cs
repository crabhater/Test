
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое
{
	internal class DO
	{
		public int do_id { get; private set; }
		public string do_name { get; private set; }
		public string date { get; private set;}
		public int contragent_id { get;	private set;}

		public DO(int do_id, string do_name, string date, int contragent_id)
		{
			this.do_id = do_id;
			this.do_name = do_name;
			this.date = date;
			this.contragent_id = contragent_id;
		}
	}
}
