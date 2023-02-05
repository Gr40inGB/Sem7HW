// Задача со звездочкой: Написать программу для
// перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

// 1	I	лат. unus, unum
// 5	V	лат. quinque
// 10	X	лат. decem
// 50	L	лат. quinquaginta
// 100	C	лат. centum
// 500	D	лат. quingenti
// 1000	M	лат. mille

int i = 1, v = 5, x = 10, l = 50, c = 100, d = 500, m = 1000;
int I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000;

System.Console.WriteLine("Введите римское число (i,v,x,l,c,d,m): ");
string romNumberString = Console.ReadLine()!;
int[] arrayToCalc = new int[romNumberString.Length];

for (int j = 0; j < romNumberString.Length; j++)
{
    switch (romNumberString[j])
    {
        case 'i':
            arrayToCalc[j] = i;
            break;
        case 'v':
            arrayToCalc[j] = v;
            break;
        case 'x':
            arrayToCalc[j] = x;
            break;
        case 'l':
            arrayToCalc[j] = l;
            break;
        case 'c':
            arrayToCalc[j] = c;
            break;
        case 'd':
            arrayToCalc[j] = d;
            break;
        case 'm':
            arrayToCalc[j] = m;
            break;
    }
}

System.Console.WriteLine(String.Join(", ", arrayToCalc));
int arabicNumber = 0;

for (int count = 0; count < arrayToCalc.Length; count++)
{
    int hillIndex = 0;
    if (count != arrayToCalc.Length - 1 && arrayToCalc[count] < arrayToCalc[count + 1])
    {
        hillIndex = count + 1;
        System.Console.WriteLine(hillIndex);
        if (arrayToCalc[hillIndex] / arrayToCalc[count] == 10 && arrayToCalc[hillIndex] / arrayToCalc[count] == 5)
        {
            arabicNumber = arabicNumber + arrayToCalc[hillIndex] - arrayToCalc[count];
        }
    }
    else
    {
        arabicNumber += arrayToCalc[count];
    }
    System.Console.WriteLine(arabicNumber);
}
System.Console.WriteLine(arabicNumber);



