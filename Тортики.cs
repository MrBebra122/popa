using System;
using System.IO;


    private void Menu()
    {
        Console.WriteLine("Заказ торта:");
        Console.WriteLine("  1. Форма торта: " + form);
        Console.WriteLine("  2. Глазурь торта: " + razmer);
        Console.WriteLine("  3. Размер: " + vkus);
        Console.WriteLine("  4. Вкус: " + glazur);
        Console.WriteLine("  5. Декор: " + vneshka);
        Console.WriteLine("  6. Завершить заказ и сохранить");
        Console.WriteLine("  ESC. Выход из заказа");
    }

    private void CakeForma()
    {
        Console.Clear();
        Console.WriteLine("Выберите формочку торта:");
        Console.WriteLine("  1. Круг - 70рублей");
        Console.WriteLine("  2. Квадрат - 100рублей");
        Console.WriteLine("  3. Четырёхугогльник - 125рублей");
        Console.WriteLine("  4. Сердечко - 300рублей");
        Console.WriteLine("  ESC. Выход из раздела");
        int position = 1;
        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");

            if (key.Key == ConsoleKey.UpArrow && position > 1)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow && position < 4)
            {
                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                form = "круг";
                totalPrice += 70;
            }
            else if (position == 2)
            {
                form = "Квадрат";
                totalPrice += 100;
            }
            else if (position == 3)
            {
                form = "Четырёхугольник";
                totalPrice += 125;
            }
            else if (position == 4)
            {
                form = "Сердечко";
                totalPrice += 300;
            }
            Console.Clear();
        }
        else if (key.Key == ConsoleKey.Escape)
        {

            Console.Clear();
        }
    }

private void CakeGlazur()
{
    Console.Clear();
    Console.WriteLine("Введите глазурь для торта:");
    Console.WriteLine("  1. Шоколад - 300рублей");
    Console.WriteLine("  2. Персик - 200рублей");
    Console.WriteLine("  3. Ананас - 200рублей");
    Console.WriteLine("  4. Яблоко - 220рублей");
    Console.WriteLine("  ESC. Выход из раздела");
    int position = 1;

    ConsoleKeyInfo key = Console.ReadKey();
    while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
    {
        Console.SetCursorPosition(0, position);
        Console.WriteLine("  ");

        if (key.Key == ConsoleKey.UpArrow && position > 1)
        {
            position--;
        }
        else if (key.Key == ConsoleKey.DownArrow && position < 4)
        {
            position++;
        }
        Console.SetCursorPosition(0, position);
        Console.WriteLine("->");

        key = Console.ReadKey();
    }
    if (key.Key == ConsoleKey.Enter)
    {
        if (position == 1)
        {
            glaze = "шоколад";
            totalPrice += 300;
        }

        else if (position == 2)
        {
            glaze = "персик";
            totalPrice += 200;
        }
        else if (position == 3)
        {
            glaze = "ананс";
            totalPrice += 200;
        }
        else if (position == 4)
        {
            glaze = "яблоко";
            totalPrice += 220;
        }
        Console.Clear();
    }
    else if (key.Key == ConsoleKey.Escape)
    {

        Console.Clear();
    }
}
private void CakeRazmer()
    {
        Console.Clear();
        Console.WriteLine("Выберите размер торта:");
        Console.WriteLine("  1. Мааааааленький - 150рублей");
        Console.WriteLine("  2. Средний - 250рублей");
        Console.WriteLine("  3. Большооооой - 1000рублей");
        Console.WriteLine("  ESC. Выход из раздела");

        int position = 1;

        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow && position > 1)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow && position < 3)
            {
                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                razmer = "мааааааленький";
                totalPrice += 60;
            }

            else if (position == 2)
            {
                razmer = "средний";
                totalPrice += 80;
            }
            else if (position == 3)
            {
                razmer = "большооооой";
                totalPrice += 1000;
            }
            Console.Clear();
        }
        else if (key.Key == ConsoleKey.Escape)
        {

            Console.Clear();
        }
    }
    private void CakeVkus()
    {
        Console.Clear();
        Console.WriteLine("Выберите вкус торта:");
        Console.WriteLine("  1. Ванильный - 100рублей");
        Console.WriteLine("  2. Шоколадный - 160рублей");
        Console.WriteLine("  3. Картошечный - 250рублей");
        Console.WriteLine("  4. Черничный - 400рублей");
        Console.WriteLine("  ESC. Выход из раздела");
        int position = 1;

        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");

            if (key.Key == ConsoleKey.UpArrow && position > 1)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow && position < 4)
            {
                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                vkus = "ванильный";
                totalPrice += 100;
            }

            else if (position == 2)
            {
                vkus = "шоколадный";
                totalPrice += 160;
            }
            else if (position == 3)
            {
                vkus = "картошечный";
                totalPrice += 250;
            }
            else if (position == 4)
            {
                vkus = "черничный";
                totalPrice += 400;
            }
            Console.Clear();
        }
        else if (key.Key == ConsoleKey.Escape)
        {

            Console.Clear();
        }
    }
    
    private void CakeDecor()
    {
        Console.Clear();
        Console.WriteLine("Введите декор торта:");
        Console.WriteLine("  1. сердечки - 100рублей");
        Console.WriteLine("  2. Ягоды - 100рублей");
        Console.WriteLine("  3. Пицца - 900рублей");
        Console.WriteLine("  4. Палочки - 90рублей");
        Console.WriteLine("  ESC. Выход из раздела");
        int position = 1;
        ConsoleKeyInfo key = Console.ReadKey();
        while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
        {
            Console.SetCursorPosition(0, position);
            Console.WriteLine("  ");

            if (key.Key == ConsoleKey.UpArrow && position > 1)
            {
                position--;
            }
            else if (key.Key == ConsoleKey.DownArrow && position < 4)
            {
                position++;
            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                decor = "сердечки";
                totalPrice += 180;
            }

            else if (position == 2)
            {
                decor = "ягода";
                totalPrice += 100;
            }
            else if (position == 3)
            {
                decor = "пицца";
                totalPrice += 900;
            }
            else if (position == 4)
            {
                decor = "палочки";
                totalPrice += 90;
            }
            Console.Clear();
        }
        else if (key.Key == ConsoleKey.Escape)
        {

            Console.Clear();
        }
    }
