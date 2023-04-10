using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    class Autofill
    {
        MyDB MyDB = new MyDB();
        CUSTOMER cUSTOMER = new CUSTOMER();
        List<string> lHo = new List<string>();
        List<string> lTen = new List<string>();
        List<string> lTenLot = new List<string>();
        Random rd = new Random();
        BILL bill = new BILL();
        public string TenKhachHang()
        {
            lHo.Add("Lê");
            lHo.Add("Trần");
            lHo.Add("Nguyễn");
            lHo.Add("Tạ");
            lHo.Add("Đặng");
            lHo.Add("Lâm");
            lHo.Add("Hoàng");
            lHo.Add("Võ");
            lHo.Add("Đỗ");
            lHo.Add("Lý");

            lTen.Add("Dũng");
            lTen.Add("Cường");
            lTen.Add("Thái");
            lTen.Add("Thủy");
            lTen.Add("Như");
            lTen.Add("Hiền");
            lTen.Add("Duy");
            lTen.Add("Hà");
            lTen.Add("Duy");
            lTen.Add("Chương");
            lTen.Add("Hoà");
            lTen.Add("Khiêm");
            lTen.Add("Phong");
            lTen.Add("Như");
            lTen.Add("An");
            lTen.Add("Khoa");
            lTen.Add("Phúc");

            lTenLot.Add("Văn");
            lTenLot.Add("Thị");
            lTenLot.Add("Thị Ngọc");
            lTenLot.Add("Thị Thu");
            lTenLot.Add("Bảo");
            lTenLot.Add("Hoàng");
            lTenLot.Add("Quốc");
            lTenLot.Add("Phúc");
            lTenLot.Add("Mạnh");

            int slHo = lHo.Count();
            int slTen = lTen.Count();
            int slTenLot = lTenLot.Count();



            return lHo[rd.Next(0, slHo)] + " " + lTenLot[rd.Next(0, slTenLot)] + " " + lTen[rd.Next(0, slTen)];


        }

        public string CMND()
        {

            string cmt = "24183";
            return cmt + rd.Next(10, 99).ToString()+ rd.Next(10, 99).ToString();
        }
        public string Phone()
        {
            string phone = "039743";

            return phone + rd.Next(10, 90).ToString()+ rd.Next(10, 90).ToString();
        }

        public void ThemKhachHang()
        {

            for (int i = 0; i < 100; i++)
            {


                int billid = rd.Next(1000, 2000);

                for (int room = 101; room < 111; room++)
                {
                    int tien = rd.Next(1, 10) * 100000;
                    DateTime checkin = new DateTime(2021, room % 100, 22, 12, 1, 10);
                    bill.AddBill(room.ToString(), checkin, checkin.AddDays(2), -1, tien, 1);
                }
                cUSTOMER.AddCustomer(TenKhachHang(), CMND(), Phone(), billid, TenKhachHang(), 0);
            }
        }

        //public 
        public void AutoBill()
        {
            BILL BillSQL = new BILL();
            Room RoomSQL = new Room();
            STATISTIC StatisticSQL = new STATISTIC();
            EMPLOYEES EmployeeSQL = new EMPLOYEES();
            DataTable dataRoom = RoomSQL.GetAllRoom(true);
            DataTable dataEmployee = EmployeeSQL.GetAllEmployee(1);
            int countRoom = dataRoom.Rows.Count, countE = dataEmployee.Rows.Count;
            DateTime ds = new DateTime(2021, 1, 1, 0, 0, 0);
            DateTime de;
            string room = "";
            int pay = 0, j = 0;
            for (int i = 0; i < 145; i++)
            {
                int u = rd.Next(2, 5);
                for (int k = 0; k <u ; k++)
                {
                    room = dataRoom.Rows[(j+k)%countRoom]["room"].ToString();
                    pay = rd.Next(20, 200) * 10000;
                    de = ds.AddDays(rd.Next(1, 3));
                    de=de.AddHours(rd.Next(0, 24));
                    BillSQL.AddBill(room, ds, de, -1, pay, 1);
                    StatisticSQL.AddStatistic("Thanh toán phòng:" + room, pay, 1, de);
                }
                j += u;
                ds=ds.AddDays(1);
            }
            DataTable dataBill = BillSQL.GetAllBill();
            int id_bill = 0;
            foreach (DataRow item in dataBill.Rows)
            {
                
                id_bill = (int)item["id_bill"];
                cUSTOMER.AddCustomer(TenKhachHang(), CMND(), Phone(), id_bill, TenKhachHang(), 1);
            }
            DataTable dtK = new DataTable();
            foreach (DataRow item in dataBill.Rows)
            {
                
                room = item["room"].ToString();
                pay =(int)item["pay"];
                ds = (DateTime)item["checkin"];
                de = (DateTime)item["checkout"];
                id_bill = (int)item["id_bill"];
                dtK = cUSTOMER.GetCustomerByIDBill(id_bill);
                StatisticSQL.AddEvent("Giao phòng:" + room, pay, "Khách hàng:" + dtK.Rows[0]["name"].ToString(),
                    (int)dataEmployee.Rows[rd.Next(0, countE)]["id"], ds);
                StatisticSQL.AddEvent("Trả phòng:" + room, pay, "Khách hàng:" + dtK.Rows[0]["name"].ToString(),
                    (int)dataEmployee.Rows[rd.Next(0, countE)]["id"], de);
            }

            MessageBox.Show("Thành công");
        }

    }
}
