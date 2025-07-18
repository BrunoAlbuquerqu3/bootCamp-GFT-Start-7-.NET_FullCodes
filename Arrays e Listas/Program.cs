

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("BH");
//Testando ultrapassar capacidade da lista
 Console.WriteLine($"Items da minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("RJ");

Console.WriteLine($"Items da minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Items da minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");
 

Console.WriteLine("\n Percorrendo uma lista com FOR ");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}

Console.WriteLine("\n Percorrendo uma lista com FOREACH ");
int contadordoForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição Nº {contadordoForeach} - {item}");
    contadordoForeach++;
}



int[] arrayinteiros = new int[4];

arrayinteiros[0] = 1;
arrayinteiros[1] = 10;
arrayinteiros[2] = 12;
arrayinteiros[3] = 11;

Console.WriteLine("\n Testando array com o FOR");
for (int contador = 0; contador < arrayinteiros.Length; contador++)
{
    Console.WriteLine($"O numero da posição {contador}º é : {arrayinteiros[contador]}");
}


Console.WriteLine("\n Testando array com foreach");
int contadorForeach = 0;

foreach (int valor in arrayinteiros)
{
    Console.WriteLine($"O numero da posição {contadorForeach}º é : {valor}");
    contadorForeach++;
}
 