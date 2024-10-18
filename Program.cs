using System;

/*
- Haverá três escolas visitantes
    - A Escola A tem seis grupos visitantes (o número padrão)
    - A Escola B tem três grupos visitantes
    - A Escola C tem dois grupos visitantes

- Para cada escola visitante, execute as seguintes tarefas
    - Randomize os animais
    - Atribua os animais ao número correto de grupos
    - Imprima o nome da escola
    - Imprima os grupos de animais

*/


string[] pettingZoo = 
{
    "alpacas", "capivaras", "galinhas", "patos", "emas", "gansos", 
    "cabras", "iguanas", "cangurus", "lêmures", "llamas", "araras", 
    "avestruzes", "porcos", "pôneis", "coelhos", "ovelhas", "tartarugas",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
    int r = random.Next(i, pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
    }
}

string[,] AssignGroup(int groups = 6) 
{
   string[,] result = new string[groups, pettingZoo.Length/groups];

    int start = 0;

    for (int i = 0; i < groups; i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            result[i,j] = pettingZoo[start++];
        }
    }
    return result;
}

void PrintGroup(string[,] group) 
{
    for (int i = 0; i < group.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++) 
        {
            Console.Write($"{group[i,j]}  ");
        }
        Console.WriteLine();
    }
}
