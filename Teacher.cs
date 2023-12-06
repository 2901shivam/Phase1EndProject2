using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1EndProject2
{
    public class Teacher
    {
        int id;
        string name;
        string cls;
        string section;

        public Teacher(int id,string name,string cls,string section)
        {
            this.id = id;
            this.name = name;
            this.cls = cls;
            this.section = section;

        }

        Teacher teacher;
        string filePath = "C:\\Users\\shiva\\OneDrive\\Desktop\\File1.txt.txt";
        List<Teacher>listOfTeacher=new List<Teacher>();
        
        
        

        public void StoreData(int id,string name ,string cls,string section)
        {
            teacher = new Teacher(id, name, cls, section);

            listOfTeacher.Add(teacher);

            Console.WriteLine("Data Added Successfully");

            SaveToFile();
        }

        public void SaveToFile()
        {
            List<string> line = new List<string>();
            foreach(var t in listOfTeacher)
            {
                line.Add($"Id:{t.id},Name:{t.name},Class:{t.cls},Section:{t.section}");

            }
            File.WriteAllLines(filePath, line);
        }

        public void RetrieveData()
        {
            string[] str = File.ReadAllLines(filePath);

            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }

        public void UdateData(int id)
        {
            foreach(var str in listOfTeacher)
            {
                if (str.id == id)
                {
                    Console.WriteLine("Enter the name for updation");
                    string name = Console.ReadLine();
                    str.name=name;
                    Console.WriteLine("Enter the class for updation");
                    string cls = Console.ReadLine();
                    str.cls=cls;
                    Console.WriteLine("Enter the section for updation");
                    string section = Console.ReadLine();
                    str.section=section;
                    Console.WriteLine("Data Update Successfully");

                }
            }
            SaveToFile();
        }
        
    }
}
