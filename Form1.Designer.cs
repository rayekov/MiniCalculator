namespace MiniCalculator
{
    partial class Calculator
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
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.btnDigitCE = new System.Windows.Forms.Button();
            this.btnDigitAC = new System.Windows.Forms.Button();
            this.btnOperatorEqual = new System.Windows.Forms.Button();
            this.btnOperatorDivision = new System.Windows.Forms.Button();
            this.btnOperatorMultiplication = new System.Windows.Forms.Button();
            this.btnOperatorSubstraction = new System.Windows.Forms.Button();
            this.btnOperatorAddition = new System.Windows.Forms.Button();
            this.btnDigit7 = new System.Windows.Forms.Button();
            this.btnDigitDot = new System.Windows.Forms.Button();
            this.btnDigit2 = new System.Windows.Forms.Button();
            this.btnDigit1 = new System.Windows.Forms.Button();
            this.btnDigit8 = new System.Windows.Forms.Button();
            this.btnDigit4 = new System.Windows.Forms.Button();
            this.btnDigit5 = new System.Windows.Forms.Button();
            this.btnDigit9 = new System.Windows.Forms.Button();
            this.btnDigit6 = new System.Windows.Forms.Button();
            this.btnDigit3 = new System.Windows.Forms.Button();
            this.btnDigit0 = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonModulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxDisplay.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDisplay.Location = new System.Drawing.Point(3, 3);
            this.txtBoxDisplay.Multiline = true;
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.ReadOnly = true;
            this.txtBoxDisplay.Size = new System.Drawing.Size(295, 94);
            this.txtBoxDisplay.TabIndex = 0;
            this.txtBoxDisplay.Text = "0";
            this.txtBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxDisplay.UseWaitCursor = true;
            // 
            // btnDigitCE
            // 
            this.btnDigitCE.BackColor = System.Drawing.Color.Orange;
            this.btnDigitCE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigitCE.Location = new System.Drawing.Point(230, 103);
            this.btnDigitCE.Name = "btnDigitCE";
            this.btnDigitCE.Size = new System.Drawing.Size(68, 40);
            this.btnDigitCE.TabIndex = 1;
            this.btnDigitCE.Text = "CE";
            this.btnDigitCE.UseVisualStyleBackColor = false;
            this.btnDigitCE.UseWaitCursor = true;
            this.btnDigitCE.Click += new System.EventHandler(this.btnDigitCE_Click);
            // 
            // btnDigitAC
            // 
            this.btnDigitAC.BackColor = System.Drawing.Color.Salmon;
            this.btnDigitAC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigitAC.Location = new System.Drawing.Point(230, 149);
            this.btnDigitAC.Name = "btnDigitAC";
            this.btnDigitAC.Size = new System.Drawing.Size(68, 40);
            this.btnDigitAC.TabIndex = 2;
            this.btnDigitAC.Text = "AC";
            this.btnDigitAC.UseVisualStyleBackColor = false;
            this.btnDigitAC.UseWaitCursor = true;
            this.btnDigitAC.Click += new System.EventHandler(this.btnDigitAC_Click);
            // 
            // btnOperatorEqual
            // 
            this.btnOperatorEqual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperatorEqual.Location = new System.Drawing.Point(230, 195);
            this.btnOperatorEqual.Name = "btnOperatorEqual";
            this.btnOperatorEqual.Size = new System.Drawing.Size(68, 133);
            this.btnOperatorEqual.TabIndex = 3;
            this.btnOperatorEqual.Text = "=";
            this.btnOperatorEqual.UseVisualStyleBackColor = true;
            this.btnOperatorEqual.UseWaitCursor = true;
            this.btnOperatorEqual.Click += new System.EventHandler(this.btnOperatorEqual_click);
            // 
            // btnOperatorDivision
            // 
            this.btnOperatorDivision.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOperatorDivision.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperatorDivision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOperatorDivision.Location = new System.Drawing.Point(172, 149);
            this.btnOperatorDivision.Name = "btnOperatorDivision";
            this.btnOperatorDivision.Size = new System.Drawing.Size(51, 40);
            this.btnOperatorDivision.TabIndex = 4;
            this.btnOperatorDivision.Text = "/";
            this.btnOperatorDivision.UseVisualStyleBackColor = false;
            this.btnOperatorDivision.UseWaitCursor = true;
            this.btnOperatorDivision.Click += new System.EventHandler(this.btnOperator_click);
            // 
            // btnOperatorMultiplication
            // 
            this.btnOperatorMultiplication.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOperatorMultiplication.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperatorMultiplication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOperatorMultiplication.Location = new System.Drawing.Point(172, 195);
            this.btnOperatorMultiplication.Name = "btnOperatorMultiplication";
            this.btnOperatorMultiplication.Size = new System.Drawing.Size(51, 40);
            this.btnOperatorMultiplication.TabIndex = 5;
            this.btnOperatorMultiplication.Text = "x";
            this.btnOperatorMultiplication.UseVisualStyleBackColor = false;
            this.btnOperatorMultiplication.UseWaitCursor = true;
            this.btnOperatorMultiplication.Click += new System.EventHandler(this.btnOperator_click);
            // 
            // btnOperatorSubstraction
            // 
            this.btnOperatorSubstraction.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOperatorSubstraction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperatorSubstraction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOperatorSubstraction.Location = new System.Drawing.Point(172, 241);
            this.btnOperatorSubstraction.Name = "btnOperatorSubstraction";
            this.btnOperatorSubstraction.Size = new System.Drawing.Size(51, 40);
            this.btnOperatorSubstraction.TabIndex = 6;
            this.btnOperatorSubstraction.Text = "-";
            this.btnOperatorSubstraction.UseVisualStyleBackColor = false;
            this.btnOperatorSubstraction.UseWaitCursor = true;
            this.btnOperatorSubstraction.Click += new System.EventHandler(this.btnOperator_click);
            // 
            // btnOperatorAddition
            // 
            this.btnOperatorAddition.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOperatorAddition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperatorAddition.Location = new System.Drawing.Point(135, 287);
            this.btnOperatorAddition.Name = "btnOperatorAddition";
            this.btnOperatorAddition.Size = new System.Drawing.Size(88, 40);
            this.btnOperatorAddition.TabIndex = 7;
            this.btnOperatorAddition.Text = "+";
            this.btnOperatorAddition.UseVisualStyleBackColor = false;
            this.btnOperatorAddition.UseWaitCursor = true;
            this.btnOperatorAddition.Click += new System.EventHandler(this.btnOperator_click);
            // 
            // btnDigit7
            // 
            this.btnDigit7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit7.Location = new System.Drawing.Point(3, 242);
            this.btnDigit7.Name = "btnDigit7";
            this.btnDigit7.Size = new System.Drawing.Size(51, 40);
            this.btnDigit7.TabIndex = 8;
            this.btnDigit7.Text = "7";
            this.btnDigit7.UseVisualStyleBackColor = true;
            this.btnDigit7.UseWaitCursor = true;
            this.btnDigit7.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigitDot
            // 
            this.btnDigitDot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigitDot.Location = new System.Drawing.Point(78, 287);
            this.btnDigitDot.Name = "btnDigitDot";
            this.btnDigitDot.Size = new System.Drawing.Size(51, 40);
            this.btnDigitDot.TabIndex = 9;
            this.btnDigitDot.Text = ".";
            this.btnDigitDot.UseVisualStyleBackColor = true;
            this.btnDigitDot.UseWaitCursor = true;
            this.btnDigitDot.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit2
            // 
            this.btnDigit2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit2.Location = new System.Drawing.Point(60, 149);
            this.btnDigit2.Name = "btnDigit2";
            this.btnDigit2.Size = new System.Drawing.Size(51, 40);
            this.btnDigit2.TabIndex = 10;
            this.btnDigit2.Text = "2";
            this.btnDigit2.UseVisualStyleBackColor = true;
            this.btnDigit2.UseWaitCursor = true;
            this.btnDigit2.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit1
            // 
            this.btnDigit1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit1.Location = new System.Drawing.Point(3, 149);
            this.btnDigit1.Name = "btnDigit1";
            this.btnDigit1.Size = new System.Drawing.Size(51, 41);
            this.btnDigit1.TabIndex = 11;
            this.btnDigit1.Text = "1";
            this.btnDigit1.UseVisualStyleBackColor = true;
            this.btnDigit1.UseWaitCursor = true;
            this.btnDigit1.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit8
            // 
            this.btnDigit8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit8.Location = new System.Drawing.Point(60, 241);
            this.btnDigit8.Name = "btnDigit8";
            this.btnDigit8.Size = new System.Drawing.Size(51, 40);
            this.btnDigit8.TabIndex = 12;
            this.btnDigit8.Text = "8";
            this.btnDigit8.UseVisualStyleBackColor = true;
            this.btnDigit8.UseWaitCursor = true;
            this.btnDigit8.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit4
            // 
            this.btnDigit4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit4.Location = new System.Drawing.Point(3, 196);
            this.btnDigit4.Name = "btnDigit4";
            this.btnDigit4.Size = new System.Drawing.Size(51, 40);
            this.btnDigit4.TabIndex = 13;
            this.btnDigit4.Text = "4";
            this.btnDigit4.UseVisualStyleBackColor = true;
            this.btnDigit4.UseWaitCursor = true;
            this.btnDigit4.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit5
            // 
            this.btnDigit5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit5.Location = new System.Drawing.Point(60, 195);
            this.btnDigit5.Name = "btnDigit5";
            this.btnDigit5.Size = new System.Drawing.Size(51, 40);
            this.btnDigit5.TabIndex = 14;
            this.btnDigit5.Text = "5";
            this.btnDigit5.UseVisualStyleBackColor = true;
            this.btnDigit5.UseWaitCursor = true;
            this.btnDigit5.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit9
            // 
            this.btnDigit9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit9.Location = new System.Drawing.Point(117, 242);
            this.btnDigit9.Name = "btnDigit9";
            this.btnDigit9.Size = new System.Drawing.Size(51, 40);
            this.btnDigit9.TabIndex = 15;
            this.btnDigit9.Text = "9";
            this.btnDigit9.UseVisualStyleBackColor = true;
            this.btnDigit9.UseWaitCursor = true;
            this.btnDigit9.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit6
            // 
            this.btnDigit6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit6.Location = new System.Drawing.Point(117, 196);
            this.btnDigit6.Name = "btnDigit6";
            this.btnDigit6.Size = new System.Drawing.Size(51, 40);
            this.btnDigit6.TabIndex = 16;
            this.btnDigit6.Text = "6";
            this.btnDigit6.UseVisualStyleBackColor = true;
            this.btnDigit6.UseWaitCursor = true;
            this.btnDigit6.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit3
            // 
            this.btnDigit3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit3.Location = new System.Drawing.Point(117, 150);
            this.btnDigit3.Name = "btnDigit3";
            this.btnDigit3.Size = new System.Drawing.Size(51, 40);
            this.btnDigit3.TabIndex = 17;
            this.btnDigit3.Text = "3";
            this.btnDigit3.UseVisualStyleBackColor = true;
            this.btnDigit3.UseWaitCursor = true;
            this.btnDigit3.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit0
            // 
            this.btnDigit0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit0.Location = new System.Drawing.Point(3, 287);
            this.btnDigit0.Name = "btnDigit0";
            this.btnDigit0.Size = new System.Drawing.Size(69, 40);
            this.btnDigit0.TabIndex = 18;
            this.btnDigit0.Text = "0";
            this.btnDigit0.UseVisualStyleBackColor = true;
            this.btnDigit0.UseWaitCursor = true;
            this.btnDigit0.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::MiniCalculator.Properties.Resources.cameroun_nouveau_texte_loi_ado;
            this.pictureBoxLogo.Location = new System.Drawing.Point(117, 354);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 10);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 19;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.UseWaitCursor = true;
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.labelDisplay.Font = new System.Drawing.Font("Unispace", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelDisplay.ForeColor = System.Drawing.Color.IndianRed;
            this.labelDisplay.Location = new System.Drawing.Point(12, 69);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDisplay.Size = new System.Drawing.Size(31, 15);
            this.labelDisplay.TabIndex = 20;
            this.labelDisplay.Text = "...";
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelDisplay.UseWaitCursor = true;
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSqrt.Location = new System.Drawing.Point(60, 102);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(51, 41);
            this.buttonSqrt.TabIndex = 21;
            this.buttonSqrt.Text = "sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.UseWaitCursor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.btnOperator_click);
            // 
            // buttonModulo
            // 
            this.buttonModulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModulo.Location = new System.Drawing.Point(3, 103);
            this.buttonModulo.Name = "buttonModulo";
            this.buttonModulo.Size = new System.Drawing.Size(51, 41);
            this.buttonModulo.TabIndex = 24;
            this.buttonModulo.Text = "%";
            this.buttonModulo.UseVisualStyleBackColor = true;
            this.buttonModulo.UseWaitCursor = true;
            this.buttonModulo.Click += new System.EventHandler(this.btnOperator_click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(302, 376);
            this.Controls.Add(this.buttonModulo);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnDigit0);
            this.Controls.Add(this.btnDigit3);
            this.Controls.Add(this.btnDigit6);
            this.Controls.Add(this.btnDigit9);
            this.Controls.Add(this.btnDigit5);
            this.Controls.Add(this.btnDigit4);
            this.Controls.Add(this.btnDigit8);
            this.Controls.Add(this.btnDigit1);
            this.Controls.Add(this.btnDigit2);
            this.Controls.Add(this.btnDigitDot);
            this.Controls.Add(this.btnDigit7);
            this.Controls.Add(this.btnOperatorAddition);
            this.Controls.Add(this.btnOperatorSubstraction);
            this.Controls.Add(this.btnOperatorMultiplication);
            this.Controls.Add(this.btnOperatorDivision);
            this.Controls.Add(this.btnOperatorEqual);
            this.Controls.Add(this.btnDigitAC);
            this.Controls.Add(this.btnDigitCE);
            this.Controls.Add(this.txtBoxDisplay);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "MiniCalculator";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxDisplay;
        private Button btnDigitCE;
        private Button btnDigitAC;
        private Button btnOperatorEqual;
        private Button btnOperatorDivision;
        private Button btnOperatorMultiplication;
        private Button btnOperatorSubstraction;
        private Button btnOperatorAddition;
        private Button btnDigit7;
        private Button btnDigitDot;
        private Button btnDigit2;
        private Button btnDigit1;
        private Button btnDigit8;
        private Button btnDigit4;
        private Button btnDigit5;
        private Button btnDigit9;
        private Button btnDigit6;
        private Button btnDigit3;
        private Button btnDigit0;
        private PictureBox pictureBoxLogo;
        private Label labelDisplay;
        private Button buttonSqrt;
        private Button buttonModulo;
    }
}