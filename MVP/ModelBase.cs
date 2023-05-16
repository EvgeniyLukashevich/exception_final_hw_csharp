using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using personDataInput.OwnExceptions;

namespace personDataInput.MVP
{
    public interface ModelBase
    {
        /// <summary>
        /// Проверка корректности полученной от пользователя строки
        /// </summary>
        /// <param name = "userLine">
        /// Полученная от пользователя строка с данными
        /// </param>
        /// <returns>
        /// Строковый массив состоящий из подстрок входящей строки
        /// </returns>
        string[] LineCheck(string userLine);

        /// <summary>
        /// Проверка корректности полученной от пользователя даты
        /// </summary>
        /// <param name = "dateOfBirth">
        /// Полученная от пользователя дата типа string
        /// </param>
        /// <returns>
        /// Дату корректного формата типа string
        /// </returns>
        string DateCheck(string dateOfBirth);

        /// <summary>
        /// Проверка корректности полученного от пользователя символа, обозначающего пол
        /// </summary>
        /// <param name = "gender">
        /// Полученный от пользователя символ типа string, обозначающий пол
        /// </param>
        /// <returns>
        /// Символ типа char корректного формата, обозначающий пол
        /// </returns>
        char GenderCheck(string gender);

        /// <summary>
        /// Проверка корректности полученного от пользователя номера телефона
        /// </summary>
        /// <param name = "phoneNumber">
        /// Полученный от пользователя номер телефона типа string
        /// </param>
        /// <returns>
        /// Номер телефона корректного формата типа long
        /// </returns>
        long PhoneNumberCheck(string phoneNumber);

        /// <summary>
        /// Проверка корректности полученных от пользователя Фамилии, Имени или Отчества
        /// </summary>
        /// <param name = "anyName">
        /// Полученные от пользователя Фамилия, Имя или Отчество типа string
        /// </param>
        /// <returns>
        /// Ф/И/О корректного формата типа string
        /// </returns>
        string AnyNameCheck(string anyName);

    }
}