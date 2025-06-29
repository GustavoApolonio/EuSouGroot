string resposta = " Eu sou Groot";
string pergunta = "";
Console.Clear();
Console.WriteLine(@"--- Groot Chatbot ---");

while (pergunta != "tchau")
{
    Console.Write("Pergunta:   "); pergunta = Console.ReadLine()!.ToLower();
    if (pergunta != "tchau")
    {
    Console.WriteLine($"     Resposta: {resposta}.");}

    else if (pergunta == "tchau")
    {
        Console.WriteLine($"     Resposta:{resposta}!");
    }
}
