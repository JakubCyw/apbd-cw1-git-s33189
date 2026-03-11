try
{
  Console.WriteLine("Podaj pierwszą liczbę:");
  double a = Convert.toDouble(Console.ReadLine());

  Console.WriteLine("Podaj drugą liczbę:");
  double b = Convert.toDouble(Console.ReadLine());

  double avg = StatisticsHelper.Aberage(a, b);
  Console.WriteLine($"Średnia wynosi: {avg}");
}
catch
{
  Console.WriteLine("Błąd! Niepoprawne liczby!")
}
