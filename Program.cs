// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры.
// [«hello», «2», «world», «:-)»] -> [«2», «:-)»]
// [«12345», «1234», «-2»] -> [«-2»]


string[] array = InputArray();
string[] result = OutputArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] OutputArray(string[] input, int n) {
    string[] output = new string[CountLessThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}
string[] InputArray(){
    Console.Write("Введите массив, разделяя элементы пробелами: ");
    return Console.ReadLine().Split(" ");
}