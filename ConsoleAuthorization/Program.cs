using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashPassword;

namespace ConsoleAuthorization
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Model.LibraryBase bd = Helper.getContex();
				Console.WriteLine("Создание новой учетной записи для пользователя");
				Console.Write("Введите фамилию: ");
				string lName = Console.ReadLine();
				Console.Write("Введите имя: ");
				string fName = Console.ReadLine();
				Console.Write("Введите отчество: ");
				string patronymic = Console.ReadLine();
				Console.Write("Введите адрес электронной почты: ");
				string email = Console.ReadLine();
				Console.Write("Введите дату рождения: ");
				string dateBirth = Console.ReadLine();
				Console.Write("Введите пароль: ");
				string password = Console.ReadLine();

				if (string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(fName) ||
					string.IsNullOrEmpty(email) || string.IsNullOrEmpty(dateBirth) || string.IsNullOrEmpty(password))
				{
					Console.WriteLine("\nВведены не все данные пользователя.\n");
				}
				else if (lName.All(char.IsLetter) || fName.All(char.IsLetter) || int.TryParse(email, out int i))
				{
					Console.WriteLine("\nФамилия, имя, отчество, email не могут быть числом.\n");
				}
				else if (password.Length > 25)
				{
					Console.WriteLine("\nПароль слишком длинный.\n");
				}

				else if (DateTime.TryParseExact(dateBirth, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dt))
				{
					Hash hash = new Hash();
					password = hash.Sha256Hash(password);
					Console.WriteLine($"Хешированный пароль пользователя: {password}");

					int id = Helper.GetLastID();

					Model.Client client = new Model.Client { CL_ID = id, CL_LastName = lName, CL_FirstName = fName, CL_Patronymic = patronymic, CL_Email = email, CL_DateOfBirdth = dt, CL_Password = password};
					Helper.CreateUsers(client);

					Console.WriteLine("Учетная запись добавлена\n");
				}
                else
                {
					Console.WriteLine("\nДата рождения пользователя введена неверно.\n");
                }
			}
		}
	}
}