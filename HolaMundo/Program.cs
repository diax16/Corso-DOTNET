

Console.Clear();

string nome;     

nome = "Stalin";     

Console.WriteLine(nome);  

int eta;
eta = 40;

Console.WriteLine(eta);



bool presenza = true;
Console.WriteLine(presenza);
if (presenza)

{
    Console.WriteLine("Presente");
}
else
{
    Console.WriteLine("Ausente");
}
Console.WriteLine($"Me llamo {nome} y tengo {eta} anos y hoy estoy {presenza}");

if (presenza)
{
    Console.WriteLine($"Me llamo {nome} y tengo {eta} anos y hoy estoy Presente");
}
else
{
    Console.WriteLine($"Me llamo {nome} y tengo {eta} anos y hoy estoy Ausente");
}



/* chiedo al utente di inserire un dato e lo acquisisco in un variabile*/

Console.WriteLine("Inserici il tuo nome");
string nomeUtente = Console.ReadLine();
Console.WriteLine($"Ciao {nomeUtente}");

/* chiedo al utente di inserire un numero e lo acquisisco in un variabile*/

Console.WriteLine("Inserici un numero");
string numeroInserito = Console.ReadLine();
Console.WriteLine($"hai inserito il numero {numeroInserito}");

//converto la stringa in un intero in modo di poter fare delle operazioni matematiche con il numero

int numero = Convert.ToInt32(numeroInserito);
Console.WriteLine($"Il doppio del numero inserito è {numero * 2}");


//esempio di operazioni matematica

int a = 10;
int b = 20;
int somma = a+b;
Console.WriteLine($"La somma tra {a} e {b} è {somma}");

//esempio operazione matematico con i numeri inseriti dall utente

Console.WriteLine("inserici il numero");
string numero1 = Console.ReadLine();
Console.WriteLine("inserici un altro numero");
string numero2 = Console.ReadLine();
int n1 = Convert.ToInt32(numero1);
int n2 = Convert.ToInt32(numero2);
int sommaNumeri = n1 + n2;
Console.WriteLine($"La somma tra {n1} e {n2} è {sommaNumeri}");


//dirmi si n1 e n2 sono iguale 

/*hola bool numeri = false;
Console.WriteLine(numeri);
if (numeri)

{
    Console.WriteLine("n1");
}
else
{
    Console.WriteLine("n2");
}
Console.WriteLine($"I numeri {n1} e {n2} sono iguale? {numeri}"); */


//esempi condizzioni

if (n1 > n2)

{
    Console.WriteLine($"{n1} è maggiore di {n2}");
}
else if (n2 < n1)
{
    Console.WriteLine($"Il numero {n1} è maggiore di {n2}");
}
else
{
    Console.WriteLine($"Il numero {n1} è uguale a {n2}");
}















