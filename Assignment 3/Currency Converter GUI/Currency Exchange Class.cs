using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_GUI {

    /// <summary>
    /// 
    /// Holds the information for the currency countries and the allocated exchange rate for them.
    /// It also holds the method which converts currencies to a new currency.
    /// 
    /// Author Tim Gaskell May 2017
    /// 
    /// </summary>


    enum Currencies { AUD = 1, CYN, DKK, EUR, INR, NZD, AED, GBP, USD, VND };
    /// <summary>
    /// 
    /// </summary>
    static class Currency_Exchange_Class {

        private static double[] xRates = { 0, 1, 4.2681, 5.0844, 0.6849, 43.5921, 0.9705, 2.7094, 0.4963, 0.7382, 19115.5547 };


        /// <summary>
        /// Provides country names and currency code which  can be used to initialise a Combo Box
        /// </summary>
        /// <returns> string array each elemnt of which contains the country name and three letter currency code</returns>
        public static string[] InitialiseComboBox() {

            string[] countries = {   "",
                                    "Australia (AUD)",
                                    "China (CNY)",
                                    "Denmark (DKK)",
                                    "Europe (EUR)",
                                    "India (INR)",
                                    "New Zealand (NZD)",
                                    "United Arab Emirates (AED)",
                                    "United Kingdom (GBP)",
                                    "United States (USD)",
                                    "Vietnam (VND)" };

            return countries;
        } //end InitialiseComboBox()             


        /// <summary>
        /// Finds out what currencies are being converted.
        /// If the currency type is not Australian, it converts the users chosen currency to the Australian dollar.
        /// It then calculated the conversion of the users entered money and rounds it to four decimal places.
        /// </summary>
        /// <param name="startIndex"></param>
        /// <param name="newIndex"></param>
        /// <param name="orignalMoney"></param>
        /// <returns> newMOney. which is the converted money the user wants </returns>
        public static double conversion(int startIndex, int newIndex, double orignalMoney) {

            double initialRate, newMoney;

            int australianIndex = 1;

            if(startIndex > australianIndex) {

                initialRate = xRates[australianIndex] / xRates[startIndex]; 
                                       
            }
            else {

                initialRate = xRates[australianIndex];

            }

            newMoney = Math.Round((orignalMoney * initialRate) * xRates[newIndex],4);

            return newMoney;

        }//end conversion

    }//end class

}
