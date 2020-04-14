using System;
using System.Collections.Generic;

namespace factoryImplementation
{
    class factoryPattern
    {
        static void Main(string[] args)
        {
            objectFactory Objectfactory = new objectFactory();
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("ID", 1);
            gmail gmail = Objectfactory.Get(ObjectType.gmail, data) as gmail;
            hotmail hotmail = Objectfactory.Get(ObjectType.hotmail, data) as hotmail;

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



    //class Fcatory

    public class objectFactory
    {

        private ObjectType _type;
        private Dictionary<string, object> _data;
        public IObject Get(ObjectType type, Dictionary<string, object> data)
        {
            _type = type;
            _data = data;
            return GetObject();
        }


        private IObject GetObject()
        {
            IObject obj = null;



            Int32 id = Convert.ToInt32(_data["ID"]);

            switch (_type)
            {
                case ObjectType.gmail:
                    if (id == 1)
                    {
                        obj = new gmail()
                        {
                            emailId = "who@gmail.com",
                            name = "who",
                            phoneNo = 1234569
                        };
                    }
                    break;


                case ObjectType.hotmail:
                    if (id == 1)
                    {
                        obj = new hotmail()
                        {
                            emailId = "who@hotmail.com",
                            name = "who",
                            phoneNo = 1234569
                        };
                    }

                    break;

                default:
                    obj = null;
                    break;
            }


            return obj;
        }


    }

    public interface IObject
    {
        string getInfo();
    }



    public class gmail : IObject
    {
        public string emailId;
        public string name;
        public Int32 phoneNo;


        public virtual string getInfo()
        {
            return string.Format("Emailid is {0}.Name of sender is {1}. Phone number of the sender is {2}.", emailId, name, phoneNo);
        }



    }


    public class hotmail : IObject
    {
        public string emailId;
        public string name;
        public Int32 phoneNo;

        public virtual string getInfo()
        {
            return string.Format("Emailid is {0}.Name of sender is {1}. Phone number of the sender is {2}.", emailId, name, phoneNo);
        }


    }
}
