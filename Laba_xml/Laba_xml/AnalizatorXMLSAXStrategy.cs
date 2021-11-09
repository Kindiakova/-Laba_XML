using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Laba_xml
{
    class AnalizatorXMLSAXStrategy: IAnalizatorXMLStrategy
    {
        public List<Dormitory> Search(Student sampleStudent)
        {
            List<Dormitory> result = new List<Dormitory>();
            var xmlReader = new XmlTextReader(@"C:\Users\Nata\Desktop\уник\ООП\Laba_xml\Laba_xml\XMLFile1.xml");
            Student curStudent = new Student();
            Dormitory curDorm = new Dormitory();
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "Dormitory")
                {
                    if (curDorm.studentsList.Count != 0) result.Add(curDorm);
                    curDorm = new Dormitory();
                    xmlReader.MoveToNextAttribute();
                    curDorm.number = xmlReader.Value;
                }
                if (xmlReader.Name == "Student")
                {
                    if (sampleStudent.dorm != "" && curDorm.number != sampleStudent.dorm) continue;
                    curStudent = new Student();
                    curStudent.dorm = curDorm.number;

                    while (xmlReader.MoveToNextAttribute())
                    {
                        if (xmlReader.Name == "Name")
                            if (sampleStudent.name != "" && xmlReader.Value != sampleStudent.name) break;
                            else curStudent.name = xmlReader.Value;
                        if (xmlReader.Name == "Surname")
                            if (sampleStudent.surname != "" && xmlReader.Value != sampleStudent.surname) break;
                            else curStudent.surname = xmlReader.Value;
                        if (xmlReader.Name == "Patronymic")
                            if (sampleStudent.patronymic != "" && xmlReader.Value != sampleStudent.patronymic) break;
                            else curStudent.patronymic = xmlReader.Value;
                        if (xmlReader.Name == "Faculty")
                            if (sampleStudent.faculty != "" && xmlReader.Value != sampleStudent.faculty) break;
                            else curStudent.faculty = xmlReader.Value;
                        if (xmlReader.Name == "Cathedra")
                            if (sampleStudent.cathedra != "" && xmlReader.Value != sampleStudent.cathedra) break;
                            else curStudent.cathedra = xmlReader.Value;
                        if (xmlReader.Name == "Year")
                            if (sampleStudent.year != "" && xmlReader.Value != sampleStudent.year) break;
                            else curStudent.year = xmlReader.Value;
                        if (xmlReader.Name == "Room")
                            if (sampleStudent.room != "" && xmlReader.Value != sampleStudent.room) break;
                            else curStudent.room = xmlReader.Value;
                        if (xmlReader.Name == "InDate")
                            if (sampleStudent.in_date != "" && xmlReader.Value != sampleStudent.in_date) break;
                            else curStudent.in_date = xmlReader.Value;
                        if (xmlReader.Name == "OutDate")
                            if (sampleStudent.out_date != "" && xmlReader.Value != sampleStudent.out_date) break;                            
                            else
                            {
                                curStudent.out_date = xmlReader.Value;
                                curDorm.studentsList.Add(curStudent);
                            }
                    }
                    
                }
            }
            if (curDorm.studentsList.Count != 0) result.Add(curDorm);
            xmlReader.Close();
            return result;
        }
            
    }
}
