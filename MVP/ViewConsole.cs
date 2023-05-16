using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using personDataInput.Models;

namespace personDataInput.MVP
{
    public class ViewConsole : ViewBase
    {
        private string mainMenu =
            "\n# # # # # # # # # # # # # # # # # # # # # # # # #\n"
            + "1 - Ввести данные\n" + "2 - Вывести данные\n"
            + "Any other key - Выход\n" + "Выберите нужный пункт меню: ";

        private string addPersonFirst =
            "\nФормат данных: Фамилия Имя Отчество датаРождения номерТелефона пол\n" +
            "Пример ввода: Иванов Иван Иванович 12.12.1990 8800123456 m\n" +
            "Введите данные: ";

        private string addPersonFinal = "Данные успешно записаны!\n\n";
        private string anotherTry = "Попробуйте снова.";
        private string exitMessage = "\n\nВсего доброго!";

        public string UserInput()
        {
            return Console.ReadLine();
        }

        public void ShowMainMenu()
        {
            Console.WriteLine(mainMenu);
        }

        public void ShowAddPersonFirst()
        {
            Console.WriteLine(addPersonFirst);
        }

        public void ShowAddPersonFinal()
        {
            Console.WriteLine(addPersonFinal);
        }

        public void ShowPersonList(Person[] personList)
        {
            string text = "\n";
            foreach (Person person in personList)
            {
                text += "Фамилия: " + person.LastName +
                        "\nИмя: " + person.FirstName +
                        "\nОтчество: " + person.MiddleName +
                        "\nДата рождения: " + person.DateOfBirth +
                        "\nНомер телефона: " + person.PhoneNumber +
                        "\nПол: " + person.Gender + "\n\n";
            }
            Console.WriteLine(text);
        }

        public void ShowErrorMessage(Exception e, string messageToUser, string userInput)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(messageToUser + userInput);
        }

        public void ShowAnotherTry()
        {
            Console.WriteLine(anotherTry);
        }

        public void ShowExitMessage()
        {
            Console.WriteLine(exitMessage);
        }

    }
}