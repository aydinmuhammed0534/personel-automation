using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PERSONELL
{
    public class TextControl
    {
        string[] dizi = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "^", "<", ">", ";", "|", "'", "/", ",", "\\", ":", "=", "?", "\"", "*"];
        public bool YaziKontrol(string yazi)
        {

            for (int i = 0; i < yazi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (yazi.Substring(i, 1).ToString() == dizi[j])
                        return false;
                }
            }
            return true;
        }

        public bool TCKontrol(string TC)
        {
            string[] digit = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"];
            for (int i = 0; i < TC.Length; i++)
            {
                int deger = 1;
                for (int j = 0; j < digit.Length; j++)
                {
                    if (TC.Substring(i, 1).ToString() == digit[j])
                    {
                        deger = 0;
                        break;
                    }
                }

                if (deger == 1)
                    return false;
            }

            if (TC.Length != 11)
                return false;

            if (int.Parse(TC.Substring(10, 1).ToString()) % 2 != 0)
                return false;

            int toplam = 0;
            for (int i = 0; i < TC.Length - 1; i++)
            {
                toplam = toplam + int.Parse(TC.Substring(i, 1));
            }

            if (toplam.ToString().Substring(toplam.ToString().Length - 1, 1) != TC.Substring(10, 1))
                return false;

            return true;
        }
        public bool isValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"(^[0-9]{11}$)";

            // Class Regex Represents an
            // immutable regular expression.
            //   Format                Pattern
            // xxxxxxxxxx           ^[0 - 9]{ 10}$
            // +xx xx xxxxxxxx     ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$
            // xxx - xxxx - xxxx   ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$
            Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate
            // a string or to ensure that a string
            // conforms to a particular pattern.
            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }
        public bool isValidEmail(string inputEmail)
        {

            // This Pattern is use to verify the email
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public bool TurKontrol(string Tur)
        {
            string[] dizi_tur = {"Yönetici", "Müdür", "Çalışan", "Stajyer", "Öğrenci", "Güvenlik", "Hizmetli" };
            if (Array.Exists(dizi_tur, element => element == Tur))
            {
                return true;
            }
            else { 
                return false;}
            
        }

        
    }
}