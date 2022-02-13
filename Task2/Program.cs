using System;
/// <summary>
/// Создайте класс AbstractHandler.
///В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
///Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
///Написать программу, которая будет выполнять определение документа 
///и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.
/// </summary>
namespace Task2
{
    class Program
    {
        static void Main()
        {
            AbstractHandler[] abstractHandlers = new AbstractHandler[3];
            abstractHandlers[0] = new XMLHandlerclass();
            abstractHandlers[1] = new TXTHandlerclass();
            abstractHandlers[2] = new DOCHandler();
            foreach (AbstractHandler item in abstractHandlers)
            {
                item.Open();
                item.Create();
                item.Chenge();
                item.Save();
            }

            Console.ReadKey();
        }
    }
    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Chenge();
        abstract public void Save();
    }
    class XMLHandlerclass : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт XML файл");
        }
        public override void Create()
        {
            Console.WriteLine("Создан XML файл");
        }
        public override void Chenge()
        {
            Console.WriteLine("Изменен XML файл");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен XML файл");
        }
    }
    class TXTHandlerclass : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт TXT файл");
        }
        public override void Create()
        {
            Console.WriteLine("Создан TXT файл");
        }
        public override void Chenge()
        {
            Console.WriteLine("Изменен TXT файл");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен TXT файл");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт DOC файл");
        }
        public override void Create()
        {
            Console.WriteLine("Создан DOC файл");
        }
        public override void Chenge()
        {
            Console.WriteLine("Изменен DOC файл");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен DOC файл");
        }
    }
}
