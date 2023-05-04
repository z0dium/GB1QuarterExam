Console.Clear();
Console.WriteLine("Заполните массив строк для обработки. Для завершения наполнения массива введите пустую строку.");
string input = Console.ReadLine();
string initialArray = "";
while (input.Length > 0) {
    initialArray = initialArray + input + "\n";
    input = Console.ReadLine();
}

