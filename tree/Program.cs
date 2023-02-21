using System.Globalization;

Console.WriteLine("How Big do you wish your tree");
int input = Convert.ToInt32(Console.ReadLine());

string str = "";
string space = new string(' ', input);

for (int i = 0; i <= input; i++)
{
    for (int j = 0; j < input - i; j++)
    {
        str += " ";
    }
    for (int k = 0; k < 2 * i - 1; k++)
    {
        str += "X";
    }
    str += "\n";
    str += "\n";
}
Console.Write(str);
Console.WriteLine(space+"|");
Console.WriteLine(space+"|");