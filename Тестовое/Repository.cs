using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое
{
	internal static class Repository
	{
		public static List<DO> GetDOList()
		{
			List<DO> list = new List<DO>();

			list.Add(new DO(1, "№123", "20180301", 1));
			list.Add(new DO(2, "№455", "20190523", 1));
			list.Add(new DO(3, "№458", "20200814", 3));
			list.Add(new DO(4, "№85", "20160906", 2));

			return list;
		}

		public static List<SpecDO> GetSpecDOList()
		{
			List <SpecDO> list = new List<SpecDO>();

			list.Add(new SpecDO(1, 1, "товар1", 500));
			list.Add(new SpecDO(2, 1, "товар2", 200));
			list.Add(new SpecDO(3, 2, "товар1", 500));
			list.Add(new SpecDO(4, 3, "товар5", 300));

			return list;
		}

		public static List<Invoice> GetInvoiceList()
		{
			List<Invoice> list = new List<Invoice>();

			list.Add(new Invoice(1, 4, "№123", "20180601", 1));
			list.Add(new Invoice(2, 3, "№124", "20190723", 1));
			list.Add(new Invoice(3, 2, "№125", "20200814", 3));
			list.Add(new Invoice(4, 1, "№126", "20160906", 2));

			return list;
		}

		public static List<SpecInvoice> GetSpecInvoiceList()
		{
			List<SpecInvoice> list = new List<SpecInvoice>();

			list.Add(new SpecInvoice(1, 1, "товар1", 500));
			list.Add(new SpecInvoice(2, 1, "товар2", 200));
			list.Add(new SpecInvoice(3, 2, "товар1", 500));
			list.Add(new SpecInvoice(4, 3, "товар5", 300));

			return list;
		}

		public static List<Contragent> GetContragentList()
		{
			List<Contragent> list = new List<Contragent>();

			list.Add(new Contragent(1, "ООО Лютик", "0201234567", "020101001"));
			list.Add(new Contragent(2, "ООО Ромашка", "3401234567", "340101001"));
			list.Add(new Contragent(3, "ИП Пупкин", "020123456789", ""));

			return list;
		}

		public static List<Region> GetRegionList()
		{
			List <Region> list = new List<Region>();

			list.Add(new Region(1, "01", "Республика Адыгея - Адыгея", "Северо-Кавказский", 1));
			list.Add(new Region(2, "02", "Республика Башкортостан", "Уральский", 1));
			list.Add(new Region(3, "03", "Республика Бурятия", "Восточно-Сибирский", 2));
			list.Add(new Region(4, "04", "Республика Алтай", "Западно-Сибирский", 4));

			return list;
		}

		public static List<Person> GetPersonList()
		{
			List<Person> list = new List<Person>();

			list.Add(new Person(1, "Иванов И.И."));
			list.Add(new Person(2, "Петров П.П."));
			list.Add(new Person(3, "Сидоров С.С."));

			return list;
		}
	}
}
