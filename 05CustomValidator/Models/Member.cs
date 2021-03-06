using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _05CustomValidator.Models
{
    public class Member
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "身分證字號為必填")]
        [RegularExpression("[A-Z][12][0-9]{8}", ErrorMessage = "身分證字號格式有誤")]
        [CheckIDNumber(ErrorMessage = "身分證字號格式錯誤")]
        public string IDNmber { get; set; }  //身分證字號

        [Required(ErrorMessage = "姓名為必填")]
        [StringLength(50)]
        public string Name { get; set; }


        public class CheckIDNumber : ValidationAttribute
        {


            public override bool IsValid(object value)
            {
                int sum = 0;
                string id = value.ToString(); //A123456789

                const string eng = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
                string t = id.Substring(0, 1);  //t="A"
                int intEng = eng.IndexOf(t) + 10;  //A=10

                int n1 = intEng / 10;
                int n2 = intEng % 10;

                int[] a = new int[9];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(id.Substring(i + 1, 1));
                }


                sum = n1 + n2 * 9 + a[0] * 8 + a[1] * 7 + a[2] * 6 + a[3] * 5 + a[4] * 4 + a[5] * 3 + a[6] * 2 + a[7] + a[8];

                //換成迴圈


                if (sum % 10 == 0)
                    return true;

                return false;
            }





        }



    }
}