
namespace LeetCode.Solutions
{
    public class Temp
    {
        public void getType(string type){
            switch (type)
            {
            case string str when str.Equals("string", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("string");
            break;
            case string str when str.Equals("int", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("int");
            break;
            case string str when str.Equals("bool", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("bool");
                    break;
                default:
                throw new ArgumentException("Invalid type", nameof(type));
        }

    }

     public void getType2(string type){
            switch (type, StringComparison.OrdinalIgnoreCase)
            {
                case ("string", _):
                    Console.WriteLine("string");
                    break;
                case ("int", _):
                    Console.WriteLine("int");
                    break;
                case ("bool", _):
                    Console.WriteLine("bool");
                    break;
                default:
                    throw new ArgumentException("Invalid type", nameof(type));
            }
        }
        public void getType3(string houseName)
        {
           var result =  houseName switch
            {
                string str when str.Equals("MyHouse", StringComparison.OrdinalIgnoreCase) => "MyWindow",
                string str when str.Equals("YourHouse", StringComparison.OrdinalIgnoreCase) => "",
                string str when str.Equals("House", StringComparison.OrdinalIgnoreCase) => "Window",
                _ => throw new ArgumentException("Invalid house name", nameof(houseName))
            };
        }

    }
 }
