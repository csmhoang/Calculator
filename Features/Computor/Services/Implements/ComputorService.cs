namespace Calculator;

public class ComputorService : IComputorService
{
    public double EvaluateExpression(string expression)
    {
        List<string> tokens = Tokenize(expression);

        var values = new Stack<double>();
        Stack<string> operators = new();

        foreach (var token in tokens)
            if (double.TryParse(token, out var number))
            {
                values.Push(number);
            }
            else if (IsOperator(token))
            {
                while (operators.Count > 0 && HasHigherOperator(operators.Peek(), token))
                {
                    var result = ApplyOperator(operators.Pop(), values.Pop(), values.Pop());
                    values.Push(result);
                }

                operators.Push(token);
            }

        while (operators.Count > 0)
        {
            var result = ApplyOperator(operators.Pop(), values.Pop(), values.Pop());
            values.Push(result);
        }

        return Math.Round(values.Pop(), 2);
    }

    private List<string> Tokenize(string expression)
    {
        List<string> tokens = new();
        var currentNumber = "";

        foreach (var c in expression)
            if (char.IsDigit(c) || c == '.')
            {
                currentNumber += c;
            }
            else if (IsOperator(c.ToString()))
            {
                if (!string.IsNullOrEmpty(currentNumber))
                {
                    tokens.Add(currentNumber);
                    currentNumber = "";
                }

                tokens.Add(c.ToString());
            }
            else if (c == '%')
            {
                tokens.AddRange(currentNumber, "÷", "100");
                currentNumber = "";
            }

        if (!string.IsNullOrEmpty(currentNumber))
            tokens.Add(currentNumber);

        return tokens;
    }

    private static bool HasHigherOperator(string op1, string op2)
    {
        if (
            (op1 == "×" || op1 == "÷") &&
            (op2 == "+" || op2 == "-" || op2 == "×" || op2 == "÷")
        )
            return true;
        return false;
    }

    private double ApplyOperator(string op, double b, double a)
    {
        return op switch
        {
            "+" => a + b,
            "-" => a - b,
            "×" => a * b,
            "÷" => b != 0 ? a / b : throw new DivideByZeroException("Không thể chia cho 0!"),
            _ => throw new InvalidOperationException($"Toán tử không hợp lệ: {op}")
        };
    }

    private bool IsOperator(string c)
    {
        return c == "+" || c == "-" || c == "×" || c == "÷";
    }
}