using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Currency_Converter_GUI {

    /// <summary>
    /// 
    /// Menu driven program that allows the user to choose
    /// two different currencies in which they want to convert their money.
    /// It allows the user to do multiple conversions whilst the program is running.
    /// 
    /// Author Tim Gaskell May 2017
    /// 
    /// </summary>
    public partial class Form1 : Form {

       
        /// <summary>
        /// Initializes the Currency Exchange form.
        /// Adds the Currency Exchange Class data for the combo boxes
        /// Adds the combo boxes event handerlers
        /// </summary>        
        public Form1() {
            InitializeComponent();

            originalCurrencyComboBox.DataSource = Currency_Exchange_Class.InitialiseComboBox();
            newCurrencyComboBox.DataSource = Currency_Exchange_Class.InitialiseComboBox();

            originalCurrencyComboBox.SelectedIndexChanged += new EventHandler(CurrencyHaveComboBox_SelectedIndexChanged);
            newCurrencyComboBox.SelectedIndexChanged += new EventHandler(CurrencyWantComboBox_SelectedIndexChanged);

        }//end Form1

      
        /// <summary>
        /// Records the index for the selected combo box item.
        /// If the user chooses the blank entry, the next box will not be enabled.
        /// If the user chooses any other entry, it will record the index.
        /// It then enables the CurrencyWantComboBox whilst disabling this combo box and corrisponding label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CurrencyHaveComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            int originalIndex, blankIndex = 0 ;
               
             originalIndex = originalCurrencyComboBox.SelectedIndex;

            if (originalCurrencyComboBox.SelectedIndex > blankIndex ) {

                EnableCurrencyWant();

             
            }

        }//end CurrencyHaveComboBox_SelectedIndexChanged


        /// <summary>
        /// Records the index for the selected combo box item.
        /// If the user chooses the blank entry, the next box will not be enabled.
        /// If the user chooses any other entry, it will record the index.
        /// The program then finds the enum for the original currency using the recorded index.
        /// This enum is then changed to a string and is written in the haveType label.
        /// It then disables this combo box and corrisponding label and enables the CurrencyTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrencyWantComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            int newIndex, blankIndex = 0;

            int originalIndex;

            originalIndex = originalCurrencyComboBox.SelectedIndex;

            newIndex = newCurrencyComboBox.SelectedIndex;

            if (newCurrencyComboBox.SelectedIndex > blankIndex){ 

                EnableCurrecyTextbox();

                Currencies country = (Currencies)originalIndex;

                haveType.Text = country.ToString();

            }

        }//end CurrencyWantComboBox_SelectedIndexChanged


        /// <summary>
        /// Once the user has typed something into the textbox, it enables
        /// the equalsButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrencyTextBox_TextChanged(object sender, EventArgs e) {
      
                equalsButton.Enabled = true;

        }//end CurrencyTextBox_TextChanged


        /// <summary>
        /// This method starts off by determining if the entered number in the CurrencyTextBox
        /// is a number. If not, a message box is shown, telling them what is wrong, then clears the CurrencyTextBox 
        /// and focuses it for the user and disables the button.
        /// If it is a number, it saves the number into original money.
        /// The program then grabs the selected indexs for the originalCurrencyComboBox and
        /// newCurrencyComboBox. These values are then passed through a method in the 
        /// Currency_Exchange_Class which converts the currency the user has chosen.
        /// The wanted currency enum name is passed into the wantType label and displayed for the user.
        /// The converted money is then passed into the ConvertedCurrencyTextBox to be displayed for the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equalsButton_Click(object sender, EventArgs e) {

            int originalType, newType;

            double originalMoney, newMoney;

            if (!double.TryParse(CurrencyTextBox.Text, out originalMoney)) {
                if (originalMoney < 1) {

                    MessageBox.Show("Please only use numbers");
                    CurrencyTextBox.Text = "";
                    CurrencyTextBox.Focus();

                    equalsButton.Enabled = false;

                }
                else {
                    originalType = originalCurrencyComboBox.SelectedIndex;
                    newType = newCurrencyComboBox.SelectedIndex;
                    originalMoney = double.Parse(CurrencyTextBox.Text);

                    newMoney = Currency_Exchange_Class.conversion(originalType, newType, originalMoney);

                    Currencies newCountry = (Currencies)newType;

                    wantType.Text = newCountry.ToString();


                    ConvertedCurrencyTextBox.Enabled = true;
                    ConvertedCurrencyTextBox.Text = newMoney.ToString();
                    ConvertedCurrencyTextBox.Enabled = false;

                    CurrencyTextBox.Enabled = false;
                    AnotherConversionGroupBox.Visible = true;

                }
            }
            else {
                MessageBox.Show("Please use a number greater than 0");
                CurrencyTextBox.Text = "";
                CurrencyTextBox.Focus();

                equalsButton.Enabled = false;


            }

        }// end equalsButton_Click


        /// <summary>
        /// Depending on the users choice, if the user selects the yes radiobutton, all entered fields
        /// are reset to blank and allows the user to do another conversion.
        /// If the user selects the no radiobutton, a messagebox is shown to thank them, then closes the
        /// program nicely.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnotherGroupBox_Enter(object sender, EventArgs e) {

            if (yesRadioButton.Checked) {

                reset();

            }
            else if (noRadioButton.Checked) {

                MessageBox.Show("Thank you for using our program, have a nice day.");
                this.Close();
            }

        }//end AnotherGroupBox_Enter


        /// <summary>
        /// Enables the newCurrencyLabel and NewCurrencyComboBox
        /// whilst disabling the orignalCurrencyCombobox and OrignalCurrencyLabel.
        /// </summary>
        private void EnableCurrencyWant() {

            newCurrencyLabel.Enabled = true;
            newCurrencyComboBox.Enabled = true;

            originalCurrencyComboBox.Enabled = false;
            OrignalCurrencyLabel.Enabled = false;

        }//end EnableCurrencyWant


        /// <summary>
        /// Enables the AmountIHaveLabel and CrrencyTextBox
        /// Whilst disabling the newCurrencyLabel and NewCurrencyComboBox
        /// </summary>
        private void EnableCurrecyTextbox() {

            AmountIHaveLabel.Enabled = true;
            CurrencyTextBox.Enabled = true;

            newCurrencyLabel.Enabled = false;
            newCurrencyComboBox.Enabled = false;

        }//end EnableCurrecyTextbox


        /// <summary>
        /// Enables the OrignalCurrencyComboBox and OrignalCurrencyLabel
        /// Whilst disabling all other items that were previously on the screen,
        /// returning all comboboxes to the default and text boxes to have nothing
        /// inside of them.
        /// </summary>
        private void reset() {

            int blankIndex = 0;

            originalCurrencyComboBox.Enabled = true;
            OrignalCurrencyLabel.Enabled = true;
            originalCurrencyComboBox.SelectedIndex = blankIndex;

            newCurrencyLabel.Enabled = false;
            newCurrencyComboBox.Enabled = false;
            newCurrencyComboBox.SelectedIndex = blankIndex;

            CurrencyTextBox.Enabled = false;
            CurrencyTextBox.Text = null;

            ConvertedCurrencyTextBox.Text = null;

            equalsButton.Enabled = false;

            AnotherConversionGroupBox.Visible = false;

            yesRadioButton.Checked = false;

        }//end reset

    }//end class

}//end namespace
