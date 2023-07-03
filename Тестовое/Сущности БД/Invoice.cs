using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое
{
	internal class Invoice
	{
		public int invoice_id { get; private set; }
		public int do_id { get; private set; }
		public string invoice_name { get; private set; }
		public string date { get; private set; }
		public int contragent_id { get; private set; }

		public Invoice(int invoice_id, int do_id, string invoice_name, string date, int contragent_id)
		{
			this.invoice_id = invoice_id;
			this.do_id = do_id;
			this.invoice_name = invoice_name;
			this.date = date;
			this.contragent_id = contragent_id;
		}
	}
}
