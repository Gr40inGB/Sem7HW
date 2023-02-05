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

// существует только шесть вариантов использования «правила вычитания»:

// IV = 4       v/i = 5     
// IX = 9       x/i = 10
// XL = 40      l/x = 5
// XC = 90      c/x = 10
// CD = 400     d/c = 5
// CM = 900     100/100 = 10

// Задание выполнено без проверки кооректности римских чисел

int[] GetDecodeFromRomNumbers(string romNubersLine)
{
    int i = 1, v = 5, x = 10, l = 50, c = 100, d = 500, m = 1000;
    int I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000;

    int[] arrayToCalc = new int[romNubersLine.Length];

    for (int j = 0; j < romNubersLine.Length; j++)
    {
        switch (romNubersLine[j])
        {
            case 'i':
                arrayToCalc[j] = i; break;
            case 'v':
                arrayToCalc[j] = v; break;
            case 'x':
                arrayToCalc[j] = x; break;
            case 'l':
                arrayToCalc[j] = l; break;
            case 'c':
                arrayToCalc[j] = c; break;
            case 'd':
                arrayToCalc[j] = d; break;
            case 'm':
                arrayToCalc[j] = m; break;
            case 'I':
                arrayToCalc[j] = I; break;
            case 'V':
                arrayToCalc[j] = V; break;
            case 'X':
                arrayToCalc[j] = X; break;
            case 'L':
                arrayToCalc[j] = L; break;
            case 'C':
                arrayToCalc[j] = C; break;
            case 'D':
                arrayToCalc[j] = D; break;
            case 'M':
                arrayToCalc[j] = M; break;
        }
    }
    return arrayToCalc;
}

int ConvertToArabic(int[] DecodedRom)
{
    int arabicNumber = 0;
    int hillIndex = 0; /// Индекс в котором обнаружилось повышение числа - значит нужно будет отнять от него предыдущее

    for (int count = 0; count < DecodedRom.Length; count++)
    {
        if (count != DecodedRom.Length - 1 && DecodedRom[count] < DecodedRom[count + 1])
        {
            hillIndex = count + 1;
            // проверяем что соответствует правилам существования IV = 4 XL = 40  XC = 90  CD = 400  CM = 900
            if (DecodedRom[hillIndex] / DecodedRom[count] == 10 || DecodedRom[hillIndex] / DecodedRom[count] == 5)
            {
                arabicNumber = arabicNumber + DecodedRom[hillIndex] - DecodedRom[count];
                count++;
            }
        }
        else
        {
            arabicNumber += DecodedRom[count];
        }
    }
    return arabicNumber;
}

void Main()
{
    System.Console.WriteLine("Программа конвертирует римское число в десятичное арбское."
                           + "\nВведите римское число (I. i, V, v ,X, x, L, l, C, c, D, d, M, m): ");
    string romNumberString = Console.ReadLine()!;
    System.Console.WriteLine(ConvertToArabic(GetDecodeFromRomNumbers(romNumberString)));
}

Main();