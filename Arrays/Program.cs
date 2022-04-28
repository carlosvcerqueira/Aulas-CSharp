using System.Diagnostics;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[,] marcas_veiculos = new string[,] {
{"audi", "automovel"},
{"kim", "mota"}
};
//Console.WriteLine(marcas_veiculos[0, 1] + " - " + marcas_veiculos[1,1]);
//Console.WriteLine(marcas_veiculos[1, 0]);
/* Instruções condicionais
 * if
 */
/*int x = 1;
if (x < 5)
    {
        Console.WriteLine("OK!");
    }
else
{
    Console.WriteLine("Não!");
};

string nome1 = "Carlos";
string nome2 = "Cerqueira";
if (nome1 == "Carlos" || nome2 == "Ana")
{
    Console.WriteLine("Sim!");
}
else if (nome1 == "Antonio")
{
    Console.WriteLine("Terceiro boco");
}
else
{
    Console.WriteLine("Não...");
}

string nome = "Carlos";

switch (nome)
{
    case "ana":
    case "manoel":
    case "carlos":
        Console.WriteLine("Primeiro Bloco");
        break;

    case "joão":
        Console.WriteLine("Segundo bloco");
        break;

    case "Carlos":
        goto case "ana";
        //Console.WriteLine("Terceiro bloco");
        //break;
    default:
        Console.WriteLine("Outro bloco");
        break;
}*/

// Operador ternário

/*
int x = 10;
string nome = x < 20 ? "João" : "Carlos";
Console.WriteLine(nome);    
*/

// CICLO WHILE

/*int i = 0;
while (i < 10)
{
    Console.WriteLine(i.ToString());
    i++;
}*/

// CICLO DO WHILE

/*int i = 0;
do
{
    Console.WriteLine(i.ToString());
    i++;
} while (i < 10);
*/

/* // CICLO FOR

for (int a = 1, b = 10; a < 10; a++, b--)
{
    Console.WriteLine((a * b).ToString());
}

//ou 

int c = 0;
for (; ; )
{
    Console.WriteLine(c.ToString());
    c++;
    if (c == 10) break;
}*/

// CICLO FOREACH

string[] nomes = new string[] { "joão", "ana", "carlos" };
foreach(string n in nomes)
{
    Console.WriteLine(n);
}

// CICLOS BEAK E CONTINUE

for (int i = 0; i < 10; i++)
{
    if (i == 5) break;
    if (i == 3) continue;
    Console.WriteLine(i.ToString());
}