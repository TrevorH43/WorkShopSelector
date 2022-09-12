namespace WorkShopSelector
{
    partial class WorkshopSelector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.workshopListBox = new Krypton.Toolkit.KryptonListBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cityListBox = new Krypton.Toolkit.KryptonListBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.registrationLabel = new Krypton.Toolkit.KryptonLabel();
            this.calculateButton = new Krypton.Toolkit.KryptonButton();
            this.exitButton = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2007SilverDarkMode;
            // 
            // workshopListBox
            // 
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling Stress        \t   3\t\t            $1,000",
            "Time Management         3\t\t            $ 800",
            "Supervision Skills           3\t\t            $1,500",
            "Negotiation                    5 \t\t            $1,300",
            "How to Interview           1\t\t            $ 500"});
            this.workshopListBox.Location = new System.Drawing.Point(60, 143);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(302, 102);
            this.workshopListBox.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(60, 93);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(258, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Workshop/Number of Days/Registration Fees";
            // 
            // cityListBox
            // 
            this.cityListBox.Items.AddRange(new object[] {
            "Austin\t\t \t  \t $150\t          ",
            "Chicago\t\t\t\t$225\t ",
            "Dallas\t\t   \t\t $175",
            "Orlando\t\t\t\t$300",
            "Phoenix\t\t\t\t$175",
            "Raleigh\t\t\t\t$150"});
            this.cityListBox.Location = new System.Drawing.Point(612, 143);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(211, 124);
            this.cityListBox.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(626, 105);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(180, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Location/Lodging Fees per Day";
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = false;
            this.registrationLabel.Location = new System.Drawing.Point(60, 284);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(302, 122);
            this.registrationLabel.TabIndex = 4;
            this.registrationLabel.Values.Text = "";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(629, 304);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(90, 25);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Values.Text = "Calculate";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(629, 344);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 25);
            this.exitButton.TabIndex = 6;
            this.exitButton.Values.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // WorkshopSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 519);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.workshopListBox);
            this.Name = "WorkshopSelector";
            this.Text = "WorkshopSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonListBox workshopListBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonListBox cityListBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel registrationLabel;
        private Krypton.Toolkit.KryptonButton calculateButton;
        private Krypton.Toolkit.KryptonButton exitButton;
    }
}