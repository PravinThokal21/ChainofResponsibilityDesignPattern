
using ChainofResponsibilityDesignPattern;

Console.WriteLine("Chain of Responsibility Design Pattern");

// Setup Chain of Responsibility
Approver rohit = new Clerk();
Approver rahul = new AssistantManager();
Approver manoj = new Manager();

rohit.Successor = rahul;
rahul.Successor = manoj;

// Generate and process loan requests
var loan = new Loan { Number = 2034, Amount = 24000.00, Purpose = "Laptop Loan" };
rohit.ProcessRequest(loan);

loan = new Loan { Number = 2035, Amount = 42000.10, Purpose = "Bike Loan" };
rohit.ProcessRequest(loan);

loan = new Loan { Number = 2036, Amount = 156200.00, Purpose = "House Loan" };
rohit.ProcessRequest(loan);

// Wait for user
Console.ReadKey();
