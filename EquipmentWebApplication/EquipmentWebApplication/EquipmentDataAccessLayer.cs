using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace EquipmentWebApplication
{
    public class Equipment
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

    public class EquipmentDataAccessLayer
    {
        public static List<Equipment> GetAllEquipments()
        {
            List<Equipment> listEquipments = new List<Equipment>();

            string projectDir = AppDomain.CurrentDomain.BaseDirectory;

            string path = projectDir + "\\Equipment.csv";
            StreamReader oStreamReader = new StreamReader(path);

            if (!oStreamReader.EndOfStream)
            {
                string data = oStreamReader.ReadToEnd();
                MatchCollection matchCollection = Regex.Matches(data, @"<td>\s*(.+?)\s*</td>", RegexOptions.Singleline);
                Equipment objEquipment = new Equipment();
                int equipmentNumber = -1;
                bool isEquipmentNumber = false;
                foreach (Match m in matchCollection)
                {
                    isEquipmentNumber = Int32.TryParse(m.Groups[1].Value, out equipmentNumber);
                    if (!isEquipmentNumber)
                    {
                        objEquipment.Name = m.Groups[1].Value;
                        listEquipments.Add(objEquipment);
                    }
                    else
                    {
                        objEquipment = new Equipment();
                        objEquipment.Number = equipmentNumber;
                    }
                }
            }

            return listEquipments;
        }
    }
}