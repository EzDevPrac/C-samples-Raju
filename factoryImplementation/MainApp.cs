using Factory;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Factory
{
   public class MainApp
    {
       public static void Main(string[] args)
        {
            ObjectFactory Objectfactory = new ObjectFactory();
            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "ID", 1 }
            };
            Gmail gmail = Objectfactory.Get(ObjectType.gmail, data) as Gmail;
            Hotmail hotmail = Objectfactory.Get(ObjectType.hotmail, data) as Hotmail;

            Console.WriteLine(gmail.GetInfo());
            Console.WriteLine(hotmail.GetInfo());
            Console.ReadLine();
        }
    }




    public enum ObjectType
    {
        gmail,
        hotmail
    }

    }