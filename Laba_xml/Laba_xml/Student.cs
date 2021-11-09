using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Laba_xml
{
    public class Student
    {
        public string surname = "", name = "", patronymic = "";
        public string year = "";
        public string faculty = "", cathedra = "";
        public string room = "", dorm = "";
        public string in_date = "", out_date = "";
        public Student()
        {

        }

        public Student(string dormNum, XmlNode stud)
        {
            
            name = stud.SelectSingleNode("@Name").Value;
            surname = stud.SelectSingleNode("@Surname").Value;
            patronymic = stud.SelectSingleNode("@Patronymic").Value;
            year = stud.SelectSingleNode("@Year").Value;
            faculty = stud.SelectSingleNode("@Faculty").Value;
            cathedra = stud.SelectSingleNode("@Cathedra").Value;
            room = stud.SelectSingleNode("@Room").Value;
            dorm = dormNum;
            in_date = stud.SelectSingleNode("@InDate").Value;
            out_date = stud.SelectSingleNode("@OutDate").Value;
        }

        public bool Equal(Student curr)
        {
            if (surname != curr.surname && surname != "") return false;
            if (name != curr.name && name != "") return false;
            if (patronymic != curr.patronymic && patronymic != "") return false;
            if (year != curr.year && year != "") return false;
            if (faculty != curr.faculty && faculty != "") return false;
            if (cathedra != curr.cathedra && cathedra != "") return false;
            if (room != curr.room && room != "") return false;
            if (dorm != curr.dorm && dorm != "") return false;
            if (in_date != curr.in_date && in_date != "") return false;
            if (out_date != curr.out_date && out_date != "") return false;
            
            return true;
        }
        public Student(XElement stud)
        {
            surname = stud.Attribute("Surname").Value;
            name = stud.Attribute("Name").Value;
            patronymic = stud.Attribute("Patronymic").Value;
            year = stud.Attribute("Year").Value;
            faculty = stud.Attribute("Faculty").Value;
            cathedra = stud.Attribute("Cathedra").Value;
            room = stud.Attribute("Room").Value;
            in_date = stud.Attribute("InDate").Value;
            out_date = stud.Attribute("OutDate").Value;
        }

    }
}
