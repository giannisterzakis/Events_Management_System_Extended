
namespace EventManagementSystemExtended
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddHospitalityEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.cboEvents = new System.Windows.Forms.ComboBox();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblMeal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnAddHospitalityEvent);
            this.panel1.Controls.Add(this.btnAddEvent);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Controls.Add(this.cboEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 531);
            this.panel1.TabIndex = 13;
            // 
            // btnAddHospitalityEvent
            // 
            this.btnAddHospitalityEvent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHospitalityEvent.Location = new System.Drawing.Point(5, 400);
            this.btnAddHospitalityEvent.Name = "btnAddHospitalityEvent";
            this.btnAddHospitalityEvent.Size = new System.Drawing.Size(120, 30);
            this.btnAddHospitalityEvent.TabIndex = 31;
            this.btnAddHospitalityEvent.Text = "Add Hospitality";
            this.btnAddHospitalityEvent.UseVisualStyleBackColor = true;
            this.btnAddHospitalityEvent.Click += new System.EventHandler(this.btnAddHospitalityEvent_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(5, 350);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(120, 30);
            this.btnAddEvent.TabIndex = 30;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(36, 485);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Location = new System.Drawing.Point(9, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 2);
            this.panel2.TabIndex = 3;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Chocolate;
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(132, 90);
            this.panelLogo.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Monotype Corsiva", 29.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(3, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(122, 47);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Events";
            // 
            // cboEvents
            // 
            this.cboEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvents.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboEvents.ForeColor = System.Drawing.Color.Black;
            this.cboEvents.FormattingEnabled = true;
            this.cboEvents.Location = new System.Drawing.Point(5, 120);
            this.cboEvents.Name = "cboEvents";
            this.cboEvents.Size = new System.Drawing.Size(120, 31);
            this.cboEvents.TabIndex = 0;
            this.cboEvents.SelectedIndexChanged += new System.EventHandler(this.cboEvents_SelectedIndexChanged_1);
            // 
            // lstEvents
            // 
            this.lstEvents.BackColor = System.Drawing.Color.White;
            this.lstEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEvents.ItemHeight = 16;
            this.lstEvents.Location = new System.Drawing.Point(160, 50);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(570, 436);
            this.lstEvents.TabIndex = 14;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.White;
            this.lblDesign.Location = new System.Drawing.Point(501, 504);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(229, 18);
            this.lblDesign.TabIndex = 21;
            this.lblDesign.Text = "Designed by Ioannis Terzakis";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(160, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 19);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(204, 28);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(43, 19);
            this.lblStartDate.TabIndex = 23;
            this.lblStartDate.Text = "Start";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(300, 28);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(35, 19);
            this.lblEndDate.TabIndex = 24;
            this.lblEndDate.Text = "End";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(395, 28);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(67, 19);
            this.lblLocation.TabIndex = 25;
            this.lblLocation.Text = "Location";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCapacity.ForeColor = System.Drawing.Color.White;
            this.lblCapacity.Location = new System.Drawing.Point(500, 28);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(67, 19);
            this.lblCapacity.TabIndex = 26;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCost.ForeColor = System.Drawing.Color.White;
            this.lblCost.Location = new System.Drawing.Point(600, 28);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(38, 19);
            this.lblCost.TabIndex = 27;
            this.lblCost.Text = "Cost";
            this.lblCost.Click += new System.EventHandler(this.lblCost_Click);
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.BackColor = System.Drawing.Color.Transparent;
            this.lblMeal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblMeal.ForeColor = System.Drawing.Color.White;
            this.lblMeal.Location = new System.Drawing.Point(687, 28);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(43, 19);
            this.lblMeal.TabIndex = 28;
            this.lblMeal.Text = "Meal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EventManagementSystemExtended.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(764, 531);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Event Management Extended";
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ComboBox cboEvents;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnAddHospitalityEvent;
    }
}

