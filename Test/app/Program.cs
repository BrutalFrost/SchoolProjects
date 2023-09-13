// See https://aka.ms/new-console-template for more information


using System.Formats.Asn1;

class TestApp {

    public static void Main() {
        
        int choice;
        while (true) {
            Console.WriteLine();
            Console.WriteLine("Vilken modul vill du köra?");
            Console.WriteLine("1. Gissa talet.");
            Console.WriteLine("2. Datorn gissar talet:");
            Console.WriteLine("3. Höja talet.");
            Console.WriteLine("4. Simple Triangle");
            Console.WriteLine("5. Reverse simple triangle");
            Console.WriteLine("6. Reaktionspelet");
            Console.WriteLine("7. Banksystem");
            

            Console.WriteLine("0. Exit");
            Console.WriteLine();
            
            choice = int.Parse(Console.ReadLine());
            
            switch (choice) {
                case 1:
                    GissaTalet();
                    break;
                case 2:
                    DGissaTalet();
                    break;
                case 3:
                    HöjaTalet();
                    break;
                case 4:
                    SimpleTriangel();
                    break;
                case 5:
                    ReverseSimpleTriangel();
                    break;
                case 6:
                    Reaktionsspelet();
                    break;
                case 7:
                    BankSystem();
                    break;
                case 0: 
                Environment.Exit(0);
                break;
            }
        }
        
    }
//--------------------------------------------------------------------------------------------
    // Complexa uppgifter 1: Gissa talet
    static void GissaTalet () {
        // Initiating variables
        Random rnd = new Random();
        int uknownNumber = rnd.Next(1, 101);
        string inputNumber;
        int userNumber;
        int itterations = 0;
        
        // Main while loop
        while (true) {
            Console.WriteLine();
            itterations++;
            Console.WriteLine("Gissa talet?");
            // Try catch in case of invalid input
            try {
                inputNumber = Console.ReadLine();
                if (inputNumber == "ä") {
                    return;
                }
                userNumber = Convert.ToInt32(inputNumber);
                // If case to check if the input number is between 1-100
                if (userNumber < 1 || userNumber > 100) {
                    Console.WriteLine("Please input a number between 1 and 100");
                } else {
                    // If case to output if the user answered correctly or not
                    if (uknownNumber > userNumber) {
                        Console.WriteLine("Fel! Mitt tal är större!");
                    } else if (uknownNumber < userNumber) {
                        Console.WriteLine("Fel! Mitt tal är mindre!");
                    } else if (uknownNumber == userNumber) {
                        Console.WriteLine($"Rätt du gjorde {itterations} försök!");
                        break;
                    }
                }
            }
            catch (Exception)
            {
                // Output text if an exception is caught
                Console.WriteLine("Format not supported");
                Console.WriteLine();
            }

        }   
    
        
        // Returns to main method
        return;
    }
//--------------------------------------------------------------------------------------------
    // Complexa uppgifter 2 
    static void DGissaTalet () {
        // Initialising variables
        int upperLimit = 100;
        int lowerLimit = 1;
        int guess = 50;
        string answer;
        Random rnd = new Random();
        // Making sure the user is ready
        Console.WriteLine("Välj ett nummer mellan 1 till 100");
        while(true) {
            Thread.Sleep(500);
            Console.Write("."); Console.Write("."); Console.Write(".");
            Console.WriteLine("Har du valt? Y/N");
            answer = Console.ReadLine();
            if (answer == "Y" || answer == "y") {
                break;
            }
        }
        answer = null; // Resetting answer
        
        // Main loop for the method
        while (true) {
            guess = (lowerLimit+upperLimit)/2;
            Console.WriteLine($"Jag gissar {guess}. Är det [r]ätt? Eller är ditt nummer [h]ögre eller [l]ägre?");
            answer = Console.ReadLine();
            switch (answer) {
                case "r":
                    Console.WriteLine("Hurra!");
                    return; // Return back to main method
            
                case "h": // Your number is higher
                     // Changes the values of the random number to get closer to the answer
                    lowerLimit = guess;
                    break;
                case "l": // Your number is lower
                    // Changes the values of the random number to get closer to the answer
                    upperLimit = guess;
                    break;
            }

        }
        
    }
//--------------------------------------------------------------------------------------------
    // Complexa uppgifter 3
    static void HöjaTalet () {
        
        Console.WriteLine("I tur och ordning får ni höja det aktuella värdetmed 1, 2 eller 3. Den som skriver in 21 eller högre förlorar");
        int choice = 0; // Total number
        int currentPlayer = 1; // Current active player
        int answer; // Chosen answer of 1, 2 or 3
        while(true){
            Console.WriteLine();
            Console.WriteLine($"Spelare {currentPlayer}, välj {choice+1}, {choice+2} eller {choice+3}");
            try {
                answer = choice; // Total number vs current choice

                choice = int.Parse(Console.ReadLine()); // User input
                // If case to make sure input is an increase of 1 to 3
                if (choice <= answer+3 && choice >= answer+1 ) {
                    // If case to see if user lost
                    if (choice >= 21) {
                        Console.WriteLine($"Player {currentPlayer} lost");
                        return;
                    }
                    currentPlayer = (currentPlayer % 2) + 1; // Keep track of current player
                } else {
                    Console.WriteLine("Skriv bara ett av alternativen");
                    choice = answer;
                }                    
            }
            catch (FormatException)
            {
                // Handle the case where input is not a valid integer format
                Console.WriteLine("Du måste ge en siffra");
            }           
        }
    }
//--------------------------------------------------------------------------------------------
    // Simple 4.6
    static void SimpleTriangel () {
        Console.WriteLine("Input width of triangle");
        int width = int.Parse(Console.ReadLine());
        for(int i = 0; i < width; i++) {
            for(int j = 0; j < (width-i); j++){
                Console.Write(width);
            }
            Console.WriteLine();
        }
        return;
    }
    static void ReverseSimpleTriangel () {
        Console.WriteLine("Input width of triangle");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for(int i = 0; i < width; i++) {
            for(int j = 0; j <= i; j++){
                Console.Write(width);
            }
            Console.WriteLine();
        }
        return; 
    }
//--------------------------------------------------------------------------------------------
// Komplexa uppgifter 4
    static void Reaktionsspelet () {
        
        Random rnd = new Random();
        
        string a;
        int startCount;
        int endCount;
        
        while(true){
            Console.WriteLine("Ok, Get ready");
            Thread.Sleep(rnd.Next(3000, 10000));
            startCount = Environment.TickCount;
            Console.WriteLine("Now!");
            Console.ReadLine();
            endCount = Environment.TickCount - startCount;
            if(endCount >= 50) {
                Console.WriteLine($"Din reaktionstid var {endCount}ms");
                break;
            } else {
                Console.WriteLine("Inget fusk!");
            }
        }
        
        return;
    }

//--------------------------------------------------------------------------------------------
// Komplexa uppgifter 5
    static void BankSystem()
    {
        List<BankUser> userList = new List<BankUser>(); // List of users
        // Main loop
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Registrera nytt konto");
            Console.WriteLine("3. Exit");
            
            int answer = int.Parse(Console.ReadLine());
            // Login
            if (answer == 1)
            {
                Console.WriteLine("Vad är ditt namn? (Case sensitive)");
                string currentUser = Console.ReadLine();
                // For loop to search for and user access a specified user
                for (int i = 0; i < userList.Count; i++)
                {
                    // Checks if the specified user is in the list
                    if (currentUser == userList[i].GetName())
                    {
                        while(true) {
                            Console.WriteLine("What do you wanna do?");
                            Console.WriteLine("1. Deposit");
                            Console.WriteLine("2. Whitdraw");
                            Console.WriteLine("3. Balance");
                            Console.WriteLine("4. Return");
                            answer = int.Parse(Console.ReadLine());

                            if (answer == 1) {
                                Console.WriteLine("Hur mycket vill du lägga in?");
                                userList[i].AddBalance(int.Parse(Console.ReadLine()));
                            } else if (answer == 2) {
                                Console.WriteLine("Hur mycket vill du ta ut?");
                                userList[i].RemoveBalance(int.Parse(Console.ReadLine()));
                            } else if (answer == 3) {
                                Console.WriteLine($"Current balance: {userList[i].GetBalance()}");
                            } else if (answer == 4){
                                break;
                            }
                        }
                        break;
                    // Incase user inputs a non registered name
                    } else {
                        Console.WriteLine("Det finns inget konto med detta namn: ");
                        break;
                    }
                }
            }
            //Login
            else if (answer == 2)
            {
                Console.WriteLine("Skriv nytt namn");
                string newName = Console.ReadLine(); // Name to registered
                BankUser testUser2 = new BankUser(); // Temp user to be added to the list
                testUser2.SetName(newName); 
                userList.Add(testUser2);

                // Debugging output to check if testUser2 was added successfully
                Console.WriteLine("Added testUser2 with name: " + newName);
            }
            // Exit bank system
            else if (answer == 3)
            {
                return;
            }
            else if (answer == 4)
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    Console.WriteLine("User " + i + ": " + userList[i].GetName());
                }
            }
        }
    }
    

}


