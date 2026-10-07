﻿﻿/*
* Name: Preston Offutt  
* Course: CSCI 1250, Section 001
* Assignment: Lab 4, The Group Trip
* Date: October 7, 2026
* Description: Finds total cost for a group trip of 4.
*/


const double taxRate = 0.18;
const int slicesPerPizza = 8;


//Part 1: The Trip

System.Console.Write("How many miles is your round trip? ");
double roundTripMiles = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How many miles per gallon does your car get? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is the price per gallon of gas in dollars? $");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How many pizzas? ");
int numberOfPizzas = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What is the price per pizza? $");
double priceofPizza = Convert.ToDouble(Console.ReadLine());

double totalSlices = numberOfPizzas * slicesPerPizza;
double slicesPerPerson = totalSlices / 4;
double pizzaCost = numberOfPizzas * priceofPizza;
double tripTotal = FuelCost(roundTripMiles, milesPerGallon, pricePerGallon) + pizzaCost;
double costPerPerson = tripTotal / 4;

System.Console.WriteLine("=== Part 1: The Trip ===");
System.Console.WriteLine($"Fuel Cost: {FuelCost(roundTripMiles, milesPerGallon, pricePerGallon).ToString("C")}");
System.Console.WriteLine($"Pizza Cost: {pizzaCost.ToString("C")}");
System.Console.WriteLine($"Trip Total: {tripTotal.ToString("C")}");

//Part 2: The Group

string[] names = ["Ada", "Grace", "Alan", "Katherine"];
double[] hoursWorked = [ 22, 15, 30, 18 ];
double[] hourlyRates = [ 13.50, 16.00, 11.20, 14.80 ];

System.Console.WriteLine("=== Part 2: The Group ===");
System.Console.WriteLine($"People going: {names.Length}");
System.Console.WriteLine($"Slices Each: {slicesPerPerson}");
System.Console.WriteLine($"Cost per person: {costPerPerson}");






//Methods

static double FuelCost(double roundTripMiles, double milesPerGallon, double pricePerGallon)
{
    double gallonsNeeded = roundTripMiles / milesPerGallon;
    return gallonsNeeded * pricePerGallon;
}

static double TakeHomePay(double hoursWorked, double hourlyRate, double taxRate)
{
    double grossPay = hoursWorked * hourlyRate;
    double taxWithheld = grossPay * taxRate;
    return grossPay - taxWithheld;
}

static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}