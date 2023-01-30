Console.WriteLine("Введите количество элементов массива: ");
int size  = Convert.ToInt32(Console.ReadLine());;

string[] array = new string[size];

for (int i = 0; i < size; i++){
	Console.Write($"Введите элемент массива № {i + 1}: ");
    string? result = Console.ReadLine();
	array[i] = result;  
}

Console.WriteLine("Введенный массив [{0}] из " + size + $" элементов\n", string.Join(", ", array));

int count = 0;
int max = 3;

for (int i = 0; i < array.Length; i++)
{
	if(array[i].Length <= max){
		count++;
	}   
}

string[] array1 = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= max){
        array1[j] = array[i];
        j++;
    }
}
Console.WriteLine("Получаем массив [{0}] из " + count + $" элементов, длина которых меньше, либо равна 3 символам\n", string.Join(", ", array1));