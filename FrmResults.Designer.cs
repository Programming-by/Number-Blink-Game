namespace Number_Blink_Game
{
    partial class FrmResults
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
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRightAnswers = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(160, 45);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(109, 32);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "True Answers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wrong Answers:";
            // 
            // lblRightAnswers
            // 
            this.lblRightAnswers.AutoSize = true;
            this.lblRightAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightAnswers.Location = new System.Drawing.Point(213, 173);
            this.lblRightAnswers.Name = "lblRightAnswers";
            this.lblRightAnswers.Size = new System.Drawing.Size(30, 32);
            this.lblRightAnswers.TabIndex = 3;
            this.lblRightAnswers.Text = "0";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswers.Location = new System.Drawing.Point(239, 272);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(30, 32);
            this.lblWrongAnswers.TabIndex = 4;
            this.lblWrongAnswers.Text = "0";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(132, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 63);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 492);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblWrongAnswers);
            this.Controls.Add(this.lblRightAnswers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Name = "FrmResults";
            this.Text = "FrmResults";
            this.Load += new System.EventHandler(this.FrmResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRightAnswers;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Button btnBack;
    }
}