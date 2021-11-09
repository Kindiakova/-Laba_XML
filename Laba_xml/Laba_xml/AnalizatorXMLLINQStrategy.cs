using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Laba_xml
{
    class AnalizatorXMLLINQStrategy: IAnalizatorXMLStrategy
    {
        public List<Dormitory> Search(Student sampleStudent)
        {            
            List<Dormitory> result = new List<Dormitory>();
            var doc = XDocument.Load(@"C:\Users\Nata\Desktop\уник\ООП\Laba_xml\Laba_xml\XMLFile1.xml");
           
            foreach (var obj in doc.Descendants("Dormitory"))
            {                
                if (sampleStudent.dorm != "" && obj.Attribute("Number").Value != sampleStudent.dorm) continue;
                Dormitory dorm = new Dormitory();
                dorm.number = obj.Attribute("Number").Value;
               
                List<XElement> students = (from stud in obj.Descendants("Student")
                                           where
                                           (
                                            (sampleStudent.name == "" || sampleStudent.name == stud.Attribute("Name").Value)
                                            && (sampleStudent.surname == "" || sampleStudent.surname == stud.Attribute("Surame").Value)
                                            && (sampleStudent.patronymic == "" || sampleStudent.patronymic == stud.Attribute("Patronymic").Value)
                                            && (sampleStudent.faculty == "" || sampleStudent.faculty == stud.Attribute("Faculty").Value)
                                            && (sampleStudent.cathedra == "" || sampleStudent.cathedra == stud.Attribute("Cathedra").Value)
                                            && (sampleStudent.year == "" || sampleStudent.year == stud.Attribute("Year").Value)
                                            && (sampleStudent.room == "" || sampleStudent.room == stud.Attribute("Room").Value)
                                            && (sampleStudent.in_date == "" || sampleStudent.in_date == stud.Attribute("InDate").Value)
                                            && (sampleStudent.out_date == "" || sampleStudent.out_date == stud.Attribute("OutDate").Value)
                                           )
                                           select stud).ToList();
                foreach (XElement stud in students)
                {
                    dorm.studentsList.Add(new Student(stud));
                }
                if (dorm.studentsList.Count != 0) result.Add(dorm);
                 
            }

            return result;
        }
    }
}


