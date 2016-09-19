using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace EquipmentWebApplication
{
    public class MaintenanceWork
    {
        public int MaintenanceWorkId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string WorkDescription { get; set; }
        public int EquipmentId { get; set; }
        public string TimeTaken { get; set; }
    }

    public class MaintenanceWorkDataAccessLayer
    {
        public static List<MaintenanceWork> GetAllMaintenanceWorks()
        {
            List<MaintenanceWork> listMaintenanceWorks = new List<MaintenanceWork>();

            string projectDir = AppDomain.CurrentDomain.BaseDirectory;

            string path = projectDir + "\\MaintenanceWorks.csv";
            StreamReader oStreamReader = new StreamReader(path);

            if (!oStreamReader.EndOfStream)
            {
                string data = oStreamReader.ReadToEnd();
                MatchCollection matchCollection = Regex.Matches(data, @"<td>\s*(.+?)\s*</td>", RegexOptions.Singleline);
                MaintenanceWork objMaintenanceWork = new MaintenanceWork();
                int maintenanceWorkId = -1;
                string date = null;
                string time = null;
                string workDescription = null;
                int equipmentId = -1;
                string timeTaken = null;

                int indexId = 1;
                //int counter = 1;
                //bool isMaintenanceWorkId = false;
                foreach (Match m in matchCollection)
                {
                    switch (indexId)
                    {
                        case 1: //MaintenanceWorkId
                            objMaintenanceWork = new MaintenanceWork();
                            Int32.TryParse(m.Groups[1].Value, out maintenanceWorkId);
                            objMaintenanceWork.MaintenanceWorkId = maintenanceWorkId;
                            break;
                        case 2: //Date
                            objMaintenanceWork.Date = m.Groups[1].Value;
                            break;
                        case 3: //Time
                            objMaintenanceWork.Time = m.Groups[1].Value;
                            break;
                        case 4: //WorkDescription
                            objMaintenanceWork.WorkDescription = m.Groups[1].Value;
                            break;
                        case 5: //EquipmentId
                            Int32.TryParse(m.Groups[1].Value, out equipmentId);
                            objMaintenanceWork.EquipmentId = equipmentId;
                            break;
                        case 6: //TimeTaken
                            objMaintenanceWork.TimeTaken = m.Groups[1].Value;
                            break;     
                    }

                    indexId++;
                    if (indexId > 6)
                    {
                        listMaintenanceWorks.Add(objMaintenanceWork);
                        indexId = 1;
                    }
                }

            }

            return listMaintenanceWorks;

        }
    }
}