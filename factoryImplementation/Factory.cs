using Factory;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Factory
{
   public class Factory
    {
       public static void Main(string[] args)
        {
            ObjectFactory Objectfactory = new ObjectFactory();
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("ID", 1);
            Gmail gmail = Objectfactory.Get(ObjectType.gmail, data) as Gmail;
            Hotmail hotmail = Objectfactory.Get(ObjectType.hotmail, data) as Hotmail;

            Console.WriteLine(gmail.getInfo());
            Console.WriteLine(hotmail.getInfo());
            Console.ReadLine();
        }
    }




    public enum ObjectType
    {
        gmail,
        hotmail
    }

    }