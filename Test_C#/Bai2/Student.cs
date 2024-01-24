using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai2
{
    internal class Student
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public double StudAvgMark { get; set; }

        public void Print()
        {
            Console.WriteLine("Mã: " + StudID);
            Console.WriteLine("Tên:" + StudName);
            Console.WriteLine("Giới tính:" + StudGender);
            Console.WriteLine("Tuổi:" + StudAge);
            Console.WriteLine("Lớp:" + StudClass);
            Console.WriteLine("Điểm trung bình:" + StudAvgMark);
        }
        public int[] MarkList = new int[3];
        public int this[int index]
        {
            get { return MarkList[index]; }
            set { MarkList[index] = value; }
        }
        public double CalAvg()
        {
            double sum = 0;
            foreach (int mark in MarkList)
            {
                sum += mark;
            }
            StudAvgMark = ( sum / MarkList.Length);
            return StudAvgMark;
        }
    }
}
