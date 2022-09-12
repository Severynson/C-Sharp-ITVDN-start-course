using System;

namespace Project_for_lecture_30_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool userAuthorized;
            {
                userAuthorized = false;

                string[] loginList = { "Admin", "Severyn" };
                string[] passwordList = { "000", "111" };

                int authorizationAttemptCounter = 0;
                const int ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS = 3;
                bool authorizationAttemptAvalible = authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

                while (authorizationAttemptAvalible)
                {
                    string login, password;
                    {
                        Console.WriteLine("Pass the login please:");
                        login = Console.ReadLine();
                        Console.WriteLine("Pass the password please:");
                        password = Console.ReadLine();
                    }

                    // authorized = TryAuthorizeUser(login, password);
                    {
                        int index = 0;

                        while (index < loginList.Length && index < passwordList.Length)
                        {
                            bool loginMatched, passwordMatched;
                            {
                                string loginByCurrentIndex = loginList[index];
                                loginMatched = loginByCurrentIndex == login;
                                string passwordByCurrentIndex = passwordList[index];
                                passwordMatched = passwordByCurrentIndex == password;
                            }

                            if (loginMatched && passwordMatched)
                            {
                                userAuthorized = true;
                                break;
                            }
                            else
                            {
                                index++;
                            }
                        }
                    }

                    if (userAuthorized)
                    {
                        Console.WriteLine("You was authorized successfully!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Login or password was typed wrong!");
                        authorizationAttemptAvalible = ++authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

                        if (authorizationAttemptAvalible)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("You failed all 3 tries that was avalible!");
                            break;
                        }
                    }

                }



            }


            // Run (userAuthorized);
            {
                while (userAuthorized)
                {
                    Console.WriteLine("Hardcoded another part of program");
                    break;
                }
            }

        }
    }
}