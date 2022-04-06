/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [] */

 void My_array(string[]arg)
{
    string result=string.Empty;
    for (int i = 0; i < arg.Length; i++)
    {
        result=arg[i];
        int length= arg[i].Length;
        if (length<3)
        {
            
            
        }
        
        
            
    }
}
string[] argum = {"hello", "2", "world", ":-)"};
My_array(argum); 

/* void FineWords (string alphabet, char[] word, int length=0  )
{
    if(length==word.Length)
    {
        Console.WriteLine($" {new string(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length]=alphabet[i];
        FineWords(alphabet, word, length+1);
    }
}
FineWords("aисв", new char[2]); */
