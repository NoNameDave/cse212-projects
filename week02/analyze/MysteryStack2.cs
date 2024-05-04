using System;
using System.Collections.Generic;

public static class MysteryStack2
{
    private static bool IsFloat(string text)
    {
        return float.TryParse(text, out _);
    }

    public static float Run(string text)
    {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' '))
        {
            if (string.IsNullOrWhiteSpace(item))
                continue;

            if (item == "+" || item == "-" || item == "*" || item == "/")
            {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1: Not enough operands for the operation.");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res = 0;
                switch (item)
                {
                    case "+":
                        res = op1 + op2;
                        break;
                    case "-":
                        res = op1 - op2;
                        break;
                    case "*":
                        res = op1 * op2;
                        break;
                    case "/":
                        if (op2 == 0)
                            throw new ApplicationException("Invalid Case 2: Division by zero.");
                        res = op1 / op2;
                        break;
                }

                stack.Push(res);
            }
            else if (IsFloat(item))
            {
                stack.Push(float.Parse(item));
            }
            else
            {
                throw new ApplicationException("Invalid Case 3: Invalid input '" + item + "'.");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4: The stack should have exactly one element after processing all inputs.");

        return stack.Pop();
    }
}