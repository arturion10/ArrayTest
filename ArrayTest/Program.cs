// 1. Дан одномерный массив целых чисел.

int[] arrNumb = {3, 5, 10, 4, 1, 6, 9};

// - Сделать из два отсортированных по возрастанию массива содержащих четные и нечетные числа
// (использовать готовые библиотеки для сортировки)

var arrSortEven = arrNumb.OrderBy(x=>x).Where(x => x % 2 == 0);
var arrSortOdd = arrNumb.OrderBy(x => x).Where(x => x % 2 == 1);
foreach (var numb in arrSortEven)
{
    Console.Write($"{numb} ");
}
Console.WriteLine();
foreach(var numb in arrSortOdd)
{
    Console.Write($"{numb} ");
}
Console.WriteLine();

// - Найти разницу между максимальным и минимальным числом

var decrementResult = arrNumb.Max(x => x) - arrNumb.Min(x => x);
Console.WriteLine(decrementResult);

// - Определить, является ли расположение чисел в массиве упорядоченным(т.е. по возврастанию или убыванию)

// первый способ
int ficsation1 = 0;
for(int i = 0; i < arrNumb.Length-1; i++)
{
    if(arrNumb[i] - arrNumb[i+1] > 0)
    {
        ficsation1++;
    }
}
int ficsation2 = 0;
for (int i = 0; i < arrNumb.Length - 1; i++)
{
    if (arrNumb[i] - arrNumb[i + 1] < 0)
    {
        ficsation2++;
    }
}
if(ficsation1 == arrNumb.Length - 1)
{
    Console.WriteLine("Массив упорядочен по убыванию.");
}
else if (ficsation2 == arrNumb.Length - 1)
{
    Console.WriteLine("Массив упорядочен по возрвствнию.");
}
else
{
    Console.WriteLine("Массив не упорядочен");
}
// второй способ
ficsation1 = 0;
ficsation2 = 0;
var arrSort = arrNumb.OrderBy(x => x).ToArray();
var arrSortDescending = arrNumb.OrderByDescending(x => x).ToArray();
for (int i = 0; i < arrSort.Length; i++)
{
    if(arrNumb[i] == arrSortDescending[i])
    {
        ficsation1++;
    }
}
for (int i = 0; i < arrSort.Length; i++)
{
    if (arrNumb[i] == arrSort[i])
    {
        ficsation2++;
    }
}
if (ficsation1 == arrNumb.Length)
{
    Console.WriteLine("Массив упорядочен по убыванию.");
}
else if (ficsation2 == arrNumb.Length)
{
    Console.WriteLine("Массив упорядочен по возрвствнию.");
}
else
{
    Console.WriteLine("Массив не упорядочен");
}

// - Обнулить элементы массива расположеные между его минимальным и максимальным элементами

var indexMax = Array.IndexOf(arrNumb, arrNumb.Max(x => x));
var indexMin = Array.IndexOf(arrNumb, arrNumb.Min(x => x));
if(indexMax > indexMin)
{
    for (int i = indexMin + 1; i < indexMax; i++)
    {
        arrNumb[i] = 0;
    }
}
else
{
    for (int i = indexMax + 1; i < indexMin; i++)
    {
        arrNumb[i] = 0;
    }
}
foreach(var item in arrNumb)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

// 2. Дан двумерный массив целых чисел

int[,] arrTwoNums = new int[2,5] { { 1, 22, 4, -5, -7}, { -3, 54, 5, -10, 64 } };

// - Подсчитать количество отрицательных и положительных элементов

var positiveNum = 0;
var negativeNum = 0;
foreach(var item in arrTwoNums)
{
    if(item > 0)
    {
        positiveNum++;
    }
    else if(item < 0)
    {
        negativeNum++;
    }
}
Console.WriteLine($"Количество положительных чисел: {positiveNum} \nКоличество отрицательных чисел: {negativeNum}");

