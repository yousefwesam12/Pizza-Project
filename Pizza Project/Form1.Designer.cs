namespace Pizza_Project
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rdThickCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chboxExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdTakeIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ToppingsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelWhereToEat = new System.Windows.Forms.Label();
            this.CrustLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHeader.Location = new System.Drawing.Point(296, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(572, 76);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "MAKE  YOUR  PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.White;
            this.gbSize.Controls.Add(this.rdLarge);
            this.gbSize.Controls.Add(this.rdMedium);
            this.gbSize.Controls.Add(this.rdSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbSize.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(48, 96);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(224, 159);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarge.Location = new System.Drawing.Point(50, 115);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(67, 24);
            this.rdLarge.TabIndex = 9;
            this.rdLarge.Tag = "40";
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Checked = true;
            this.rdMedium.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMedium.Location = new System.Drawing.Point(50, 72);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(87, 24);
            this.rdMedium.TabIndex = 8;
            this.rdMedium.TabStop = true;
            this.rdMedium.Tag = "30";
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.Location = new System.Drawing.Point(50, 29);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(67, 24);
            this.rdSmall.TabIndex = 7;
            this.rdSmall.Tag = "20";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.White;
            this.gbCrustType.Controls.Add(this.rdThickCrust);
            this.gbCrustType.Controls.Add(this.rdThinCrust);
            this.gbCrustType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(48, 289);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(224, 158);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rdThickCrust
            // 
            this.rdThickCrust.AutoSize = true;
            this.rdThickCrust.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThickCrust.Location = new System.Drawing.Point(19, 96);
            this.rdThickCrust.Name = "rdThickCrust";
            this.rdThickCrust.Size = new System.Drawing.Size(104, 24);
            this.rdThickCrust.TabIndex = 8;
            this.rdThickCrust.Tag = "10";
            this.rdThickCrust.Text = "Thick Crust";
            this.rdThickCrust.UseVisualStyleBackColor = true;
            this.rdThickCrust.CheckedChanged += new System.EventHandler(this.rdThickCrust_CheckedChanged);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.Checked = true;
            this.rdThinCrust.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThinCrust.Location = new System.Drawing.Point(19, 53);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(98, 24);
            this.rdThinCrust.TabIndex = 7;
            this.rdThinCrust.TabStop = true;
            this.rdThinCrust.Tag = "0";
            this.rdThinCrust.Text = "Thin Crust";
            this.rdThinCrust.UseVisualStyleBackColor = true;
            this.rdThinCrust.CheckedChanged += new System.EventHandler(this.rdThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chGreenPeppers);
            this.gbToppings.Controls.Add(this.chTomatoes);
            this.gbToppings.Controls.Add(this.chOlives);
            this.gbToppings.Controls.Add(this.cbMushrooms);
            this.gbToppings.Controls.Add(this.chOnion);
            this.gbToppings.Controls.Add(this.chboxExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(364, 96);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(371, 146);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chGreenPeppers
            // 
            this.chGreenPeppers.AutoSize = true;
            this.chGreenPeppers.Font = new System.Drawing.Font("Microsoft YaHei", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chGreenPeppers.Location = new System.Drawing.Point(190, 105);
            this.chGreenPeppers.Name = "chGreenPeppers";
            this.chGreenPeppers.Size = new System.Drawing.Size(117, 21);
            this.chGreenPeppers.TabIndex = 22;
            this.chGreenPeppers.Tag = "5";
            this.chGreenPeppers.Text = "Green Peppers";
            this.chGreenPeppers.UseVisualStyleBackColor = true;
            this.chGreenPeppers.CheckedChanged += new System.EventHandler(this.chGreenPeppers_CheckedChanged);
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.Font = new System.Drawing.Font("Microsoft YaHei", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTomatoes.Location = new System.Drawing.Point(28, 105);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(88, 21);
            this.chTomatoes.TabIndex = 21;
            this.chTomatoes.Tag = "5";
            this.chTomatoes.Text = "Tomatoes";
            this.chTomatoes.UseVisualStyleBackColor = true;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // chOlives
            // 
            this.chOlives.AutoSize = true;
            this.chOlives.Font = new System.Drawing.Font("Microsoft YaHei", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOlives.Location = new System.Drawing.Point(191, 69);
            this.chOlives.Name = "chOlives";
            this.chOlives.Size = new System.Drawing.Size(65, 21);
            this.chOlives.TabIndex = 20;
            this.chOlives.Tag = "5";
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            this.chOlives.CheckedChanged += new System.EventHandler(this.chOlives_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Font = new System.Drawing.Font("Microsoft YaHei", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMushrooms.Location = new System.Drawing.Point(28, 69);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(100, 21);
            this.cbMushrooms.TabIndex = 19;
            this.cbMushrooms.Tag = "5";
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Font = new System.Drawing.Font("Microsoft YaHei", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOnion.Location = new System.Drawing.Point(190, 29);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(65, 21);
            this.chOnion.TabIndex = 18;
            this.chOnion.Tag = "5";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // chboxExtraCheese
            // 
            this.chboxExtraCheese.AutoSize = true;
            this.chboxExtraCheese.Font = new System.Drawing.Font("Microsoft YaHei", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxExtraCheese.Location = new System.Drawing.Point(28, 29);
            this.chboxExtraCheese.Name = "chboxExtraCheese";
            this.chboxExtraCheese.Size = new System.Drawing.Size(105, 21);
            this.chboxExtraCheese.TabIndex = 17;
            this.chboxExtraCheese.Tag = "5";
            this.chboxExtraCheese.Text = "Extra Cheese";
            this.chboxExtraCheese.UseVisualStyleBackColor = true;
            this.chboxExtraCheese.CheckedChanged += new System.EventHandler(this.chboxExtraCheese_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rdTakeOut);
            this.gbWhereToEat.Controls.Add(this.rdTakeIn);
            this.gbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(364, 289);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(371, 101);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Tag = "10";
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeOut.Location = new System.Drawing.Point(153, 42);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(91, 24);
            this.rdTakeOut.TabIndex = 10;
            this.rdTakeOut.Tag = "10";
            this.rdTakeOut.Text = "Take Out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            this.rdTakeOut.CheckedChanged += new System.EventHandler(this.rdTakeOut_CheckedChanged);
            // 
            // rdTakeIn
            // 
            this.rdTakeIn.AutoSize = true;
            this.rdTakeIn.Checked = true;
            this.rdTakeIn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeIn.Location = new System.Drawing.Point(39, 42);
            this.rdTakeIn.Name = "rdTakeIn";
            this.rdTakeIn.Size = new System.Drawing.Size(68, 24);
            this.rdTakeIn.TabIndex = 9;
            this.rdTakeIn.TabStop = true;
            this.rdTakeIn.Tag = "10";
            this.rdTakeIn.Text = "Eat In";
            this.rdTakeIn.UseVisualStyleBackColor = true;
            this.rdTakeIn.CheckedChanged += new System.EventHandler(this.rdTakeIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.White;
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrderPizza.FlatAppearance.BorderSize = 2;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOrderPizza.Location = new System.Drawing.Point(364, 435);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(142, 46);
            this.btnOrderPizza.TabIndex = 24;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.White;
            this.btnResetForm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetForm.FlatAppearance.BorderSize = 2;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.DarkRed;
            this.btnResetForm.Location = new System.Drawing.Point(573, 435);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(142, 46);
            this.btnResetForm.TabIndex = 25;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ToppingsLabel);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.SizeLabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.LabelWhereToEat);
            this.groupBox3.Controls.Add(this.CrustLabel);
            this.groupBox3.Controls.Add(this.TotalPriceLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(837, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 385);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Summary";
            // 
            // ToppingsLabel
            // 
            this.ToppingsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingsLabel.Location = new System.Drawing.Point(44, 115);
            this.ToppingsLabel.Name = "ToppingsLabel";
            this.ToppingsLabel.Size = new System.Drawing.Size(275, 83);
            this.ToppingsLabel.TabIndex = 43;
            this.ToppingsLabel.Text = "No Toppings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Toppings:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(69, 45);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(64, 27);
            this.SizeLabel.TabIndex = 39;
            this.SizeLabel.Text = "Small";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Size:";
            // 
            // LabelWhereToEat
            // 
            this.LabelWhereToEat.AutoSize = true;
            this.LabelWhereToEat.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWhereToEat.Location = new System.Drawing.Point(159, 242);
            this.LabelWhereToEat.Name = "LabelWhereToEat";
            this.LabelWhereToEat.Size = new System.Drawing.Size(78, 27);
            this.LabelWhereToEat.TabIndex = 41;
            this.LabelWhereToEat.Text = "           ";
            // 
            // CrustLabel
            // 
            this.CrustLabel.AutoSize = true;
            this.CrustLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrustLabel.Location = new System.Drawing.Point(130, 198);
            this.CrustLabel.Name = "CrustLabel";
            this.CrustLabel.Size = new System.Drawing.Size(84, 27);
            this.CrustLabel.TabIndex = 40;
            this.CrustLabel.Text = "            ";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.TotalPriceLabel.Location = new System.Drawing.Point(148, 300);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(76, 56);
            this.TotalPriceLabel.TabIndex = 37;
            this.TotalPriceLabel.Text = "0$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Where To Eat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Crust Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rdThickCrust;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chGreenPeppers;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.CheckBox chboxExtraCheese;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdTakeIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CrustLabel;
        private System.Windows.Forms.Label LabelWhereToEat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label ToppingsLabel;
        private System.Windows.Forms.Label label2;
    }
}

