using DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ObjectFactory
    {
        private ObjectType _type;
        private Dictionary<string, object> _data;
        public IObject Get(ObjectType type, Dictionary<string, object> data)
        {
            _type = type;
            _data = data;
            return GetObject();
        }


        public IObject GetObject()
        {
            IObject obj = null;



            Int32 id = Convert.ToInt32(_data["ID"]);

            switch (_type)
            {
                case ObjectType.gmail:
                    if (id == 1)
                    {
                        obj = new Gmail()
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
                        obj = new Hotmail()
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
}
