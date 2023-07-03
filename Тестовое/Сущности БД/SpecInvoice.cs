using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое
{
	internal class SpecInvoice
	{
		public int specinvoice_id {  get; private set; }
		public int invoice_id { get; private set; }
		public string name { get; private set; }
		public int sum { get; private set; }

		public SpecInvoice(int specinvoice_id, int invoice_id, string name, int sum)
		{
			this.specinvoice_id = specinvoice_id;
			this.invoice_id = invoice_id;
			this.name = name;
			this.sum = sum;
		}
	}
}
