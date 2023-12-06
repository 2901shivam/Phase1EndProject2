using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1EndProject2
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            string op = "yes";
            Teacher teacher1=new Teacher(1,"abc","12A","A2");
            do
            {
                try
                {
                    Console.WriteLine("Enter 1:Store Teacher data 2:Retrieve Teacher data 3:Update Teacher Data");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter Id:");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Name:");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter Class:");
                                string cls = Console.ReadLine();
                                Console.WriteLine("Enter Section");
                                string section = Console.ReadLine();
                                
                                teacher1.StoreData(id,name,cls,section);
                                break;
                            }
                        case 2:
                            {
                               
                                teacher1.RetrieveData();
                                
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Enter Id:");
                                int id = int.Parse(Console.ReadLine());
                                teacher1.UdateData(id);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid input");
                                break;
                            }
                    }
                    Console.WriteLine("Enter yes if you want to coninue");
                    op = Console.ReadLine();

                }catch(Exception e)
                {
                    Console.WriteLine("Error Occured"+e.Message);
                }

            }
            
            while (op=="yes");
        }
    }
}