class Program
{
    static void Main()
    {
        CakeOrder cakeOrder = new CakeOrder();
        cakeOrder.zakaz();
    }
}
class CakeOrder
{
    private string form;
    private string glazur;
    private string razmer;
    private string vkus;
    private string decor;
    private float totalPrice;
    private DateTime ZakazTime;

    public void zakaz()
    {
        int position = 1;
        while (true)
        {
            Menu();
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
                break;

            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && position > 1)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow && position < 6)
                {
                    position++;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape)
                    break;
            }
            if (key.Key == ConsoleKey.Escape)
                break;
            if (position == 1)
            {
                CakeForm();
            }
            else if (position == 2)
            {
                CakeGlazur();
            }
            else if (position == 3)
            {
                CakRazmer();
            }
            else if (position == 4)
            {
                CakeVkus();
            }
            else if (position == 5)
            {
                CakeDecor();
            }
            else if (position == 6)
            {
                FinishCake();
                break;

            }
        }
    }
    private void FinishCake()
    {
        Console.Clear();
        Console.WriteLine("Торт готов!");
        Console.WriteLine("Итоговая цена: " + totalPrice + " руб.");
        ZakazTime = DateTime.Now;
        Console.WriteLine("Время заказа: " + ZakazTime);

        string filePath = "Tortik.txt";
        string txt = "1)Форма торта:" + form + "\t 2)Глазурь торта:" + glazur + "\t 3)Размер торта:" + razmer + "\t 4)Вкус торта:" + vkus + "\t 5)Декор торта:" + decor + "\t Итоговая цена:" + totalPrice + "рублей" + "\t Время заказа:" + ZakazTime;
        File.AppendAllText(filePath, txt);
        Console.WriteLine("Заказ сохранен в файле tortik.txt");
    }
}