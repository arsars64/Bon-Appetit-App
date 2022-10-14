namespace BonAppetit
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbGram = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbdeepplate = new System.Windows.Forms.RadioButton();
            this.rbwideplate = new System.Windows.Forms.RadioButton();
            this.rbnoplate = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelOfCB = new System.Windows.Forms.Panel();
            this.rbDarkPlate = new System.Windows.Forms.RadioButton();
            this.rbDarkWidePlate = new System.Windows.Forms.RadioButton();
            this.rbVerywidePlate = new System.Windows.Forms.RadioButton();
            this.bClearList = new System.Windows.Forms.Button();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCountApart = new System.Windows.Forms.CheckBox();
            this.lvOfGrams = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelOfCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGram
            // 
            this.tbGram.Location = new System.Drawing.Point(93, 2);
            this.tbGram.Name = "tbGram";
            this.tbGram.Size = new System.Drawing.Size(122, 22);
            this.tbGram.TabIndex = 0;
            this.tbGram.TextChanged += new System.EventHandler(this.tbGram_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "граммовка: ";
            // 
            // rbdeepplate
            // 
            this.rbdeepplate.AutoSize = true;
            this.rbdeepplate.Location = new System.Drawing.Point(3, 29);
            this.rbdeepplate.Name = "rbdeepplate";
            this.rbdeepplate.Size = new System.Drawing.Size(193, 20);
            this.rbdeepplate.TabIndex = 5;
            this.rbdeepplate.TabStop = true;
            this.rbdeepplate.Text = "глубокая тарелка - 345 гр";
            this.rbdeepplate.UseVisualStyleBackColor = true;
            this.rbdeepplate.CheckedChanged += new System.EventHandler(this.rbdeepplate_CheckedChanged);
            // 
            // rbwideplate
            // 
            this.rbwideplate.AutoSize = true;
            this.rbwideplate.Location = new System.Drawing.Point(3, 55);
            this.rbwideplate.Name = "rbwideplate";
            this.rbwideplate.Size = new System.Drawing.Size(188, 20);
            this.rbwideplate.TabIndex = 6;
            this.rbwideplate.TabStop = true;
            this.rbwideplate.Text = "широкая тарелка - 477 гр";
            this.rbwideplate.UseVisualStyleBackColor = true;
            this.rbwideplate.CheckedChanged += new System.EventHandler(this.rbwideplate_CheckedChanged);
            // 
            // rbnoplate
            // 
            this.rbnoplate.AutoSize = true;
            this.rbnoplate.Location = new System.Drawing.Point(3, 3);
            this.rbnoplate.Name = "rbnoplate";
            this.rbnoplate.Size = new System.Drawing.Size(109, 20);
            this.rbnoplate.TabIndex = 4;
            this.rbnoplate.TabStop = true;
            this.rbnoplate.Text = "без тарелки";
            this.rbnoplate.UseVisualStyleBackColor = true;
            this.rbnoplate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelOfCB
            // 
            this.panelOfCB.BackColor = System.Drawing.Color.LightPink;
            this.panelOfCB.Controls.Add(this.rbDarkPlate);
            this.panelOfCB.Controls.Add(this.rbDarkWidePlate);
            this.panelOfCB.Controls.Add(this.rbVerywidePlate);
            this.panelOfCB.Controls.Add(this.rbnoplate);
            this.panelOfCB.Controls.Add(this.rbdeepplate);
            this.panelOfCB.Controls.Add(this.rbwideplate);
            this.panelOfCB.Location = new System.Drawing.Point(2, 70);
            this.panelOfCB.Name = "panelOfCB";
            this.panelOfCB.Size = new System.Drawing.Size(236, 160);
            this.panelOfCB.TabIndex = 11;
            // 
            // rbDarkPlate
            // 
            this.rbDarkPlate.AutoSize = true;
            this.rbDarkPlate.Location = new System.Drawing.Point(3, 107);
            this.rbDarkPlate.Name = "rbDarkPlate";
            this.rbDarkPlate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbDarkPlate.Size = new System.Drawing.Size(180, 20);
            this.rbDarkPlate.TabIndex = 8;
            this.rbDarkPlate.TabStop = true;
            this.rbDarkPlate.Text = "темная тарелка - 276 гр";
            this.rbDarkPlate.UseVisualStyleBackColor = true;
            this.rbDarkPlate.CheckedChanged += new System.EventHandler(this.rbDarkPlate_CheckedChanged);
            // 
            // rbDarkWidePlate
            // 
            this.rbDarkWidePlate.AutoSize = true;
            this.rbDarkWidePlate.Location = new System.Drawing.Point(3, 133);
            this.rbDarkWidePlate.Name = "rbDarkWidePlate";
            this.rbDarkWidePlate.Size = new System.Drawing.Size(238, 20);
            this.rbDarkWidePlate.TabIndex = 9;
            this.rbDarkWidePlate.TabStop = true;
            this.rbDarkWidePlate.Text = "темная широкая тарелка - 411 гр";
            this.rbDarkWidePlate.UseVisualStyleBackColor = true;
            this.rbDarkWidePlate.CheckedChanged += new System.EventHandler(this.rbDarkWidePlate_CheckedChanged);
            // 
            // rbVerywidePlate
            // 
            this.rbVerywidePlate.AutoSize = true;
            this.rbVerywidePlate.Location = new System.Drawing.Point(3, 81);
            this.rbVerywidePlate.Name = "rbVerywidePlate";
            this.rbVerywidePlate.Size = new System.Drawing.Size(230, 20);
            this.rbVerywidePlate.TabIndex = 7;
            this.rbVerywidePlate.TabStop = true;
            this.rbVerywidePlate.Text = "очень широкая тарелка - 675 гр";
            this.rbVerywidePlate.UseVisualStyleBackColor = true;
            this.rbVerywidePlate.CheckedChanged += new System.EventHandler(this.rbVerywidePlate_CheckedChanged);
            // 
            // bClearList
            // 
            this.bClearList.BackColor = System.Drawing.Color.LavenderBlush;
            this.bClearList.Location = new System.Drawing.Point(221, 186);
            this.bClearList.Name = "bClearList";
            this.bClearList.Size = new System.Drawing.Size(157, 44);
            this.bClearList.TabIndex = 10;
            this.bClearList.Text = "очистить список";
            this.bClearList.UseVisualStyleBackColor = false;
            this.bClearList.Click += new System.EventHandler(this.bClearList_Click);
            // 
            // tbFoodName
            // 
            this.tbFoodName.Location = new System.Drawing.Point(93, 27);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.Size = new System.Drawing.Size(122, 22);
            this.tbFoodName.TabIndex = 1;
            this.tbFoodName.TextChanged += new System.EventHandler(this.tbFoodName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "наименование:";
            // 
            // cbCountApart
            // 
            this.cbCountApart.AutoSize = true;
            this.cbCountApart.BackColor = System.Drawing.Color.LightGreen;
            this.cbCountApart.ForeColor = System.Drawing.Color.Black;
            this.cbCountApart.Location = new System.Drawing.Point(5, 49);
            this.cbCountApart.Name = "cbCountApart";
            this.cbCountApart.Size = new System.Drawing.Size(187, 20);
            this.cbCountApart.TabIndex = 3;
            this.cbCountApart.Text = "считать по отдельности";
            this.cbCountApart.UseVisualStyleBackColor = false;
            this.cbCountApart.CheckedChanged += new System.EventHandler(this.cbCountApart_CheckedChanged);
            // 
            // lvOfGrams
            // 
            this.lvOfGrams.BackColor = System.Drawing.Color.LavenderBlush;
            this.lvOfGrams.HideSelection = false;
            this.lvOfGrams.Location = new System.Drawing.Point(221, 2);
            this.lvOfGrams.Name = "lvOfGrams";
            this.lvOfGrams.Size = new System.Drawing.Size(157, 178);
            this.lvOfGrams.TabIndex = 11;
            this.lvOfGrams.UseCompatibleStateImageBehavior = false;
            this.lvOfGrams.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(712, 236);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvOfGrams);
            this.Controls.Add(this.cbCountApart);
            this.Controls.Add(this.tbGram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFoodName);
            this.Controls.Add(this.bClearList);
            this.Controls.Add(this.panelOfCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Мой калькулятор веса еды";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelOfCB.ResumeLayout(false);
            this.panelOfCB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbdeepplate;
        private System.Windows.Forms.RadioButton rbwideplate;
        private System.Windows.Forms.RadioButton rbnoplate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelOfCB;
        private System.Windows.Forms.Button bClearList;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.RadioButton rbVerywidePlate;
        private System.Windows.Forms.RadioButton rbDarkPlate;
        private System.Windows.Forms.RadioButton rbDarkWidePlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbCountApart;
        private System.Windows.Forms.ListView lvOfGrams;
    }
}

