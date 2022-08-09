// RapportModule
// Ontwerp een klasse Resultaat die je zal tonen wat je graad is gegeven een bepaald behaald percentage. Het enige dat je aan een Resultaat-object moet kunnen geven is het behaalde percentage. Enkel het totaal behaalde % wordt bijgehouden via een auto-property. Via een methode PrintGraad kan de behaalde graad weergegeven worden. Dit zijn de mogelijkheden:

// < 50: niet geslaagd;
// tussen 50 en 68: voldoende;
// tussen 68 en 75: onderscheiding;
// tussen 75 en 85: grote onderscheiding;
// \> 85: grootste onderscheiding.
// Test je klasse door enkele objecten in je main aan te maken en de verschillende properties waarden te geven en methoden aan te roepen. Deze code zou moeten werken:

Result mypoints = new Result();
mypoints.Percentage = 75;
mypoints.PrintGraad();
