namespace WorkShopSelector
{
    public partial class WorkshopSelector : Krypton.Toolkit.KryptonForm
    {
        public WorkshopSelector()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numberOfDays = 0;
            double lodgingFees = 0, totalLodgingFees = 0, registrationFees = 0, totalFees = 0;
            string workshopInfo;
            StringBuilder WorkshopInfoBuilder = new StringBuilder();

            if (worshopListBox.SelectedIndex != -1 && cityListBox.SelectedIndex != -1)
            {
                switch (workshopListBox.SelectedIndex)
                {
                    case 0;
                        numberOfDays = 3;
                        registrationFees = 1000;
                        break;
                    case 1;
                        numberOfDays = 3;
                        registrationFees = 800;
                        break;
                    case 2;
                        numberOfDays = 3;
                        registrationFees = 1500;
                        break;
                    case 3;
                        numberOfDays = 5;
                        registrationFees = 1300;
                        break;
                    case 4;
                        numberOfDays = 1;
                        registrationFees = 500;
                        break;
                }
                if (cityListBox.SelectedIndex == 0)
                    lodgingFees = 150;
                else if (cityListBox.SelectedIndex == 1)
                    lodgingFees = 225;
                else if (cityListBox.SelectedIndex == 2)
                    lodgingFees = 175;
                else if (cityListBox.SelectedIndex == 3)
                    lodgingFees = 300;
                else if (cityListBox.SelectedIndex == 4)
                    lodgingFees = 175;
                else if (cityListBox.SelectedIndex == 5)
                    lodgingFees = 150;

                totalLodgingFees = lodgingFees * numberOfDays;
                totalFees = totalLodgingFees + registrationFees;

                workshopInfo = $"Registration: {registrationFees:c}\n" +
                    $"Lodging: {lodgingFees:c} X {numberOfDays} days = {totalLodgingFees:c}\n" +
                    $"Total: {totalFees:c}";

                registrationLabel.Text = workshopInfo;
            }
        }
        }
    }