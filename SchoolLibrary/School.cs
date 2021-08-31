using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    class School //auto properties, access modifiers for visibility
    {
       public string Name {get; set;}
       public string Address {get; set;}
       public string City {get; set;}
       public string State { get; set; }
       public string Zip {get; set;}
       public string PhoneNumber {get; set;}
       private string _twitterAddress; //backing variable
       public string TwitterAddress
        {
            //adding logic to set, make sure starts with @, encapsulation
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }else
                {
                    throw new Exception("Must start with @"); 
                }
            }

        }
        public School()//same name as class, for initialization, initial value of properties
        {
            Name = "Untitled School";
            PhoneNumber = "555-5555";
        }

        public School(string SchoolName, string SchoolPhoneNumber)//new constructor using instantiation
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c) //creating method
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;//function bodied expression
        
        public static int AverageThreeScores(int a, int b, int c)//create another method new return type, polymorphism
        {
            var result = (a + b + c) / 3;
            return result;
        
        }
        public override string ToString() //to string method using string builder
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Address);
            sb.AppendLine(this.City);
            //sb.Append(",");
            sb.Append(this.State);
            sb.Append(" ");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
