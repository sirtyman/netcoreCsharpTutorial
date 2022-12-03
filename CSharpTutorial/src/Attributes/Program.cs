using System;
using System.Reflection;


namespace MyAttributes
{


    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class BugInfo : System.Attribute
    {
        private string _bugIdentifier;
        private string _shortDescription;
        public BugInfo(string bugIdentifier)
        {
            _bugIdentifier = bugIdentifier;
            _shortDescription = "";
        }

        public string BugIdentifier
        {
            get { return _bugIdentifier; }
        }

        public string ShortDescription
        {
            get { return _shortDescription; }
            set { _shortDescription = value; }
        }
    }


    [BugInfo("Lgx00001", ShortDescription = "Assertion on ...")]
    internal class ExamplaryClass
    {
        [BugInfo("Lgx00002", ShortDescription = "Unsufficient memory reported on...")]
        public void ExemplaryMethod()
        {
            throw new NotImplementedException();
        }
    }


    public class Attribute
    {
        public static void Main(string[] args)
        {
            Type info = typeof(ExamplaryClass);


            foreach (object attr in info.GetCustomAttributes(false))
            {
                BugInfo bi = attr as BugInfo;

                if (null != bi)
                {
                    System.Console.WriteLine($"{bi.BugIdentifier}, {bi.ShortDescription}");
                }
            }

            foreach (MethodInfo methodInfo in info.GetMethods())
            {
                foreach(var attr in methodInfo.GetCustomAttributes<BugInfo>())
                {
                    if (null != attr)
                    {
                        System.Console.WriteLine($"{attr.BugIdentifier}, {attr.ShortDescription}");
                    }    
                }                
            }
            return;
        }
    }

}