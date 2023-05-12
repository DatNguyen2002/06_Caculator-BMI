// See https://aka.ms/new-console-template for more information

double weight, Height;
// can nang nhan don vi KG
Console.Write("Nhap can Nang(kg): ");
weight = double.Parse(Console.ReadLine());
// chieu cao su dung don vi met
Console.Write("Nhap chieu cao(m): ");
Height = double.Parse(Console.ReadLine());

double bmi = weight / Math.Pow(Height,2);

Console.Write("BMI " + bmi);

if(bmi < 18.5)
    Console.WriteLine("\nUnderWeight");
else if(bmi < 25)
    Console.WriteLine("\nNormal");
else if(bmi <30)
    Console.WriteLine("\nOverWeight");
else if(bmi >= 30 )
    Console.WriteLine("\nObese");
