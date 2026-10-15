 
 void main() {
 
    
        // Задаем жетон прямо в коде (например, "красный")
        String token = "красный";

        switch (token.toLowerCase())
        {
            case "зеленый":
            print ("Ваш напиток: Эспрессо.");
                break;
            case "красный":
            print("Ваш напиток: Капучино.");
                break;
            case "синий":
            print("Ваш напиток: Латте.");
                break;
            default:
            print("Ошибка: неверный жетон.");
                break;
        }
    }

 