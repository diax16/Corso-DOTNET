// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Stalin");

Console.Clear();    //pulishe console

string nome;     //dichiarazione di una variabile tipo string

nome = "Stalin";     //assegno di un valore alla variabile

Console.WriteLine(nome);  //stampa del valore della variabile

int eta;
eta = 40;

Console.WriteLine(eta);


//concatenazione di stringhe

Console.WriteLine($"Mi chiamo {nome} ed ho {eta} anni");

bool presenza = false;
Console.WriteLine(presenza);
if (presenza)

{
    Console.WriteLine("Presente");
}
else
{
    Console.WriteLine("Asente");
}
Console.WriteLine($"Mi chiamo {nome} ed ho {eta} anni ed oggi sono {presenza}");

/*voglio scrivere Mi chiamo Stalin e oggi sono presente
quindi devono essere stampate le seguenti stringhe*/

if (presenza)
{
    Console.WriteLine($"Mi chiamo {nome} ed ho {eta} anni ed oggi sono presente");
}
else
{
    Console.WriteLine($"Mi chiamo {nome} ed ho {eta} anni ed oggi sono assente");
}

