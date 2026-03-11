try
{
  Console.WriteLine("Podaj pierwszą liczbę:");
  double a = Convert.ToDouble(Console.ReadLine());

  Console.WriteLine("Podaj drugą liczbę:");
  double b = Convert.ToDouble(Console.ReadLine());

  double avg = StatisticsHelper.Average(a, b);
  Console.WriteLine($"Średnia wynosi: {avg}");
}
catch
{
  Console.WriteLine("Błąd! Niepoprawne liczby!");
}
