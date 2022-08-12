//Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница





Console.Write("Введите число ");
int numbers = Convert.ToInt32(Console.ReadLine());
if(numbers <=7 & numbers >=1) { 
  if (numbers == 1 ) {
    Console.Write("Понедельник");
}
  if (numbers == 2){
    Console.Write("Вторник");
}
  if(numbers == 3) {
    Console.Write("Среда");
}
  if (numbers == 4){
    Console.Write("Четверг");
}
  if (numbers == 5) { 
     Console.Write("Пятница");
}
  if (numbers == 6) {
   Console.Write("Суббота");
  }
   if (numbers == 7) {
    Console.Write("Воскресенье");
}  
}
else {Console.Write("Ошибка. такого дня не существует");
}