namespace CChavezVehicleInventroy
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            txbResults = new TextBox();
            btAdd = new Button();
            cbType = new ComboBox();
            txbVIN = new TextBox();
            txbLicense = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            txbSummary = new TextBox();
            lbInventory = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(71, 32);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(553, 370);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txbResults);
            tabPage1.Controls.Add(btAdd);
            tabPage1.Controls.Add(cbType);
            tabPage1.Controls.Add(txbVIN);
            tabPage1.Controls.Add(txbLicense);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(515, 362);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Vehicle Form";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CChavezVehicleInventory.Properties.Resources.Subaru_Logo;
            pictureBox1.Location = new Point(323, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 142);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 8;
            label4.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 9);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 7;
            label3.Text = "New Vehicle Form";
            // 
            // txbResults
            // 
            txbResults.BackColor = SystemColors.ActiveCaption;
            txbResults.Location = new Point(18, 242);
            txbResults.Multiline = true;
            txbResults.Name = "txbResults";
            txbResults.ReadOnly = true;
            txbResults.Size = new Size(455, 91);
            txbResults.TabIndex = 6;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(123, 197);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(112, 34);
            btAdd.TabIndex = 5;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Sedan", "Truck", "SUV", "Motorcycle" });
            cbType.Location = new Point(123, 142);
            cbType.Name = "cbType";
            cbType.Size = new Size(182, 33);
            cbType.TabIndex = 4;
            cbType.Text = "Sedan";
            // 
            // txbVIN
            // 
            txbVIN.ForeColor = SystemColors.ScrollBar;
            txbVIN.Location = new Point(123, 89);
            txbVIN.Name = "txbVIN";
            txbVIN.Size = new Size(182, 31);
            txbVIN.TabIndex = 3;
            txbVIN.Text = "XX-000-00-0000";
            // 
            // txbLicense
            // 
            txbLicense.ForeColor = SystemColors.ScrollBar;
            txbLicense.Location = new Point(123, 58);
            txbLicense.Name = "txbLicense";
            txbLicense.Size = new Size(182, 31);
            txbLicense.TabIndex = 2;
            txbLicense.Text = "XXX-000";
            txbLicense.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 89);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 1;
            label2.Text = "Vin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 58);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Licence";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txbSummary);
            tabPage2.Controls.Add(lbInventory);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(515, 362);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inventory List";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txbSummary
            // 
            txbSummary.BackColor = SystemColors.ActiveCaption;
            txbSummary.Location = new Point(49, 248);
            txbSummary.Multiline = true;
            txbSummary.Name = "txbSummary";
            txbSummary.ReadOnly = true;
            txbSummary.Size = new Size(408, 86);
            txbSummary.TabIndex = 1;
            // 
            // lbInventory
            // 
            lbInventory.FormattingEnabled = true;
            lbInventory.ItemHeight = 25;
            lbInventory.Location = new Point(48, 28);
            lbInventory.Name = "lbInventory";
            lbInventory.Size = new Size(409, 204);
            lbInventory.TabIndex = 0;
            lbInventory.MouseDoubleClick += lbInventory_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(715, 441);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "New Vehicle Form";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private TextBox txbResults;
        private Button btAdd;
        private ComboBox cbType;
        private TextBox txbVIN;
        private TextBox txbLicense;
        private TextBox txbSummary;
        private ListBox lbInventory;
        private PictureBox pictureBox1;
    }
}
