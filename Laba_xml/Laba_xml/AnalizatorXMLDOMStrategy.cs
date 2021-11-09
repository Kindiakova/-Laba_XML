using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Laba_xml
{
    class AnalizatorXMLDOMStrategy: IAnalizatorXMLStrategy
    {
        public List<Dormitory> Search(Student sampleStudent)
        {
            List<Dormitory> result = new List<Dormitory>();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Nata\Desktop\уник\ООП\Laba_xml\Laba_xml\XMLFile1.xml");
            XmlNode xRoot = doc.DocumentElement;

            foreach(XmlNode dorm in xRoot.ChildNodes)
            {
                Dormitory curDorm = new Dormitory();
                curDorm.number = dorm.SelectSingleNode("@Number").Value;
                foreach (XmlNode stud in dorm)
                {
                    Student curStudent = new Student(curDorm.number, stud);
                    if (sampleStudent.Equal(curStudent)) curDorm.studentsList.Add(curStudent);
                }
                if (curDorm.studentsList.Count != 0) result.Add(curDorm);
            }
            return result;
        }

    }
}
