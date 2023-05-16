using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using personDataInput.Models;

namespace personDataInput.Data
{
    public interface BaseData
    {
        void DataIn(Person person);
        Person[] DataOut();
    }
}
 