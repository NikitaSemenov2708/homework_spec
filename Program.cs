/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [] */

 void My_array(string[]arg)
{
    string[] args=new string [0];
    for (int i = 0; i < arg.Length; i++)
    {
        int length= arg[i].Length;
        if (length<4)
        {
            string [] massive_temp= new string[args.Length+1];
            args.CopyTo(massive_temp,0);
            massive_temp[massive_temp.Length-1]=arg[i];
            args=massive_temp;
        }  

    }
Console.Write("[");    
Console.Write(string.Join(",", args));
Console.Write("]");
}
string[] argum = {"hello", "2", "world", ":-)"};
My_array(argum); 

