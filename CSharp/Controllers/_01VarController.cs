using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class _01VarController : Controller
    {
        public string MyFirstCS()
        {
            string w = "Hello World";

            return w;

        }
        public int MyFirstCS2()
        {
            int w = 54645;

            return w;
        }

        public string checkGender(bool gender)
        {
            /*http://localhost:52796/_01Var/checkGender?gender=true 傳參數方式*/
            bool w = gender;
      

            if (w)
                return "男生";

            return "女生";
        }
        public string checkGender2(string name, bool gender)
        {

            /*多參數
             * http://localhost:52796/_01Var/checkGender2?gender=true&name=carl 傳參數方式*/
            bool w = gender;
            string n = name;
            string r = "";
            r = w ? "男生" : "女生";

            return "<h1>" + n + "!!你的性別是" + r + "</h1>";
        }
        public void number()
        {
            //數值Data Type

            byte a = 123; //8位元正整數(0~255)
            sbyte b = 123;  //8位元整數(-128~127)

            short c = 123;  //16位元整數(-32768~32767)
            int d = 123;   //32位元整數(-2147483648~2147483647)
            long e = 123; //64位元整數

            ushort f = 123;  //16位元正整數(0~65535)
            uint g = 123;   //32位元正整數
            ulong h = 123; //64位元正整數


            ///////////////////////////////////////
            float i = 123.456f;  //單精準度浮點數
            double j = 123.456456456;  //倍精準度浮點數
        }
        public string googleMap(string place)
        {
            return "<a href='https://www.google.com.tw/maps/search/" + place + "' target='_blank'>點我看地圖</a>";
        }
    }
}