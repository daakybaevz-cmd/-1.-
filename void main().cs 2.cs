void main()
{
        bool isStudent = true;
        bool isPensioner = false;
        bool hasClubCard = true;

  а
        if ((isStudent || isPensioner) && hasClubCard)
        {
            print("Поздравляем! Вам доступна максимальная скидка 30% на билет.");
        }
        else if (isStudent || isPensioner)
        {
            print("У вас льготный статус, но без клубной карты скидка только 10%.");
        }
        else
        {
            print("Скидки не предусмотрены. Стандартная стоимость билета.");
        }
    }





    // {
    //     double sum = 3500; 
    //     double discountPercent = 0;

        
    //     if (sum >= 5000)
    //     {
    //         discountPercent = 25.0; 
    //     }
    //     else if (sum >= 3000)
    //     {
    //         discountPercent = 15.0; 
    //     }
    //     else
    //     {
    //         discountPercent = 5.0;  
    //     }

        
    //     double discountAmount = sum * (discountPercent / 100);
    //     double finalSum = sum - discountAmount;

        
    //     print($"Исходная сумма: {sum} сом.");
    //     print($"Вам предоставлена скидка: {discountPercent}%");
    //     print($"Сумма скидки: {discountAmount} сом.");
    //     print($"Итого к оплате: {finalSum} сом.");
    // }


  
  
    // {
    //     String name = "Тимур";
    //     String status = "студент";

    
    //     if (name == "Тимур" && status == "студент")
    //     {
    //         print($"Добро пожаловать, {name}! Ваш статус: {status}. Доступ к студенческому порталу разрешен.");
    //     }
    //     else if (status == "рабочий" || status == "клерк")
    //     {
    //         print($"Здравствуйте, {name}. Вы сотрудник компании, доступ ограничен рабочим временем.");
    //     }
    //     else
    //     {
    //         print($"Пользователь {name} со статусом '{status}' не распознан системой.");
    //     }
    // }
