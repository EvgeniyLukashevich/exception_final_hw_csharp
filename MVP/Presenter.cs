using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using personDataInput.Data;
using personDataInput.Models;
using personDataInput.OwnExceptions;

namespace personDataInput.MVP
{
    public class Presenter 
    { 
        ModelBase model; 
        ViewBase view; 
        BaseData data;

        public Presenter(ModelBase model, ViewBase view, BaseData data)
        {
            this.model = model;
            this.view = view;
            this.data = data;
        }

        public void Start()
        {
            while (true)
            {
                view.ShowMainMenu();
                string userInput = view.UserInput();
                if (userInput.Equals("1"))
                {
                    view.ShowAddPersonFirst();
                    string userLine = view.UserInput();
                    try
                    {
                        string[] userData = model.LineCheck(userLine);
                        userData[0] = model.AnyNameCheck(userData[0]);
                        userData[1] = model.AnyNameCheck(userData[1]);
                        userData[2] = model.AnyNameCheck(userData[2]);
                        userData[3] = model.DateCheck(userData[3]);
                        long userPhone = model.PhoneNumberCheck(userData[4]);
                        char userGender = model.GenderCheck(userData[5]);
                        Person person = new Person.Builder().SetLastName(userData[0])
                                .SetFirstName(userData[1]).SetMiddleName(userData[2])
                                .SetDateOfBirth(userData[3]).SetPhoneNumber(userPhone)
                                .SetGender(userGender).Build();
                        data.DataIn(person);
                        view.ShowAddPersonFinal();
                    }
                    catch (LineSizeException e)
                    {
                        view.ShowErrorMessage(e, "Некорректный ввод: ", e.UserLine);
                        view.ShowAnotherTry();
                    }
                    catch (NameFormatException e)
                    {
                        view.ShowErrorMessage(e, "Некорректный ввод Ф/И/О: ", e.AnyName);
                        view.ShowAnotherTry();
                    }
                    catch (DateFormatException e)
                    {
                        view.ShowErrorMessage(e, "Некорректный ввод даты: ", e.UserDate);
                        view.ShowAnotherTry();
                    }
                    catch (PhoneFormatException e)
                    {
                        view.ShowErrorMessage(e, "Некорректный ввод номера телефона: ", e.PhoneNumber);
                        view.ShowAnotherTry();
                    }
                    catch (GenderFormatException e)
                    {
                        view.ShowErrorMessage(e, "Некорректный ввод пола: ", e.UserGender);
                        view.ShowAnotherTry();
                    }
                    catch (IOException e)
                    {
                        view.ShowErrorMessage(e, "Данные не были записаны. ",
                                "Необходимо повторить попытку.");
                        view.ShowAnotherTry();
                    }
                    catch (Exception e)
                    {
                        view.ShowErrorMessage(e, "Непредвиденная ошибка. ",
                                "Произошло страшное.");
                        view.ShowAnotherTry();
                    }
                }
                else if (userInput.Equals("2"))
                {
                    try
                    {
                        view.ShowPersonList(data.DataOut());
                    }
                    catch (IOException e)
                    {
                        view.ShowErrorMessage(e, "Данные не были прочитаны. ",
                                "Необходимо повторить попытку.");
                        view.ShowAnotherTry();
                    }
                }
                else
                {
                    view.ShowExitMessage();
                    return;
                }
            }
        }
    }
}