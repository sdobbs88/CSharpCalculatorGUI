namespace CSharpCalculatorGUI
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblCurrentOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(26, 126);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnClickNum);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(128, 126);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnClickNum);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(77, 126);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnClickNum);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(230, 126);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(62, 45);
            this.btnCE.TabIndex = 3;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.clickCE);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(179, 126);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(45, 45);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.MouseCaptureChanged += new System.EventHandler(this.btnOperator);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(128, 177);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnClickNum);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(179, 177);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(45, 45);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnOperator);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(230, 177);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(62, 45);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.clickClear);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(77, 177);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnClickNum);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(26, 177);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnClickNum);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(230, 228);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(62, 96);
            this.btnEqual.TabIndex = 10;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.clickEqual);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(179, 228);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(45, 45);
            this.btnSubtract.TabIndex = 11;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnOperator);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(128, 228);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnClickNum);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(77, 228);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnClickNum);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(179, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOperator);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(128, 279);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(45, 45);
            this.btnDot.TabIndex = 17;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnClickNum);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(26, 279);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 45);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnClickNum);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(26, 68);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(262, 52);
            this.tbResult.TabIndex = 20;
            this.tbResult.Text = "0";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(26, 228);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 21;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnClickNum);
            // 
            // lblCurrentOp
            // 
            this.lblCurrentOp.AutoSize = true;
            this.lblCurrentOp.Font = new System.Drawing.Font("Ravenscroft", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOp.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCurrentOp.Location = new System.Drawing.Point(26, 13);
            this.lblCurrentOp.Name = "lblCurrentOp";
            this.lblCurrentOp.Size = new System.Drawing.Size(28, 45);
            this.lblCurrentOp.TabIndex = 22;
            this.lblCurrentOp.Text = "0";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 342);
            this.Controls.Add(this.lblCurrentOp);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblCurrentOp;
    }
}

