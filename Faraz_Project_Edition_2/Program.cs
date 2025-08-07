// Primary Information

string name = "Milad ";
string lastName = "Najafgholi Salimi";
string fullName = name + lastName;
string userName = "Milad__0";
string password = "12345678";
int age = 21;
string gender = "Male";
long mobileNumber = 9016414358;
string birthDay = "1382,5,3";
long balance = 0;
Console.WriteLine("Welcome to Milad Bank" + "\n");


// Login

while (true)
{
    Console.Write("User name: ");
    string checkingUserName = Console.ReadLine();
    Console.Write("Password: ");
    string checkingPassword = Console.ReadLine();
    Console.WriteLine("");

    //Checking User Name and Password

    if (checkingUserName == userName && checkingPassword == password)
    {
        Console.WriteLine("Welcome to your wallet " + "\"" + fullName + "\"");
        break;
    }
    else
        Console.WriteLine("Incorrect... Try again!" + "\n");
}


// Main Menu

label_1:

while (true)
{
    Console.WriteLine("1.User Menu");
    Console.WriteLine("2.Account Menu");
    Console.WriteLine("3.Show Info");
    Console.WriteLine("4.Exit");
    Console.Write("Your Command: ");
    int input = int.Parse(Console.ReadLine());
    Console.WriteLine("");


    // Selecting an Option

    switch (input)
    {
        case 1: // User Menu Entry
        label_2:
            while (true)
            {
                Console.WriteLine("Welcome to User Menu" + "\n");
                Console.WriteLine("1.Change Password");
                Console.WriteLine("2.Change user info");
                Console.WriteLine("3.Back to Main Menu");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (input)
                {
                    case 1: // "Changing Password" in "User Menu Entry"
                        while (true)
                        {
                            Console.Write("Enter your New Password: ");
                            string inputPassword = Console.ReadLine();
                            if (inputPassword.Length >= 8)
                            {
                                Console.WriteLine("Password Successfully Changed." + "\n");
                                password = inputPassword;
                                Console.WriteLine("");
                                break;
                            }
                            else
                                Console.WriteLine("Your password is too short. It should be at least 8 characters." + "\n");
                        }
                        break;

                    case 2: // "Changing User Info" in "User Menu Entry"
                        while (true)
                        {
                            Console.WriteLine("Which one do you want to change?" + "\n");
                            Console.WriteLine("1.Full Name");
                            Console.WriteLine("2.User Name");
                            Console.WriteLine("3.Age");
                            Console.WriteLine("4.Gender");
                            Console.WriteLine("5.Mobile Number");
                            Console.WriteLine("6.Birth Day");
                            Console.WriteLine("7.Back to Main Menu" + "\n");
                            input = int.Parse(Console.ReadLine());

                            switch (input)
                            {
                                case 1: // Changing Full Name
                                    Console.Write("Changing Name: ");
                                    name = Console.ReadLine();
                                    Console.Write("Changing Last Name: ");
                                    lastName = Console.ReadLine();
                                    fullName = name + " " + lastName;
                                    Console.WriteLine("");
                                    Console.WriteLine($"Full name successfully changed to \"{fullName}\" ");
                                    Console.WriteLine("");
                                    break;

                                case 2: // Changing User Name
                                    Console.WriteLine("Changing User Name" + "\n");
                                    Console.Write("Enter your new User name: ");
                                    userName = Console.ReadLine();
                                    Console.WriteLine("User Name Changed successfully." + "\n");
                                    break;

                                case 3: // Changing Age
                                    while (true)
                                    {
                                        Console.WriteLine("Attention: The Age must be at least 13 and at most 100 years old.");
                                        Console.Write("Changing Age: ");
                                        int ageInput = Console.Read();
                                        if (ageInput >= 13 && ageInput <= 100)
                                        {
                                            Console.WriteLine("Age changed successfully.");
                                            age = ageInput;
                                            Console.WriteLine("");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Not accepted... Try again!" + "\n");
                                    }
                                    break;

                                case 4: // Changing Gender
                                    while (true)
                                    {
                                        Console.Write("Changing Gender -> Male or Female: ");
                                        string inputGender = Console.ReadLine();
                                        if (inputGender == "male" || inputGender == "Male" || inputGender == "female" || inputGender == "Female")
                                        {
                                            Console.WriteLine("Your Gender Changed Successfully" + "\n");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Incorrect... Try again!" + "\n");
                                    }
                                    break;

                                case 5: // Changing Mobile Number
                                    while (true)
                                    {
                                        Console.WriteLine("Attention: Mobile Number Length should be 10 characters.");
                                        Console.Write("Changing Mobile Number: ");
                                        string mobileNumberInput = Console.ReadLine();
                                        if (mobileNumberInput.Length == 10)
                                        {
                                            mobileNumber = long.Parse(mobileNumberInput);
                                            Console.WriteLine("Mobile Number Changed Successfully" + "\n");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Incorrect... Try again!");
                                    }
                                    break;

                                case 6: // Changing Birth Day
                                    Console.WriteLine("Changing Birth Day" + "\n");
                                    Console.Write("Enter Day of Birth: " + "\n");
                                    int dayBirth = Console.Read();
                                    Console.Write("Enter Month of Birth: " + "\n");
                                    int monthBirth = Console.Read();
                                    Console.Write("Enter Year of Birth: " + "\n");
                                    int yearBirth = Console.Read();
                                    birthDay = yearBirth + "," + monthBirth + "," + dayBirth;
                                    Console.WriteLine($"New birthday changed successfully to \"{yearBirth},{monthBirth},{dayBirth}\" ");
                                    break;

                                case 7:
                                    goto label_2;

                                default:
                                    Console.WriteLine("Invalid Input... Try Again!");
                                    break;
                            }
                        }
                        //break;

                    case 3: // Back To Main Menu
                        goto label_1;

                    default:
                        Console.WriteLine("Invalid Input... Try Again!");
                        break;
                }
            }
            //break;

        case 2: // Account Menu Entry
            while (true)
            {
                Console.WriteLine("Welcome to Account Menu" + "\n");
                Console.WriteLine("1.Deposit");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.‌Bank Account Balance");
                Console.WriteLine("4.Back to Main Menu" + "\n");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1: // Depositing
                        while (true)
                        {
                            Console.WriteLine("***Depositing***" + "\n");
                            Console.Write("Enter Depositing Amount: ");
                            long deposit = long.Parse(Console.ReadLine());
                            if (deposit > 0)
                            {
                                balance += deposit;
                                Console.WriteLine("Depositing successfully Done!");
                                break;
                            }
                            else
                                Console.WriteLine("Error. Invalid Deposit. Try again!");
                        }
                        break;

                    case 2: // Withdrawing
                        while (true)
                        {
                            Console.WriteLine("***Withdrawing***" + "\n");
                            Console.Write("Enter Withdrawing Amount: ");
                            long withdraw = long.Parse(Console.ReadLine());
                            if (withdraw <= balance && withdraw > 0)
                            {
                                balance -= withdraw;
                                Console.WriteLine("Withdraw successfully Done!");
                                break;
                            }
                            else
                                Console.WriteLine("Error. Invalid Withdraw. Try again!");
                        }
                        break;

                    case 3: // Showing The Balance 
                        Console.WriteLine($"Your Current Bank Account Balance is {balance}" + "\n");
                        break;

                    case 4: // Back To Main Menu
                        goto label_1;

                    default:
                        Console.WriteLine("Invalid Input... Try Again!");
                        break;
                }
            }
            //break;

        case 3: // Show User Info
            Console.WriteLine("***User Info***" + "\n");
            Console.WriteLine($"User Full Name: {fullName}");
            Console.WriteLine($"User Name: {userName}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"User Age: {age}");
            Console.WriteLine($"User Gender: {gender}");
            Console.WriteLine($"User Phone Number: {mobileNumber}");
            Console.WriteLine($"User Birth Day: {birthDay}");
            Console.WriteLine($"User Balance: {balance}");
            break;

        case 4: // Exit
            Console.WriteLine($"Good bye \"{fullName}\"");
            return;
            
        default:
            Console.WriteLine("Invalid Input... Try Again!");
            break;
            
    }
}