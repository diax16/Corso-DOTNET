/* esempio di ciclo for
esempio che escrivi i numeri da 1 a 10 */

for (int i = 1; i <= 10; i++)

{
    Console.WriteLine (i);
}
    
/* esempio di ciclo for che escribe tuo nome 10 volte*/

for (int i = 1; i <= 10; i++) 
{
    Console.WriteLine ("Stalin");
}


/* esempio di ciclo for che escribe tuo numero 10 volte con il concatenato 

for (int i = 1; i <= 5; i++) 
{
    Console.WriteLine ($"Stalin {i}");
}

for (int i = 1; i <= 5; i++) 
{
    Console.WriteLine ($"Diaz {i}");
}
//rallentare stampa utilizzando il metodo Thread.Sleep

for (int i = 1; i <= 10; i++) 
{
    Console.WriteLine (i);
    Thread.Sleep (1000); 
}  */

for (int i = 1; i <= 5; i++)
    
{
    Console.WriteLine ($"Stalin {i}");
}

for (int y = 6; y <= 10; y++) 
{
    Console.WriteLine ($"Diaz {y}");
}

/*esempio ciclo while che escrive i numeri progresssivi fino a quando lo utente chiaccia un tasto

Console.WriteLine("premi un tasto per iniziare");
Console.ReadKey();
int j = 1;
while (true)
{
    Console.WriteLine(j);
    j++;
    Thread.Sleep(1000);
    if (Console.KeyAvailable)
    {
        break;
    }
} */



// ESempio ciclo while
//Esempio che scrive il nome inserito dall utente fino a quando lo utente schiaccia un tasto

Console.WriteLine("inserisci un nome");
string nomeInserito = Console.ReadLine();
while (true)
{
    Console.WriteLine(nomeInserito);
    Thread.Sleep(1000);
    if (Console.KeyAvailable)
    {
        break;
    }
}