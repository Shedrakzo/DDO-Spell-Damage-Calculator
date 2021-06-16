
namespace DDOSpellDamage
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
            this.AveDamageText = new System.Windows.Forms.TextBox();
            this.SPText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxBox = new System.Windows.Forms.CheckBox();
            this.EmpBox = new System.Windows.Forms.CheckBox();
            this.IntBox = new System.Windows.Forms.CheckBox();
            this.CLText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DiceText1 = new System.Windows.Forms.TextBox();
            this.DiceText2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DiceText3 = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.EmpHealBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CritDmgText = new System.Windows.Forms.TextBox();
            this.skullBox = new System.Windows.Forms.ComboBox();
            this.CMText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AveDamageText
            // 
            this.AveDamageText.Location = new System.Drawing.Point(121, 429);
            this.AveDamageText.Name = "AveDamageText";
            this.AveDamageText.ReadOnly = true;
            this.AveDamageText.Size = new System.Drawing.Size(84, 23);
            this.AveDamageText.TabIndex = 0;
            this.AveDamageText.TabStop = false;
            this.AveDamageText.TextChanged += new System.EventHandler(this.AveDamageText_TextChanged);
            // 
            // SPText
            // 
            this.SPText.Location = new System.Drawing.Point(119, 12);
            this.SPText.Name = "SPText";
            this.SPText.Size = new System.Drawing.Size(65, 23);
            this.SPText.TabIndex = 2;
            this.SPText.TextChanged += new System.EventHandler(this.SPText_TextChanged);
            this.SPText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SPText_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spell Power:";
            // 
            // MaxBox
            // 
            this.MaxBox.AutoSize = true;
            this.MaxBox.Location = new System.Drawing.Point(14, 112);
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.Size = new System.Drawing.Size(84, 19);
            this.MaxBox.TabIndex = 5;
            this.MaxBox.Text = "Maximized";
            this.MaxBox.UseVisualStyleBackColor = true;
            // 
            // EmpBox
            // 
            this.EmpBox.AutoSize = true;
            this.EmpBox.Location = new System.Drawing.Point(14, 138);
            this.EmpBox.Name = "EmpBox";
            this.EmpBox.Size = new System.Drawing.Size(89, 19);
            this.EmpBox.TabIndex = 6;
            this.EmpBox.Text = "Empowered";
            this.EmpBox.UseVisualStyleBackColor = true;
            // 
            // IntBox
            // 
            this.IntBox.AutoSize = true;
            this.IntBox.Location = new System.Drawing.Point(14, 164);
            this.IntBox.Name = "IntBox";
            this.IntBox.Size = new System.Drawing.Size(81, 19);
            this.IntBox.TabIndex = 7;
            this.IntBox.Text = "Intensified";
            this.IntBox.UseVisualStyleBackColor = true;
            // 
            // CLText
            // 
            this.CLText.Location = new System.Drawing.Point(119, 79);
            this.CLText.Name = "CLText";
            this.CLText.Size = new System.Drawing.Size(65, 23);
            this.CLText.TabIndex = 4;
            this.CLText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CLText_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Caster Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(76, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "d";
            // 
            // DiceText1
            // 
            this.DiceText1.Location = new System.Drawing.Point(53, 249);
            this.DiceText1.Name = "DiceText1";
            this.DiceText1.Size = new System.Drawing.Size(23, 23);
            this.DiceText1.TabIndex = 9;
            this.DiceText1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiceText1_KeyDown);
            // 
            // DiceText2
            // 
            this.DiceText2.Location = new System.Drawing.Point(91, 249);
            this.DiceText2.Name = "DiceText2";
            this.DiceText2.Size = new System.Drawing.Size(23, 23);
            this.DiceText2.TabIndex = 10;
            this.DiceText2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiceText2_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(115, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "+";
            // 
            // DiceText3
            // 
            this.DiceText3.Location = new System.Drawing.Point(140, 249);
            this.DiceText3.Name = "DiceText3";
            this.DiceText3.Size = new System.Drawing.Size(28, 23);
            this.DiceText3.TabIndex = 11;
            this.DiceText3.TextChanged += new System.EventHandler(this.DiceText3_TextChanged);
            this.DiceText3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiceText3_KeyDown);
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(53, 381);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(115, 23);
            this.CalcButton.TabIndex = 13;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // EmpHealBox
            // 
            this.EmpHealBox.AutoSize = true;
            this.EmpHealBox.Location = new System.Drawing.Point(14, 189);
            this.EmpHealBox.Name = "EmpHealBox";
            this.EmpHealBox.Size = new System.Drawing.Size(133, 19);
            this.EmpHealBox.TabIndex = 8;
            this.EmpHealBox.Text = "Empowered Healing";
            this.EmpHealBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Critical Multiplier:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Average Damage:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Critical Damage:";
            // 
            // CritDmgText
            // 
            this.CritDmgText.Location = new System.Drawing.Point(121, 467);
            this.CritDmgText.Name = "CritDmgText";
            this.CritDmgText.ReadOnly = true;
            this.CritDmgText.Size = new System.Drawing.Size(84, 23);
            this.CritDmgText.TabIndex = 0;
            this.CritDmgText.TabStop = false;
            // 
            // skullBox
            // 
            this.skullBox.FormattingEnabled = true;
            this.skullBox.Items.AddRange(new object[] {
            "0 Skulls",
            "1 Skull",
            "2 Skulls",
            "3 Skulls",
            "4 Skulls",
            "5 Skulls",
            "6 Skulls",
            "7 Skulls",
            "8 Skulls",
            "9 Skulls",
            "10 Skulls"});
            this.skullBox.Location = new System.Drawing.Point(51, 320);
            this.skullBox.Name = "skullBox";
            this.skullBox.Size = new System.Drawing.Size(121, 23);
            this.skullBox.TabIndex = 12;
            this.skullBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CMText
            // 
            this.CMText.Location = new System.Drawing.Point(119, 46);
            this.CMText.Name = "CMText";
            this.CMText.Size = new System.Drawing.Size(65, 23);
            this.CMText.TabIndex = 3;
            this.CMText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMText_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 507);
            this.Controls.Add(this.CMText);
            this.Controls.Add(this.skullBox);
            this.Controls.Add(this.CritDmgText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpHealBox);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.DiceText3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiceText2);
            this.Controls.Add(this.DiceText1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLText);
            this.Controls.Add(this.IntBox);
            this.Controls.Add(this.EmpBox);
            this.Controls.Add(this.MaxBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SPText);
            this.Controls.Add(this.AveDamageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Spell Damage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AveDamageText;
        private System.Windows.Forms.TextBox SPText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox MaxBox;
        private System.Windows.Forms.CheckBox EmpBox;
        private System.Windows.Forms.CheckBox IntBox;
        private System.Windows.Forms.TextBox CLText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiceText1;
        private System.Windows.Forms.TextBox DiceText2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DiceText3;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.CheckBox EmpHealBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CritDmgText;
        private System.Windows.Forms.ComboBox skullBox;
        private System.Windows.Forms.TextBox CMText;
    }
}

