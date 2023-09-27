using System;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName; 
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getCardNum() 
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }
    
    public String getFirstName() 
    {
        return firstName;
    }

    public double getBalance() 
    { 
        return balance;
    }

    public void setNum(String newCardNum) 
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName) 
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    { 
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much do you want to deposit:");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you. Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much do you want to withdraw:");
            double withdrawal = Double.Parse(Console.ReadLine());
            if (currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insufficient Balance.");
            }
            else 
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you. Your new balance is:" + currentUser.getBalance());
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("5132381207655295", 1234, "Lyndia", "Damron", 1215.20));
        cardHolders.Add(new cardHolder("4532549296657393", 1304, "Rocio", "Jerde", 2030.20));
        cardHolders.Add(new cardHolder("4716615832846770", 5623, "Mavis", "Reilly", 1112.32));
        cardHolders.Add(new cardHolder("5596396984996554", 4785, "Shyanne", "Zemlak", 56431.52));
        cardHolders.Add(new cardHolder("4916990137128119", 4978, "Katheryn", "Considine", 8915.24));
        cardHolders.Add(new cardHolder("5559985768718518", 3561, "Hipolito", "Jacobson", 1500.33));

        Console.WriteLine("Welcome to EasyATM");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            { 
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser == null) { break; }
                else { Console.WriteLine("Card not recognised please try again."); }
            }
            catch { Console.WriteLine("Card not recognised please try again."); }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin please try again."); }
            }
            catch { Console.WriteLine("Incorrect pin please try again."); }
        }
    }

}