using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using WinFormsTests.Models;

namespace WinFormsTests
{
	public static class ProgramData // класс для сериализации и хранения данных тестов
	{
		public static TestContainer TestContainer;

		private static string _path = Path.Combine(Directory.GetCurrentDirectory(), "data.bin"); // пусть до файла с данными

		public static void LoadData()
		{
			if (File.Exists(_path)) // если файл существует
			{
				var bf = new BinaryFormatter(); // объект, который позволяет преобразовать любые объекты в бинарый формат для сохранения в файл

				var file = File.Open(_path, FileMode.Open, FileAccess.Read); // открываем файл

				TestContainer = (TestContainer)bf.Deserialize(file); // достаем данные из файла

				file.Close();
			}
			else
				TestContainer = new TestContainer(); // создаем новый контейнер тестов если файла с данными не существует 
		}

		public static void SaveData() // сохранения данных в файл
		{
			var bf = new BinaryFormatter();

			var file = File.Open(_path, FileMode.OpenOrCreate, FileAccess.Write);

			bf.Serialize(file, TestContainer); // сохраняем данные в файл

			file.Close();
		}
	}
}
