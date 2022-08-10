using TTS_Banking_Console_App;

var account = new BankAccount("Jay", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with an initial balance of ${account.Balance}");
