using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxList
{
    public class GetInfo
    {
        public GetInfo(CheckBoxList checkBoxList) 
        {
            checkBoxList.getinfo += new CheckBoxList.LayThongTinHandler(GetInformation);
        }
        public void GetInformation(CheckBoxList checkBoxList, Employee employee) 
        {
            if(checkBoxList.kiemtra(employee))
            {
                Console.WriteLine("ID :" + employee.EmployeeID);
            }
            else
            {
                Console.WriteLine("Khong co ID trong danh sach ");
            }
        }
    }
}
