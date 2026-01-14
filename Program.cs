// See https://aka.ms/new-console-template for more information
int  c = 0;

void tambah (int a, int b)
{
   c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}
void kurang  (int a, int b)
{
   c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}
void kali  (int a, int b)
{
   c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}
void bagi  (int a, int b)
{
   c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(1,2);
kurang(1,2);
kali(1,2);
bagi(1,2);