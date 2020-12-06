using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge_4
{

    public abstract class IFamily
    {
        public string Address { get; }

        public string FamilyName { get; }

        public bool IsNice { get; set; }

        public  string Nice();

        public IFamily() { }

        public IFamily(string address, string familyname, bool isnice)
        {


            Address = address;
            FamilyName = familyname;
            IsNice = isnice;
        }

    }



    public class Father : IFamily
    {


        public string Address { get; set; }

        public string FamilyName { get; set; }

        public bool IsNice { get; set; }

        public bool IsPremium { get; set; }

        public Father(bool isPrem, string address, string familyName, bool isNice)
            : base(address, familyName, isNice)

        {
        IsPremium=isPrem;
        }
        public bool IsNice { get; set; }
        public string Nice()
        {
            IsNice = true;
            return "yes";
        }
    }

    class Mother : IFamily
    {

        public string Address
        {
            get { return "54872 Barclay ct"; }
        }
        public string FamilyName
        {
            get { return "MallemLouda"; }
        }

        public bool IsNice { get; set; }

        public string Nice()
        {
            IsNice = false;
            return "The mother is rude sometimes";

        }

    }
}

