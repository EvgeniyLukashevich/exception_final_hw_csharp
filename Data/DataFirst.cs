using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using personDataInput.Models;

namespace personDataInput.Data
{
    public class DataFirst : BaseData
    {
        private string dataPath = Path.Combine(Environment.CurrentDirectory, "database\\");
        private char delimiter = '_';


        public void DataIn(Person person)
        {
            string filePath = dataPath + person.LastName + ".txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.Write(person.LastName + delimiter.ToString() +
                        person.FirstName + delimiter.ToString() +
                        person.MiddleName + delimiter.ToString() +
                        person.DateOfBirth + delimiter.ToString() +
                        person.PhoneNumber + delimiter.ToString() +
                        person.Gender + "\n");
                }
            }
            catch (Exception e)
            {
                throw new IOException
                (
                    "В методе dataIn класса DataFirst произошла ошибка записи данных в файл "
                    + filePath, e
                );
            }
        }

        public Person[] DataOut()
        {
            List<Person> personList = new List<Person>();
            DirectoryInfo dir = new DirectoryInfo(dataPath);

            foreach (FileInfo file in dir.GetFiles())
                try
                {
                    using (StreamReader read = new StreamReader(file.FullName))
                    {
                        string line;
                        while ((line = read.ReadLine()) != null)
                        {
                            string[] data = line.Split(delimiter);
                            Person person = new Person.Builder()
                                    .SetLastName(data[0])
                                    .SetFirstName(data[1])
                                    .SetMiddleName(data[2])
                                    .SetDateOfBirth(data[3])
                                    .SetPhoneNumber(long.Parse(data[4]))
                                    .SetGender(data[5][0])
                                    .Build();
                            personList.Add(person);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new IOException
                    (
                        "В методе dataOut класса DataFirst произошла ошибка чтения данных из файла"
                        + dataPath + file.Name, e
                    );
                }
            return personList.ToArray();
        }

    }
}