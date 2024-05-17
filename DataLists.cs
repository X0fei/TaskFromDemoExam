using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromDemoExam
{
    public static class DataLists
    {
        public static List<Users> Users = new List<Users>
        {
            new Users()
            {
                login = "Admin",
                password = "Admin",
                username = "Админов Админ Админович",
                role = "Admin"
            },
            new Users()
            {
                login = "Manager",
                password = "Manager",
                username = "Менеджеров Менеджер Менеджерович",
                role = "User"
            },
            new Users()
            {
                login = "User",
                password = "User",
                username = "Юрезов Юзер Юзерович",
                role = "User"
            }
        };
        public static List<Products> Products = new List<Products>
        {
            new Products()
            {
                name = "Молоко",
                category = "Молочные продукты",
                manufacturer = "\"Весёлая коровка\"",
                quantity = "200",
                measureUnit = "1 л",
                price = "89",
                description = "Пастеризованное, производится из нормализованного молока."
            },
            new Products()
            {
                name = "Хлеб",
                category = "Хлебобулочные изделия",
                manufacturer = "\"Усердная мельница\"",
                quantity = "1000",
                measureUnit = "1 шт.",
                price = "33",
                description = "Мука пшеничная хлебопекарная высшего сорта, вода питьевая, сахар, дрожжи хлебопекарные, масло подсолнечное нерафинированное, соль*, добавка комплексная пищевая (мука пшеничная хлебопекарная, мука пшеничная солодовая, антиокислитель - кислота аскорбиновая, ферментные препараты микробного происхождения), стабилизатор – ацетат кальция. *Для производства под цифрой 2: соль (соль, агент антислеживающий Е536)."
            },
            new Products()
            {
                name = "Стиральный порошок",
                category = "Бытовая химия",
                manufacturer = "\"Чистый дом\"",
                quantity = "176",
                measureUnit = "2 кг",
                price = "303",
                description = "Пастеризованное, производится из нормализованного молока."
            }
        };
        public static int currentId;
    }
}
