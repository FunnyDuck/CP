using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace CP_v1
{
    class File
    {
        static public void SaveGeolog(List<string> parameters, string fileName)
        {
            try
            {
            
                bool isExist = false;
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(System.IO.File.ReadAllText(fileName));
                string[] names = { "num", "name", "a1", "a2", "a3", "a4", "a5", "a6" };
                XmlAttribute[,] nameattr = new XmlAttribute[parameters.Count, 8];
                XmlElement []newsection = new XmlElement[parameters.Count];
                int j = 0;
                foreach (string section in parameters)
                {
                    string[] atr = section.Split(' ');
                    newsection[j] = doc.CreateElement("Section");
                    for (int i = 0; i < 8; i++)
                    {
                        nameattr[j,i] = doc.CreateAttribute(names[i]);
                        nameattr[j, i].Value = atr[i];
                        newsection[j].Attributes.Append(nameattr[j, i]);
                    }
                    j++;
                }
                XmlElement whereAdd = doc.CreateElement("Step");
                foreach (XmlElement current in doc.GetElementsByTagName("Step"))
                {
                    if (current.Attributes[0].Value == "Geolog")
                    {
                        isExist = true;
                        current.InnerXml = "";
                        current.InnerText = "";
                        whereAdd = current;
                    }
                }
                if (!isExist)
                {
                    XmlAttribute attr = doc.CreateAttribute("name");
                    attr.Value = "Geolog";
                    whereAdd.Attributes.Append(attr);
                }
                foreach (XmlElement current in newsection)
                    whereAdd.AppendChild(current);
                if (!isExist)
                    doc.DocumentElement.AppendChild(whereAdd);
                doc.Save(fileName);
            }
            catch
            {
                MessageBox.Show("Cannot open file for saving");
            }
        }
        static public void SaveCalcFund(string fileName, List<string> nameSection, List<fundamentWorkspace> parameters)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(System.IO.File.ReadAllText(fileName));
                foreach (XmlElement current in doc.GetElementsByTagName("Step"))
                {
                    if (current.Attributes[0].Value == "CalcFundament")
                    {
                        current.InnerXml = "";
                        current.InnerText = "";
                        foreach (string section in nameSection)
                        {
                            XmlElement newsection = doc.CreateElement("Section");
                            XmlAttribute nameattr = doc.CreateAttribute("name");
                            nameattr.Value = section;
                            newsection.SetAttributeNode(nameattr);
                            string str = "";
                            try
                            {
                                for (int i = 0; i < fundamentWorkspace.count; i++)
                                {
                                    str += (parameters[nameSection.FindIndex(t => t == section)].Iterator(i) + " ");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Error. There is no such element in list During writing into file");
                            }
                            newsection.InnerText = str;
                            current.AppendChild(newsection);
                        }
                    }
                }
                doc.Save(fileName);
            }
            catch
            {
                MessageBox.Show("Cannot open file for saving");
            }
        }
        static public List<string> readGeologTable(string fileName)
        {
            List<string> param = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(System.IO.File.ReadAllText(fileName));
            foreach (XmlElement current in doc.GetElementsByTagName("Step"))
            {
                if (current.Attributes[0].Value == "Geolog")
                {
                    foreach (XmlElement section in current.GetElementsByTagName("Section"))
                    {
                        string str = "";
                        foreach (XmlAttribute attr in section.Attributes)
                        {
                            str += attr.Value + " ";
                        }
                        param.Add(str);
                    }
                }
            }
            return param;
        }
        static public List<string> readCalcFund(string fileName)
        {
            List<string> param = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(System.IO.File.ReadAllText(fileName));
            foreach (XmlElement current in doc.GetElementsByTagName("Step"))
            {
                if (current.Attributes[0].Value == "CalcFundament")
                {
                    foreach (XmlElement section in current.GetElementsByTagName("Section"))
                    {
                        string str = section.Attributes[0].Value+" ";
                        str += section.InnerText;
                        param.Add(str);
                    }
                }
            }
            return param;
        }
    }
}
