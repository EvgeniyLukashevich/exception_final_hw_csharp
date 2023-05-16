using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using personDataInput.Models;

namespace personDataInput.MVP
{
    public interface ViewBase
    {
        abstract String UserInput();

        abstract void ShowMainMenu();

        abstract void ShowAddPersonFirst();

        abstract void ShowAddPersonFinal();

        abstract void ShowPersonList(Person[] personList);

        abstract void ShowAnotherTry();

        abstract void ShowErrorMessage
        (
            Exception e,
            String messageToUser,
            String userInput
        );

        abstract void ShowExitMessage();
    }
}