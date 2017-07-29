using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GST_Billing
{
    class BaseModel
    {
        private float quantity;
        private double total;
        private double amount;
        private double discount;
        private double gstAmount;
        private double taxableVal;

       static BaseModel _instance;

        public static BaseModel Instance
        {
            get 
            { 
                _instance = _instance == null ? new BaseModel() : _instance;
                return _instance;
            }
        }

        public Dictionary<string, string> stateCodes = new Dictionary<string, string>(){{"Andaman And Nicobar Islands","35"}, {"Andhra Pradesh","28"},/* {"Andhra Pradesh(New)","37"},*/ 
                                                    {"Arunachal Pradesh","12"}, {"Assam","18"}, {"Bihar","10"}, {"Chandigarh","04"}, {"Chattisgarh","22"},
                                                    {"Dadra And Nagar Haveli","26"}, {"Daman And Diu","25"}, {"Delhi","07"}, {"Goa","30"}, {"Gujarat","24"},
                                                    {"Haryana","06"}, {"Himachal Pradesh","02"},{"Jammu And Kashmir","01"}, {"Jharkhand","20"}, {"Karnataka","29"},
                                                    {"Kerala","32"}, {"Lakshadweep Islands","31"}, {"Madhya Pradesh","23"}, {"Maharashtra","27"}, {"Manipur","14"},
                                                    {"Meghalaya","17"}, {"Mizoram","15"}, {"Nagaland","13"}, {"Odisha","21"}, {"Pondicherry","34"}, {"Punjab","03"},
                                                    {"Rajasthan","08"}, {"Sikkim","11"}, {"Tamil Nadu","33"}, {"Telangana","36"}, {"Tripura","16"}, {"Uttar Pradesh","09"},
                                                    {"Uttarakhand","05"}, {"West Bengal","19"}};

        public Dictionary<int, string> additionalCharges = new Dictionary<int, string>() { {1, "Packing & Forwarding" }, {2, "Freight" }, {3, "Loading & Unloading" }, {4, "Insurance" }, {5, "Courier Charge" }, {6, "Other Charges" } };

        public Dictionary<int, string> paymentTerms = new Dictionary<int, string>() { { 1, "Immediately" }, { 2, "Within 15 Days" }, { 3, "Within 30 Days" }, { 4, "Within 45 Days" }, { 5, "Within 60 Days" }, { 6, "Other" } };

        // Convert the string to Pascal case.
        public string ToPascalCase(string the_string)
        {
            // If there are 0 or 1 characters, just return the string.
            if (the_string == null) return the_string;
            if (the_string.Length < 2) return the_string.ToUpper();

            // Split the string into words.
            string[] words = the_string.Split(
                new char[] { },
                StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.
            string result = "";
            foreach (string word in words)
            {
                result +=
                    word.Substring(0, 1).ToUpper() +
                    word.Substring(1) + " ";
            }

            return result.Trim();
        }

        public float Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public double GstAmount
        {
            get { return gstAmount; }
            set { gstAmount = value; }
        }

        public double Taxable
        {
            get { return taxableVal; }
            set { taxableVal = value; }
        }

        public double BillTotal
        {
            get { return total; }
            set { total = value; }
        }
        
    }
}
