using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

class Utility
{
    static int mod, j;
    string[] extensions, lasttwo;

    public Utility()
    {
        extensions = new string[] { " ", "Hundred", "Thousand", "Lakh", "Crores" };
        lasttwo = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Ninteen", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
        j = -1;
    }
    public string twodigit(int lasttwodigit)
    {
        if (lasttwodigit < 20)
        {
            return lasttwo[lasttwodigit];
        }
        else
        {
            return lasttwo[18 + (lasttwodigit / 10)] + " " + this.twodigit(lasttwodigit % 10);
        }
    }
    public string convert_to_words(decimal main_amount)
    {
        j = -1;
        int digit = (int)main_amount;
        int paisa;
        if (main_amount.ToString().Contains('.'))
        {

            string mainamount = main_amount.ToString();
            if (mainamount.Length == mainamount.IndexOf('.') + 3)
            {
                mainamount = mainamount.Substring(0, mainamount.IndexOf('.') + 3);
            }
            else
            {
            }

            try
            {
                paisa = Convert.ToInt32(mainamount.Substring(digit.ToString().Length + 1, 2));
            }
            catch (Exception e)
            {
                paisa = 0;
            }
        }
        else
        {
            paisa = 0;
        }

        string ans = "";     
        if (digit == 0)
        {
            return "Zero";
        }

        int next_digit = digit;
        for (int i = 100; next_digit != 0; )
        {
            j++;
            mod = next_digit % i;
            if (j == 1)
                mod /= 10;
            next_digit = next_digit / (i);
            string value = this.twodigit(mod);
            if (value.Equals(""))
            {
            }
            else
            {
                ans = value + " " + extensions[j] + " " + ans;
            }
            i = 100;
            if (j == 0)
                next_digit *= 10;
        }
        if (paisa == 0)
        {

            return ans + " Rupees";
        }
        else
        {
            j = -1;
            return ans + " Rupees And " + convert_to_words((decimal)paisa).Replace("Rupees", "Paisa") + " Only";
        }
    }
}

