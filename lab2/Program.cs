Console.WriteLine("Hello, Jerry");

void PrintABC()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

PrintABC();
Thread.Sleep(500); 
PrintABC();
Thread.Sleep(500);
PrintABC();

void A()
{
    Console.WriteLine("Функция A");
    B();
    C();
}

void B()
{
    Console.WriteLine("Функция B");
}

void C()
{
    Console.WriteLine("Функция C");
}

A(); 
A(); 
