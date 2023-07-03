using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое
{
	internal class Region
	{
		public int region_id {  get; private set; }
		public string region_code { get; private set; }
		public string region_name { get; private set; }
		public string zone_name { get; private set; }
		public int person_id { get; private set; }

		public Region(int region_id, string region_code, string region_name, string zone_name, int person_id)
		{
			this.region_id = region_id;
			this.region_code = region_code;
			this.region_name = region_name;
			this.zone_name = zone_name;
			this.person_id = person_id;
		}
	}
}
