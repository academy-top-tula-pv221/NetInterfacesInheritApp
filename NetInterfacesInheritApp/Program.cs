namespace NetInterfacesInheritApp
{
    interface IFirst
    {
        void FirstMethod();
    }
    interface ISecond : IFirst
    {
        void SecondMethod(); 
    }
    class MyClass : ISecond
    {
        public void FirstMethod()
        {
            Console.WriteLine("FirstMethod");
        }

        public void SecondMethod()
        {
            Console.WriteLine("SecondMethod");
        }
    }
    interface IMessage
    {
        string Text { get; set; }
    }
    interface IPrintable
    {
        void Print();
    }
    class Message : IMessage, IPrintable
    {
        public Message(string text)
        {
            Text = text;
        }
        public string Text { get; set; }

        public void Print()
        {
            Console.WriteLine(Text);
        }
    }
    class Messenger<T> where T:IMessage, IPrintable
    {
        public void Send(T message)
        {
            Console.WriteLine($"Send {message.Text}");
            message.Print();
        }
    }

    interface IPerson<T>
    {
        T Id { set; get; }
    }

    class Person<T> : IPerson<T>
    {
        public T Id { set; get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ISecond first = new MyClass();
            first.FirstMethod();
        }
    }
}