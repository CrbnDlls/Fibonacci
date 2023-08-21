// See https://aka.ms/new-console-template for more information
using Fibonacci;

Console.WriteLine("Hello, World!");
uint i = 42;
Console.WriteLine($"{i}th Fibonacci number = {FibonacciCounter.GetFibonacciNumber(i)}");
Console.WriteLine($"{i}th Fibonacci number recursive = {FibonacciCounter.GetFibonacciNumberRecursive(i)}");