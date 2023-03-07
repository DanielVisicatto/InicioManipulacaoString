string name = Console.ReadLine();

Console.WriteLine("Hello {0}!", name);
Console.WriteLine(name.Length); // conta caracteres inclusivo espaço
Console.WriteLine(name.ToLower());// nome
Console.WriteLine(name.ToUpper());//NOME
Console.WriteLine(name.Trim('e')); // só remove instancias do inicio e fim d stream
Console.WriteLine(name[2]);// 3a letra de name

RemoveVowels(name);

void RemoveVowels(string x)
{

    x.Replace('a', '\0');
    x.Replace('e', '\0');
    x.Replace('i', '\0');
    x.Replace('o', '\0');
    x.Replace('u', '\0');

    Console.WriteLine(x);
}