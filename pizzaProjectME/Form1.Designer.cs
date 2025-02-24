namespace pizzaProjectME
{
    partial class v
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
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gpCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rpThin = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rpEatin = new System.Windows.Forms.RadioButton();
            this.rpTakeOut = new System.Windows.Forms.RadioButton();
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.btResetForm = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbOrderSummary = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbSizeChoose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbToppingsChoose = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbCrustChoosen = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbWhereToEatChoose = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.gpSize.SuspendLayout();
            this.gpCrust.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpSize
            // 
            this.gpSize.Controls.Add(this.rbLarge);
            this.gpSize.Controls.Add(this.rbMeduim);
            this.gpSize.Controls.Add(this.rbSmall);
            this.gpSize.Location = new System.Drawing.Point(30, 32);
            this.gpSize.Name = "gpSize";
            this.gpSize.Size = new System.Drawing.Size(137, 150);
            this.gpSize.TabIndex = 3;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(16, 107);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 5;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(16, 75);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(62, 17);
            this.rbMeduim.TabIndex = 4;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(16, 42);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gpCrust
            // 
            this.gpCrust.Controls.Add(this.rbThick);
            this.gpCrust.Controls.Add(this.rpThin);
            this.gpCrust.Location = new System.Drawing.Point(46, 235);
            this.gpCrust.Name = "gpCrust";
            this.gpCrust.Size = new System.Drawing.Size(137, 150);
            this.gpCrust.TabIndex = 8;
            this.gpCrust.TabStop = false;
            this.gpCrust.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(42, 89);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(52, 17);
            this.rbThick.TabIndex = 9;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rpThin
            // 
            this.rpThin.AutoSize = true;
            this.rpThin.Location = new System.Drawing.Point(42, 45);
            this.rpThin.Name = "rpThin";
            this.rpThin.Size = new System.Drawing.Size(46, 17);
            this.rpThin.TabIndex = 8;
            this.rpThin.TabStop = true;
            this.rpThin.Tag = "0";
            this.rpThin.Text = "Thin";
            this.rpThin.UseVisualStyleBackColor = true;
            this.rpThin.CheckedChanged += new System.EventHandler(this.rpThin_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.Controls.Add(this.chkGreenPeppers);
            this.gpToppings.Controls.Add(this.chkExtraChees);
            this.gpToppings.Controls.Add(this.chkTomatoes);
            this.gpToppings.Controls.Add(this.chkMushrooms);
            this.gpToppings.Controls.Add(this.chkOlives);
            this.gpToppings.Controls.Add(this.chkOnion);
            this.gpToppings.Location = new System.Drawing.Point(269, 97);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(244, 135);
            this.gpToppings.TabIndex = 16;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(133, 95);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPeppers.TabIndex = 17;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(14, 23);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(83, 17);
            this.chkExtraChees.TabIndex = 20;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(14, 95);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkTomatoes.TabIndex = 19;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(14, 59);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 18;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(133, 59);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 16;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(133, 24);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(80, 17);
            this.chkOnion.TabIndex = 15;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "checkBox1";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rpEatin);
            this.gbWhereToEat.Controls.Add(this.rpTakeOut);
            this.gbWhereToEat.Location = new System.Drawing.Point(283, 280);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(183, 73);
            this.gbWhereToEat.TabIndex = 19;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rpEatin
            // 
            this.rpEatin.AutoSize = true;
            this.rpEatin.Location = new System.Drawing.Point(15, 29);
            this.rpEatin.Name = "rpEatin";
            this.rpEatin.Size = new System.Drawing.Size(52, 17);
            this.rpEatin.TabIndex = 20;
            this.rpEatin.TabStop = true;
            this.rpEatin.Text = "Eat in";
            this.rpEatin.UseVisualStyleBackColor = true;
            this.rpEatin.CheckedChanged += new System.EventHandler(this.rpEatin_CheckedChanged);
            // 
            // rpTakeOut
            // 
            this.rpTakeOut.AutoSize = true;
            this.rpTakeOut.Location = new System.Drawing.Point(107, 29);
            this.rpTakeOut.Name = "rpTakeOut";
            this.rpTakeOut.Size = new System.Drawing.Size(70, 17);
            this.rpTakeOut.TabIndex = 19;
            this.rpTakeOut.TabStop = true;
            this.rpTakeOut.Text = "Take Out";
            this.rpTakeOut.UseVisualStyleBackColor = true;
            this.rpTakeOut.CheckedChanged += new System.EventHandler(this.rpTakeOut_CheckedChanged);
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.Location = new System.Drawing.Point(283, 415);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(105, 31);
            this.btOrderPizza.TabIndex = 20;
            this.btOrderPizza.Text = "Order Pizza";
            this.btOrderPizza.UseVisualStyleBackColor = true;
            this.btOrderPizza.Click += new System.EventHandler(this.btOrderPizza_Click);
            // 
            // btResetForm
            // 
            this.btResetForm.Location = new System.Drawing.Point(441, 415);
            this.btResetForm.Name = "btResetForm";
            this.btResetForm.Size = new System.Drawing.Size(105, 31);
            this.btResetForm.TabIndex = 21;
            this.btResetForm.Text = "Reset Form\r\n";
            this.btResetForm.UseVisualStyleBackColor = true;
            this.btResetForm.Click += new System.EventHandler(this.btResetForm_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(294, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(263, 31);
            this.lbTitle.TabIndex = 22;
            this.lbTitle.Text = "Make Your Pizza";
            // 
            // lbOrderSummary
            // 
            this.lbOrderSummary.AutoSize = true;
            this.lbOrderSummary.Location = new System.Drawing.Point(644, 74);
            this.lbOrderSummary.Name = "lbOrderSummary";
            this.lbOrderSummary.Size = new System.Drawing.Size(79, 13);
            this.lbOrderSummary.TabIndex = 23;
            this.lbOrderSummary.Text = "Order Summary";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(608, 115);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(54, 20);
            this.lbSize.TabIndex = 24;
            this.lbSize.Text = "Size :";
            // 
            // lbSizeChoose
            // 
            this.lbSizeChoose.AutoSize = true;
            this.lbSizeChoose.Location = new System.Drawing.Point(674, 122);
            this.lbSizeChoose.Name = "lbSizeChoose";
            this.lbSizeChoose.Size = new System.Drawing.Size(32, 13);
            this.lbSizeChoose.TabIndex = 25;
            this.lbSizeChoose.Text = "Small";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Toppings : ";
            // 
            // lbToppingsChoose
            // 
            this.lbToppingsChoose.AutoSize = true;
            this.lbToppingsChoose.Location = new System.Drawing.Point(655, 192);
            this.lbToppingsChoose.Name = "lbToppingsChoose";
            this.lbToppingsChoose.Size = new System.Drawing.Size(68, 13);
            this.lbToppingsChoose.TabIndex = 4;
            this.lbToppingsChoose.Text = "No Toppings";
            this.lbToppingsChoose.Click += new System.EventHandler(this.lbToppingsChoose_Click);
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(579, 235);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(110, 20);
            this.lbCrustType.TabIndex = 28;
            this.lbCrustType.Text = "Crust Type : ";
            // 
            // lbCrustChoosen
            // 
            this.lbCrustChoosen.AutoSize = true;
            this.lbCrustChoosen.Location = new System.Drawing.Point(674, 260);
            this.lbCrustChoosen.Name = "lbCrustChoosen";
            this.lbCrustChoosen.Size = new System.Drawing.Size(61, 13);
            this.lbCrustChoosen.TabIndex = 29;
            this.lbCrustChoosen.Text = "Thick Crust";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.Location = new System.Drawing.Point(560, 304);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(129, 20);
            this.lbWhereToEat.TabIndex = 30;
            this.lbWhereToEat.Text = "Where To Eat :";
            // 
            // lbWhereToEatChoose
            // 
            this.lbWhereToEatChoose.AutoSize = true;
            this.lbWhereToEatChoose.Location = new System.Drawing.Point(691, 324);
            this.lbWhereToEatChoose.Name = "lbWhereToEatChoose";
            this.lbWhereToEatChoose.Size = new System.Drawing.Size(34, 13);
            this.lbWhereToEatChoose.TabIndex = 31;
            this.lbWhereToEatChoose.Text = "Eat in";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(596, 360);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(103, 20);
            this.lbTotalPrice.TabIndex = 32;
            this.lbTotalPrice.Text = "Total price :";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.Location = new System.Drawing.Point(691, 401);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 39);
            this.lbPrice.TabIndex = 33;
            this.lbPrice.Text = "50";
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 488);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbWhereToEatChoose);
            this.Controls.Add(this.lbWhereToEat);
            this.Controls.Add(this.lbCrustChoosen);
            this.Controls.Add(this.lbCrustType);
            this.Controls.Add(this.lbToppingsChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSizeChoose);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbOrderSummary);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btResetForm);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gpCrust);
            this.Controls.Add(this.gpSize);
            this.Controls.Add(this.gpToppings);
            this.Name = "v";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.v_Load);
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.gpCrust.ResumeLayout(false);
            this.gpCrust.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gpCrust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rpThin;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rpEatin;
        private System.Windows.Forms.RadioButton rpTakeOut;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Button btResetForm;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbOrderSummary;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbSizeChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbToppingsChoose;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbCrustChoosen;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbWhereToEatChoose;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbPrice;
    }
}

