namespace Тестовое
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Создание таблиц
			DBManager.Prepairing();

			//Заполнение таблиц
			int rowsAdded;
			rowsAdded = DBManager.FillDO(Repository.GetDOList());
			Console.WriteLine($"Добавлено строк {rowsAdded}");
			rowsAdded = DBManager.FillSpecDO(Repository.GetSpecDOList());
			Console.WriteLine($"Добавлено строк {rowsAdded}");
			rowsAdded = DBManager.FillInvoice(Repository.GetInvoiceList());
			Console.WriteLine($"Добавлено строк {rowsAdded}");
			rowsAdded = DBManager.FillSpecInvoice(Repository.GetSpecInvoiceList());
			Console.WriteLine($"Добавлено строк {rowsAdded}");
			rowsAdded = DBManager.FillContragent(Repository.GetContragentList());
			Console.WriteLine($"Добавлено строк {rowsAdded}");
			rowsAdded = DBManager.FillRegion(Repository.GetRegionList());
			Console.WriteLine($"Добавлено строк {rowsAdded}");
			rowsAdded = DBManager.FillPerson(Repository.GetPersonList());
			Console.WriteLine($"Добавлено строк {rowsAdded}");
		}
	}
}