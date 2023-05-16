using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using personDataInput.OwnExceptions;

namespace personDataInput.MVP
{
    public class ModelFirst : ModelBase
    {
        public string[] LineCheck(string userLine)
        {
            // Делим строку (пробел - разделитель) и записываем в массив 
            string[] data = userLine.Split(' ');
            // Проверка на количество данных 
            if (data.Length != 6)
                throw new LineSizeException
                (
                    "Количество данных не соответствует необходимому количеству",
                    string.Join(" ", data)
                );
            return data;
        }

        public string DateCheck(string dateOfBirth)
        {
            var dateFormat = new DateTimeFormatInfo();
            dateFormat.ShortDatePattern = "dd.MM.yyyy";
            // Пытаемся распарсить дату, в случае успехе -
            // возвращаем дату в формате строки
            try
            {
                DateTime.ParseExact(dateOfBirth, dateFormat.ShortDatePattern, null);
                return dateOfBirth;
            }
            // В случае неудачи - бросаем соответствующее исключение
            catch (Exception e)
            {
                throw new DateFormatException
                (
                    "Корректный формат даты: 'dd.mm.yyyy'.",
                    dateOfBirth
                );
            }
        }

        public char GenderCheck(string gender)
        {
            // Если введена подходящая буква, возвращаем её в формате char
            if (gender.Equals("m", StringComparison.OrdinalIgnoreCase))
                return 'm';
            else if (gender.Equals("f", StringComparison.OrdinalIgnoreCase))
                return 'f';
            // В противном случае бросаем исключение
            else
                throw new GenderFormatException
                (
                    "Необходимо ввести: m (мужской пол) или f (женский пол).",
                    gender
                );
        }

        public long PhoneNumberCheck(string phoneNumber)
        {
            // Проверка на верное количество цифр в номере
            if (phoneNumber.Length != 10)
                throw new PhoneLengthException
                (
                    "Номер телефона должен состоять из десяти цифр (без пробелов).",
                    phoneNumber
                );
            // Проверка на наличие запрещенных символов в номере
            if (!phoneNumber.All(char.IsDigit))
                throw new PhoneSymbolException
                (
                    "В номере телефона не должно содержаться других символов, кроме цифр.",
                    phoneNumber
                );
            // Возвращаем номер в целочисленном формате Long
            return long.Parse(phoneNumber);
        }

        public string AnyNameCheck(string anyName)
        {
            // Проверяем, чтобы в Ф/И/О не было ненужных символов
            if (!Regex.IsMatch(anyName, "^[a-zA-Zа-яА-Я\\-]+$"))
                throw new NameFormatException
                (
                    "Фамилия/Имя/Отчество может содержать только буквы, либо дефис.",
                    anyName
                );
            // Делаем 1ую букву заглавной, остальные - строчными и возвращаем готовую строку
            return char.ToUpper(anyName[0]) + anyName.Substring(1).ToLower();
        }
    }
}