using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое
{
	internal class Person
	{
		public int person_id {  get; private set; }
		public string fio { get; private set; }

		public Person(int person_id, string fio)
		{
			this.person_id = person_id;
			this.fio = fio;
		}
	}
}
