Waterpolospeler speler1 = new Waterpolospeler();
speler1.StelIn("Tim", 5, false, true);
System.Console.WriteLine(speler1.SpelersNaam);
System.Console.WriteLine(speler1.MutsNummer);
System.Console.WriteLine(speler1.IsDoelman);
System.Console.WriteLine(speler1.IsReserve);

Waterpolospeler speler2 = new Waterpolospeler();
speler2.StelIn("", -1, true, false);
System.Console.WriteLine(speler2.SpelersNaam);
System.Console.WriteLine(speler2.MutsNummer);
System.Console.WriteLine(speler2.IsDoelman);
System.Console.WriteLine(speler2.IsReserve);
