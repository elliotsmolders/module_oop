// See https://aka.ms/new-console-template for more information

Pizza pizza1 = new Pizza();

pizza1.Topping = "pineapple";
pizza1.Diameter = 2;
pizza1.Price = 4;
PrintProperties(pizza1);

pizza1.Topping = "pepperoni";
pizza1.Diameter = -1;
pizza1.Price = 4;
PrintProperties(pizza1);

pizza1.Topping = "";
pizza1.Diameter = 20;
pizza1.Price = 43;
PrintProperties(pizza1);

pizza1.Topping = "PINEapple";
pizza1.Diameter = 2;
pizza1.Price = -3;
PrintProperties(pizza1);

pizza1.Topping = "tuna";
pizza1.Diameter = 5;
pizza1.Price = 4;
PrintProperties(pizza1);

void PrintProperties(Pizza ClassToPrint)
{
    foreach (var property in ClassToPrint.GetType().GetProperties())
    {
        System.Console.WriteLine($"{property.Name} = {property.GetValue(ClassToPrint)}");
    }
    System.Console.WriteLine();
}
