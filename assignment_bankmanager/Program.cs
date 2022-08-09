Account rekening1 = new Account();
Account rekening2 = new Account();

rekening1.AccountState = AccountStates.Geldig;
rekening1.Bedrag = 100;
rekening1.Naam = "Jan";
rekening1.RekeningNummer = "1234";

rekening2.AccountState = AccountStates.Geldig;
rekening2.Bedrag = 200;
rekening2.Naam = "Jos";
rekening2.RekeningNummer = "4321";

System.Console.WriteLine(rekening1.Bedrag);
System.Console.WriteLine(rekening2.Bedrag);

rekening1.PayInFunds(50);
rekening2.PayInFunds(40);
System.Console.WriteLine("rekening 1 +50, rekening2 +40");
System.Console.WriteLine(rekening1.Bedrag);
System.Console.WriteLine(rekening2.Bedrag);

rekening1.WithdrawFunds(151);
rekening2.WithdrawFunds(40);
System.Console.WriteLine("rekening 1 -151(meer dan op rekening stond), rekening2 -40");
System.Console.WriteLine(rekening1.Bedrag);
System.Console.WriteLine(rekening2.Bedrag);

rekening1.TransferMoney(rekening2, 100);
System.Console.WriteLine("100 van rekening1 naar rekening 2");
System.Console.WriteLine(rekening1.Bedrag);
System.Console.WriteLine(rekening2.Bedrag);

rekening1.TransferMoney(rekening2, 1000);
System.Console.WriteLine("1000 van rekening1 naar rekening 2");
System.Console.WriteLine(rekening1.Bedrag);
System.Console.WriteLine(rekening2.Bedrag);

rekening1.TransferMoney(rekening2, -1000);
System.Console.WriteLine("-1000 van rekening1 naar rekening 2");
System.Console.WriteLine(rekening1.Bedrag);
System.Console.WriteLine(rekening2.Bedrag);
