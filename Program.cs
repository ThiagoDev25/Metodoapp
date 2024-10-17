string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
   string firstName = corporate[i, 0].Substring(0, 2);
    string lastName = corporate[i, 1];
    string email = $"{firstName}{lastName}@Contoso.com";
    Console.WriteLine(email);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    string email = $"{external[i, 0]}@{externalDomain}";
    Console.WriteLine(email);
}