int fib1 = 0, fib2 = 1, fib3 = fib1 + fib2;

Console.WriteLine(fib1);
Console.WriteLine(fib2);

while (fib3 <= 100){
    fib3 = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib3;
    if (fib3 <=100)
        Console.WriteLine(fib3);
}