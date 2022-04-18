using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    /// <summary>
    /// Основные функции приложения
    /// </summary>
    public class Application
    {
        public static string GetApplication(string a, string b)
        {
            var c = a + b;
            if (a == null) return "Ошибка";
            if (b == null) return "Ошибка";
            return "Хорошо";

        }



    }
}
/// <summary>
/// Основные функции для работы со списком задач
/// </summary>
public class TaskList
{
    public static string name(string g, string h)
    {
        var c = g + h;
        if (g == null) return "Ошибка";
        if (h == null) return "Ошибка";
        return "Хорошо";


    }



}

/// <summary>
/// Хранит сведения о задаче
/// </summary>
public class Task
{
    public static string title(string e, string r)
    {
        var q = e + r;
        if (e == null) return "Ошибка";
        if (r == null) return "Ошибка";
        return "Хорошо";
    }

    
}
