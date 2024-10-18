using System.Runtime.InteropServices;
bool continuar = ShouldPlay();
Console.WriteLine("Game VS CPU");
Console.WriteLine("");

do 
{
    Random alvo = new Random();
    int target = alvo.Next(1,7);
    Console.WriteLine("escolhendo numeros");
    Thread.Sleep(2500);
    Console.WriteLine(target);

    Random dice = new Random();
    int roll = dice.Next(1,7);
    Console.WriteLine("Rolando os Dados!");
    Thread.Sleep(2500);
    Console.WriteLine(roll);

    WinorLose(roll, target);

continuar = ShouldPlay();
Console.WriteLine("");
} while (continuar == true);

bool ShouldPlay()
{
    Console.WriteLine("Deseja começar novamente? S/N");
    var resposta = Console.ReadKey().Key;
    if (resposta == ConsoleKey.S)
    {
        return true;
    }
    else if (resposta == ConsoleKey.N)
    {
        return false;
    }
    return false;
}

int WinorLose(int roll, int target) 
{
    if (roll < target)
    {
        Console.WriteLine("Infelizmente você perdeu!");
        return target;
    }
    else if (roll > target)
    {
        Console.WriteLine("Parabéns você Ganhou!");
        return roll;
    }
    else {
        Console.WriteLine("Empate!");
        return roll;
    }
}