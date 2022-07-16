// программа выводит второе число трехзначного числа
//int secondNumber(int a){
//if (a / 100 == 0  ^ a / 100 > 9){
//int secondNum = -1;
//return secondNum;
//}

//else{
//int firststep = a / 10;
//int second = firststep % 10;
//return second;
//}
//}

//Console.WriteLine("введите трехзначное число ");
//int num = Convert.ToInt32(Console.ReadLine());
//int result = secondNumber(num);
//if (result == -1){
//    Console.WriteLine("число не трехзначное");
//}
//else{
//Console.WriteLine("вторая цифра = " + result );
//}



// программа выводит третью цифру или сообщает что ее нет

// Console.WriteLine("введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int m = 0;
// int number1 = num;
// int number = 0;
// int count = 0;
// while (number1 > 0){
   //  
    // count = count +1;
    // m = count;
    // number1 = number1 / 10;
// }
// if (m <= 2){
   //  Console.WriteLine( " третьей цифры нет ");
   //  }
    // 
// else{
   //  m = m - 3;
      //   if(m == 0){
        // number = num;
        // number = number % 100;
        // number = number % 10; 
        // }
        // else{
           //  while (m > 0){
            // num = num / 10;
            // number = num;
            // m = m - 1;
// }
// number = number % 100;
// number = number % 10;
// }
// Console.WriteLine(" третья цифра = " + number);
// }

// программа, которая по цифре, обозначающей день недели,проверяет, является ли этот день выходным.

int weekend(int a){
    if (a == 6){
    int freeday = 6;
    return freeday;
    }
    if (a == 7){
    int freeday = 7;
    return freeday;
    }
    
    if(a > 0 & a < 6){
        int workday = -2;
        return workday;
    }

    else{
        int inccorectday = -1;
        return inccorectday;
    }
}

Console.WriteLine("введите число от 1 до 7 ");
int num = Convert.ToInt32(Console.ReadLine());
int result = weekend(num);
    if (result == 6){
        Console.WriteLine("Это суббота - выходной день");
    }
    if (result == 7){
        Console.WriteLine("Это воскресень - выходной день");
    }

    if (result == -1){
        Console.WriteLine("Число должно быть от 1 до 7");
    }
    if(result == -2){
        Console.WriteLine("это рабочий день");
    }
