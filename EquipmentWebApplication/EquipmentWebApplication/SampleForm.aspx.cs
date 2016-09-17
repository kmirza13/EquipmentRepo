using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;

namespace EquipmentWebApplication
{
    //public class Equipment
    //{
    //    public string Name { get; set; }
    //    public int Number { get; set; }
    //}

    

    public partial class SampleForm : System.Web.UI.Page
    {
        //List<string> equipmentList = new List<string>();
        //List<int> equipmentNumberList = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string path = @"C:\Users\khurram\Downloads\Equipment Project\Equipment.csv";
        //    StreamReader oStreamReader = new StreamReader(path);

        //    if(!oStreamReader.EndOfStream)
        //    {
        //        string data = oStreamReader.ReadToEnd();
                //int equipmentNumber = -1;
                //Equipment objEquipment;
                //int count = 0;
                //MatchCollection m11 = Regex.Matches(data, @"<td>\s*(.+?)\s*</td>", RegexOptions.Singleline);
                //foreach (Match m in m11)
                //{
                //    count++;
                //    if (count % 2 != 0)
                //    {
                //        objEquipment = new Equipment();

                //        if (Int32.TryParse(m.Groups[1].Value, out equipmentNumber))
                //        {

                //            objEquipment.Number = equipmentNumber;
                //        }
                //    }
                //    else
                //    {
                //        objEquipment.Name = m.Groups[1].Value;
                //    }
                //    //equipmentList.Add(m.Groups[1].Value);
                //}

        //        MatchCollection matchCollection = Regex.Matches(data, @"<td>\s*(\d)\s*</td>", RegexOptions.Singleline);
        //        foreach (Match m in matchCollection)
        //        {
        //            int equipmentNumber = -1;
        //            if (Int32.TryParse(m.Groups[1].Value, out equipmentNumber))
        //            {
        //                equipmentNumberList.Add(equipmentNumber);
        //            }     
        //        }

        //        MatchCollection m2 = Regex.Matches(data, @"<td>([a-z]+)</td>", RegexOptions.Singleline);

        //        foreach (Match m in m2)
        //        {
        //            equipmentList.Add(m.Groups[1].Value);
        //        }
        //    }

        //}

        //protected void Button1_Click1(object sender, EventArgs e)
        //{
            //EquipmentDataAccessLayer.GetAllEquipments();
            //string path = @"C:\Users\khurram\Downloads\Equipment Project\Equipment.csv";
            //StreamReader oStreamReader = new StreamReader(path);

            //if (!oStreamReader.EndOfStream)
            //{
            //    string data = oStreamReader.ReadToEnd();
            //    MatchCollection matchCollection = Regex.Matches(data, @"<td>\s*(\d)\s*</td>", RegexOptions.Singleline);
            //    foreach (Match m in matchCollection)
            //    {
            //        int equipmentNumber = -1;
            //        if (Int32.TryParse(m.Groups[1].Value, out equipmentNumber))
            //        {
            //            equipmentNumberList.Add(equipmentNumber);
            //        }
            //    }

            //    MatchCollection m2 = Regex.Matches(data, @"<td>([a-z]+)</td>", RegexOptions.Singleline);

            //    foreach (Match m in m2)
            //    {
            //        equipmentList.Add(m.Groups[1].Value);
            //    }
            //}
        //}
    }
}