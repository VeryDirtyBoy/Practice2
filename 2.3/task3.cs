using System;

public class Program
{
    class Calculation
    {
        private string calculationLine;

        public void SetCalculationLine(string line)
        {
            calculationLine = line;
        }
        
        public void SetLastSymbolCalculationLine(string letter)
        {
            calculationLine = calculationLine.Insert(calculationLine.Length, letter.ToString());
        }
        
        public string GetCalculationLine()
        {
            return calculationLine;
        }

        public char GetLastSymbol()
        {
            return calculationLine[calculationLine.Length - 1];
        }

        public void DeleteLastSymbol()
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }
    static void Main()
    {
        Calculation calculation = new Calculation();
        string a;
        Console.WriteLine("Введите строку: ");
        a = Console.ReadLine();
        calculation.SetCalculationLine(a);
        Console.WriteLine(calculation.GetCalculationLine()); 
        string b;
        Console.WriteLine("Введите символ: "); 
        b = Console.ReadLine();
        calculation.SetLastSymbolCalculationLine(b);
        Console.WriteLine($"Итог: {calculation.GetCalculationLine()}");
        Console.WriteLine($"Последний симвл: {calculation.GetLastSymbol()}");
        calculation.DeleteLastSymbol();
        Console.WriteLine($"Строка после удаления: {calculation.GetCalculationLine()}");
    }
}