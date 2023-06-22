namespace Number_Blink_Game
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.cbDigits = new System.Windows.Forms.ComboBox();
            this.lblDigit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(73, 22);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 32);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "0S";
            // 
            // cbDigits
            // 
            this.cbDigits.FormattingEnabled = true;
            this.cbDigits.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbDigits.Location = new System.Drawing.Point(651, 22);
            this.cbDigits.Name = "cbDigits";
            this.cbDigits.Size = new System.Drawing.Size(121, 24);
            this.cbDigits.TabIndex = 1;
            this.cbDigits.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDigit
            // 
            this.lblDigit.AutoSize = true;
            this.lblDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigit.Location = new System.Drawing.Point(548, 14);
            this.lblDigit.Name = "lblDigit";
            this.lblDigit.Size = new System.Drawing.Size(80, 32);
            this.lblDigit.TabIndex = 2;
            this.lblDigit.Text = "Digit:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Location = new System.Drawing.Point(156, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(177, 36);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(30, 32);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGuess);
            this.groupBox2.Location = new System.Drawing.Point(156, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(161, 43);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(0, 32);
            this.lblGuess.TabIndex = 6;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(156, 532);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 61);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.Location = new System.Drawing.Point(448, 477);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 49);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(461, 532);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 61);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Blue;
            this.btnZero.Location = new System.Drawing.Point(156, 419);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(54, 50);
            this.btnZero.TabIndex = 8;
            this.btnZero.Tag = "0";
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Visible = false;
            this.btnZero.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Blue;
            this.btnFour.Location = new System.Drawing.Point(522, 421);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(54, 50);
            this.btnFour.TabIndex = 9;
            this.btnFour.Tag = "4";
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Visible = false;
            this.btnFour.Click += new System.EventHandler(this.button_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Blue;
            this.btnThree.Location = new System.Drawing.Point(434, 419);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(54, 50);
            this.btnThree.TabIndex = 10;
            this.btnThree.Tag = "3";
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Visible = false;
            this.btnThree.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Blue;
            this.btnTwo.Location = new System.Drawing.Point(353, 419);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(54, 50);
            this.btnTwo.TabIndex = 11;
            this.btnTwo.Tag = "2";
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Visible = false;
            this.btnTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Blue;
            this.btnOne.Location = new System.Drawing.Point(248, 419);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(54, 50);
            this.btnOne.TabIndex = 12;
            this.btnOne.Tag = "1";
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Visible = false;
            this.btnOne.Click += new System.EventHandler(this.button_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Blue;
            this.btnFive.Location = new System.Drawing.Point(156, 337);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(54, 50);
            this.btnFive.TabIndex = 13;
            this.btnFive.Tag = "5";
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Visible = false;
            this.btnFive.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Blue;
            this.btnEight.Location = new System.Drawing.Point(434, 337);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(54, 50);
            this.btnEight.TabIndex = 14;
            this.btnEight.Tag = "8";
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Visible = false;
            this.btnEight.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Blue;
            this.btnSeven.Location = new System.Drawing.Point(353, 337);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(54, 50);
            this.btnSeven.TabIndex = 15;
            this.btnSeven.Tag = "7";
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Visible = false;
            this.btnSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Blue;
            this.btnSix.Location = new System.Drawing.Point(248, 337);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(54, 50);
            this.btnSix.TabIndex = 16;
            this.btnSix.Tag = "6";
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Visible = false;
            this.btnSix.Click += new System.EventHandler(this.button_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Blue;
            this.btnNine.Location = new System.Drawing.Point(522, 337);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(54, 50);
            this.btnNine.TabIndex = 17;
            this.btnNine.Tag = "9";
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Visible = false;
            this.btnNine.Click += new System.EventHandler(this.button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(333, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 32);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Stats";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDigit);
            this.Controls.Add(this.cbDigits);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbDigits;
        private System.Windows.Forms.Label lblDigit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