// - Отсортировать каждую нечетную строку по возврастанию, а каждую четную по убыванию

int temp;
var countStrings = 2;
for(int i = 0; i < countStrings; i++)
{
    if (i % 2 == 0)
    { 
        for (int j = 0; j < arrTwoNums.GetLength(i); j++)
        {
            for (int k = j + 1; k < arrTwoNums.GetLength(i); k++)
            {
                if(arrTwoNums[i, j] > arrTwoNums[i, k])
                {
                    temp = arrTwoNums[i, j];
                    arrTwoNums[i, j] = arrTwoNums[i, k];
                    arrTwoNums[i, k] = temp;
                }
            }
        }
    }
    else if(i % 2 == 1)
    {
        for (int j = 0; j < arrTwoNums.GetLength(i); j++)
        {
            for (int k = j + 1; k < arrTwoNums.GetLength(i); k++)
            {
                if (arrTwoNums[i, j] < arrTwoNums[i, k])
                {
                    temp = arrTwoNums[i, j];
                    arrTwoNums[i, j] = arrTwoNums[i, k];
                    arrTwoNums[i, k] = temp;
                }
            }
        }
    }
}

foreach(var a in arrTwoNums)
{
    Console.WriteLine(a);
}

// 3. Метод принимает два массива, возвращает один, объедененный

Console.WriteLine("Укажите длину первого массива: ");
var lengthFirstArray = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите длину второго массива: ");
var lengthSecondArray = int.Parse(Console.ReadLine());
int[] firstArray = new int[lengthFirstArray];
int[] secondArray = new int[lengthSecondArray];
Console.WriteLine("Вводите числа в первый массив через Enter: ");
for (int i = 0; i < lengthFirstArray; i++)
{
    firstArray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вводите числа в второй массив через Enter: ");
for (int i = 0; i < lengthFirstArray; i++)
{
    secondArray[i] = int.Parse(Console.ReadLine());
}
int[] resultCount = CountArray<int>(firstArray, secondArray);

// 4. Сформируй массив целых чисел по алгоритму фибоначи 1-ый и 2-ой элемент равный 1,
// а каждый последующий сумме двух предыдущих, т.е. : 1, 1, 2, 3, 5, 8 ... . Найдите сумму и произведение его членов

int[] fibonachi = new int[10];
fibonachi[0] = 1;
fibonachi[1] = 1;
for(int i = 2; i < resultCount.Length; i++)
{
    fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
}
var sum = 0;
var multiplication = 1;
foreach(int i in fibonachi)
{
    sum += i;
    multiplication += i;
}
Console.WriteLine($"Сумма членов массива фибоначи равно {sum}, а произведения {multiplication}");

// 5. Метод который вычесляет сумму и произведение двух матриц (не обязательно квадратных) с проверкой размерностей.

int[,,] SumMatricsThreeDimensional(int[,,] firstArray, int[,,] secondArray)
{
    try 
    {
        if (firstArray.GetLength(0) == secondArray.GetLength(0) &&
            firstArray.GetLength(1) == secondArray.GetLength(1) &&
            firstArray.GetLength(2) == secondArray.GetLength(2))
        {
            throw new Exception("Разрядности не равны");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    int[,,] newArray = new int[firstArray.GetLength(0), firstArray.GetLength(1), firstArray.GetLength(2)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
        for (int j = 0; j < firstArray.GetLength(1); j++)
            for (int k = 0; k < firstArray.GetLength(2); k++)
            newArray[i, j, k] = firstArray[i, j, k]+ secondArray[i, j, k];
    return newArray;
}

// 6. Реализуй метод сортировки массива(алгоритм придумай сам)

T[] CountArray<T>(T[] first, T[] second)
{
    T[] result = new T[first.Length + first.Length];
    for (int i = 0; i < first.Length; i++)
        result[i] = first[i];
    for (int j = 0; j < second.Length; j++)
        result[first.Length + j] = second[j];
    return result;
}