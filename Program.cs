Console.Clear();
Console.WriteLine("Заполните массив строк для обработки. Для завершения наполнения массива введите пустую строку.");
string input = Console.ReadLine();
if (input.Length == 0) Console.WriteLine("Вы не ввели ни одного элемента массива. Программа завершена.");
else {
    string processingString = "";
    while (input.Length > 0) {
        processingString = processingString + input + "\n";
        input = Console.ReadLine();
    }
    PrintArray(RemoveUnnecessaryStrings(BuildArrayFromInput(processingString)));
}

string[] BuildArrayFromInput (string inputToProcess){
    return inputToProcess.Split("\n",StringSplitOptions.RemoveEmptyEntries);
}

string[] RemoveUnnecessaryStrings(string[] arrayToProcess){
    string processingString = "";
    for (int i=0; i < arrayToProcess.Length; i++){
        if (arrayToProcess[i].Length < 4) processingString = processingString + arrayToProcess[i] + "\n";
    }
    return processingString.Split("\n",StringSplitOptions.RemoveEmptyEntries);
}

void PrintArray(string[] arrayToPrint){
    Console.Write("[");
    for (int i=0; i < arrayToPrint.Length; i++) {
        Console.Write(arrayToPrint[i]);
        Console.Write(i == arrayToPrint.Length - 1 ? "" : ", ");
    }
    Console.Write("]");
}
