// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public delegate void SendMail();

public static void Main(string[] args)
{
    // new Program().UpdateStory?.Invoke();
    var a = new MyEvent();
    a.UpdateStory += HandleEvent;
    a.DoUpdate()

    }

public static void HandleEvent()
{
    System.Console.WriteLine("ygduf");
}

public class MyEvent
{

    public event SendMail UpdateStory;

    public void DoUpdate()
    {
        OnUpdate();
    }

    public void OnUpdate()
    {
        UpdateStory?.Invoke();
    }

}

