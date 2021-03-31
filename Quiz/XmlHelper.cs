using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
namespace Quiz
{
    public class XmlHelper
    {
        public  void Serialize(string fileName, List<QuestionBlock> questions)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));
            if (fileName.EndsWith(".xml"))
            {
                using (var fs = new FileStream(fileName, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, questions);
                }
            }
            if (!fileName.EndsWith(".xml"))
            {
                string FileName = fileName + ".xml";
                using (var fs = new FileStream(FileName, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, questions);
                }
            }
        }

        public static List<QuestionBlock> Deserialize(string filePath, List<QuestionBlock> questions)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<QuestionBlock>));

            using (var fs = new FileStream(filePath, FileMode.Open))
            {
                questions = xmlSerializer.Deserialize(fs) as List<QuestionBlock>;
                //foreach (var item in questions)
                //{
                //    foreach (var item2 in item.Answers)
                //    {
                        
                //    }

                //}
            }
            return questions;
        }

    }
}
