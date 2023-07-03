using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое
{
	internal class SpecDO
	{
		public int specdo_id { get; private set; }
		public int do_id { get; private set; }
		public string name { get; private set; }
		public int sum { get; private set; }

		public SpecDO(int specdo_id, int do_id, string name, int sum)
		{
			this.specdo_id = specdo_id;
			this.do_id = do_id;
			this.name = name;
			this.sum = sum;
		}
	}
}
