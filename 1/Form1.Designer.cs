namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pad1 = new System.Windows.Forms.Button();
            this.pad2 = new System.Windows.Forms.Button();
            this.pad3 = new System.Windows.Forms.Button();
            this.pad4 = new System.Windows.Forms.Button();
            this.pad5 = new System.Windows.Forms.Button();
            this.pad6 = new System.Windows.Forms.Button();
            this.pad7 = new System.Windows.Forms.Button();
            this.pad8 = new System.Windows.Forms.Button();
            this.pad9 = new System.Windows.Forms.Button();
            this.pad10 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.OperationResult = new System.Windows.Forms.Button();
            this.OperationPlus = new System.Windows.Forms.Button();
            this.OperationMinus = new System.Windows.Forms.Button();
            this.OperationClear = new System.Windows.Forms.Button();
            this.OperationDiv = new System.Windows.Forms.Button();
            this.OperationMult = new System.Windows.Forms.Button();
            this.OperationClearOneDigit = new System.Windows.Forms.Button();
            this.padPower = new System.Windows.Forms.Button();
            this.padSqrt = new System.Windows.Forms.Button();
            this.pad11 = new System.Windows.Forms.Button();
            this.padProcent = new System.Windows.Forms.Button();
            this.pad12 = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.padBackspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pad1
            // 
            this.pad1.BackColor = System.Drawing.SystemColors.Info;
            this.pad1.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad1.Location = new System.Drawing.Point(36, 369);
            this.pad1.Name = "pad1";
            this.pad1.Size = new System.Drawing.Size(75, 75);
            this.pad1.TabIndex = 1;
            this.pad1.Text = "1";
            this.pad1.UseVisualStyleBackColor = false;
            this.pad1.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad2
            // 
            this.pad2.BackColor = System.Drawing.SystemColors.Info;
            this.pad2.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad2.Location = new System.Drawing.Point(117, 369);
            this.pad2.Name = "pad2";
            this.pad2.Size = new System.Drawing.Size(75, 75);
            this.pad2.TabIndex = 2;
            this.pad2.Text = "2";
            this.pad2.UseVisualStyleBackColor = false;
            this.pad2.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad3
            // 
            this.pad3.BackColor = System.Drawing.SystemColors.Info;
            this.pad3.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad3.Location = new System.Drawing.Point(198, 369);
            this.pad3.Name = "pad3";
            this.pad3.Size = new System.Drawing.Size(75, 75);
            this.pad3.TabIndex = 3;
            this.pad3.Text = "3";
            this.pad3.UseVisualStyleBackColor = false;
            this.pad3.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad4
            // 
            this.pad4.BackColor = System.Drawing.SystemColors.Info;
            this.pad4.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad4.Location = new System.Drawing.Point(36, 291);
            this.pad4.Name = "pad4";
            this.pad4.Size = new System.Drawing.Size(75, 75);
            this.pad4.TabIndex = 4;
            this.pad4.Text = "4";
            this.pad4.UseVisualStyleBackColor = false;
            this.pad4.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad5
            // 
            this.pad5.BackColor = System.Drawing.SystemColors.Info;
            this.pad5.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad5.Location = new System.Drawing.Point(117, 291);
            this.pad5.Name = "pad5";
            this.pad5.Size = new System.Drawing.Size(75, 75);
            this.pad5.TabIndex = 5;
            this.pad5.Text = "5";
            this.pad5.UseVisualStyleBackColor = false;
            this.pad5.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad6
            // 
            this.pad6.BackColor = System.Drawing.SystemColors.Info;
            this.pad6.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad6.Location = new System.Drawing.Point(198, 291);
            this.pad6.Name = "pad6";
            this.pad6.Size = new System.Drawing.Size(75, 75);
            this.pad6.TabIndex = 6;
            this.pad6.Text = "6";
            this.pad6.UseVisualStyleBackColor = false;
            this.pad6.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad7
            // 
            this.pad7.BackColor = System.Drawing.SystemColors.Info;
            this.pad7.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad7.Location = new System.Drawing.Point(36, 213);
            this.pad7.Name = "pad7";
            this.pad7.Size = new System.Drawing.Size(75, 75);
            this.pad7.TabIndex = 7;
            this.pad7.Text = "7";
            this.pad7.UseVisualStyleBackColor = false;
            this.pad7.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad8
            // 
            this.pad8.BackColor = System.Drawing.SystemColors.Info;
            this.pad8.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad8.Location = new System.Drawing.Point(117, 213);
            this.pad8.Name = "pad8";
            this.pad8.Size = new System.Drawing.Size(75, 75);
            this.pad8.TabIndex = 8;
            this.pad8.Text = "8";
            this.pad8.UseVisualStyleBackColor = false;
            this.pad8.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad9
            // 
            this.pad9.BackColor = System.Drawing.SystemColors.Info;
            this.pad9.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad9.Location = new System.Drawing.Point(198, 213);
            this.pad9.Name = "pad9";
            this.pad9.Size = new System.Drawing.Size(75, 75);
            this.pad9.TabIndex = 9;
            this.pad9.Text = "9";
            this.pad9.UseVisualStyleBackColor = false;
            this.pad9.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad10
            // 
            this.pad10.BackColor = System.Drawing.SystemColors.Info;
            this.pad10.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad10.Location = new System.Drawing.Point(36, 449);
            this.pad10.Name = "pad10";
            this.pad10.Size = new System.Drawing.Size(156, 75);
            this.pad10.TabIndex = 0;
            this.pad10.Text = "0";
            this.pad10.UseVisualStyleBackColor = false;
            this.pad10.Click += new System.EventHandler(this.pad_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.display.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(36, 58);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(399, 61);
            this.display.TabIndex = 10;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // OperationResult
            // 
            this.OperationResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OperationResult.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationResult.Location = new System.Drawing.Point(360, 369);
            this.OperationResult.Name = "OperationResult";
            this.OperationResult.Size = new System.Drawing.Size(75, 155);
            this.OperationResult.TabIndex = 11;
            this.OperationResult.Text = "=";
            this.OperationResult.UseVisualStyleBackColor = false;
            this.OperationResult.Click += new System.EventHandler(this.OperationResult_Click);
            // 
            // OperationPlus
            // 
            this.OperationPlus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OperationPlus.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationPlus.Location = new System.Drawing.Point(279, 449);
            this.OperationPlus.Name = "OperationPlus";
            this.OperationPlus.Size = new System.Drawing.Size(75, 75);
            this.OperationPlus.TabIndex = 12;
            this.OperationPlus.Text = "+";
            this.OperationPlus.UseVisualStyleBackColor = false;
            this.OperationPlus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // OperationMinus
            // 
            this.OperationMinus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OperationMinus.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationMinus.Location = new System.Drawing.Point(279, 370);
            this.OperationMinus.Name = "OperationMinus";
            this.OperationMinus.Size = new System.Drawing.Size(75, 75);
            this.OperationMinus.TabIndex = 13;
            this.OperationMinus.Text = "-";
            this.OperationMinus.UseVisualStyleBackColor = false;
            this.OperationMinus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // OperationClear
            // 
            this.OperationClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OperationClear.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationClear.Location = new System.Drawing.Point(360, 213);
            this.OperationClear.Name = "OperationClear";
            this.OperationClear.Size = new System.Drawing.Size(75, 75);
            this.OperationClear.TabIndex = 14;
            this.OperationClear.Text = "C";
            this.OperationClear.UseVisualStyleBackColor = false;
            this.OperationClear.Click += new System.EventHandler(this.OperationClear_Click);
            // 
            // OperationDiv
            // 
            this.OperationDiv.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OperationDiv.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationDiv.Location = new System.Drawing.Point(279, 291);
            this.OperationDiv.Name = "OperationDiv";
            this.OperationDiv.Size = new System.Drawing.Size(75, 75);
            this.OperationDiv.TabIndex = 15;
            this.OperationDiv.Text = "/";
            this.OperationDiv.UseVisualStyleBackColor = false;
            this.OperationDiv.Click += new System.EventHandler(this.Operation_Click);
            // 
            // OperationMult
            // 
            this.OperationMult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OperationMult.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationMult.Location = new System.Drawing.Point(279, 213);
            this.OperationMult.Name = "OperationMult";
            this.OperationMult.Size = new System.Drawing.Size(75, 75);
            this.OperationMult.TabIndex = 16;
            this.OperationMult.Text = "*";
            this.OperationMult.UseVisualStyleBackColor = false;
            this.OperationMult.Click += new System.EventHandler(this.Operation_Click);
            // 
            // OperationClearOneDigit
            // 
            this.OperationClearOneDigit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OperationClearOneDigit.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationClearOneDigit.Location = new System.Drawing.Point(360, 291);
            this.OperationClearOneDigit.Name = "OperationClearOneDigit";
            this.OperationClearOneDigit.Size = new System.Drawing.Size(75, 75);
            this.OperationClearOneDigit.TabIndex = 18;
            this.OperationClearOneDigit.Text = "CE";
            this.OperationClearOneDigit.UseVisualStyleBackColor = false;
            this.OperationClearOneDigit.Click += new System.EventHandler(this.OperationClearOneDigit_Click);
            // 
            // padPower
            // 
            this.padPower.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.padPower.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padPower.Location = new System.Drawing.Point(117, 135);
            this.padPower.Name = "padPower";
            this.padPower.Size = new System.Drawing.Size(75, 75);
            this.padPower.TabIndex = 19;
            this.padPower.Text = "^2";
            this.padPower.UseVisualStyleBackColor = false;
            this.padPower.Click += new System.EventHandler(this.padPower_Click);
            // 
            // padSqrt
            // 
            this.padSqrt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.padSqrt.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padSqrt.Location = new System.Drawing.Point(36, 135);
            this.padSqrt.Name = "padSqrt";
            this.padSqrt.Size = new System.Drawing.Size(75, 75);
            this.padSqrt.TabIndex = 20;
            this.padSqrt.Text = "sqrt";
            this.padSqrt.UseVisualStyleBackColor = false;
            this.padSqrt.Click += new System.EventHandler(this.padSqrt_Click);
            // 
            // pad11
            // 
            this.pad11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pad11.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad11.Location = new System.Drawing.Point(198, 135);
            this.pad11.Name = "pad11";
            this.pad11.Size = new System.Drawing.Size(75, 75);
            this.pad11.TabIndex = 21;
            this.pad11.Text = "1/x";
            this.pad11.UseVisualStyleBackColor = false;
            this.pad11.Click += new System.EventHandler(this.pad11_Click);
            // 
            // padProcent
            // 
            this.padProcent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.padProcent.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padProcent.Location = new System.Drawing.Point(279, 135);
            this.padProcent.Name = "padProcent";
            this.padProcent.Size = new System.Drawing.Size(75, 75);
            this.padProcent.TabIndex = 22;
            this.padProcent.Text = "%";
            this.padProcent.UseVisualStyleBackColor = false;
            this.padProcent.Click += new System.EventHandler(this.padProcent_Click);
            // 
            // pad12
            // 
            this.pad12.BackColor = System.Drawing.SystemColors.Info;
            this.pad12.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pad12.Location = new System.Drawing.Point(198, 449);
            this.pad12.Name = "pad12";
            this.pad12.Size = new System.Drawing.Size(75, 75);
            this.pad12.TabIndex = 23;
            this.pad12.Text = ",";
            this.pad12.UseVisualStyleBackColor = false;
            this.pad12.Click += new System.EventHandler(this.pad_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelCurrentOperation.Location = new System.Drawing.Point(44, 18);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 37);
            this.labelCurrentOperation.TabIndex = 24;
            // 
            // padBackspace
            // 
            this.padBackspace.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.padBackspace.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padBackspace.Location = new System.Drawing.Point(360, 135);
            this.padBackspace.Name = "padBackspace";
            this.padBackspace.Size = new System.Drawing.Size(75, 75);
            this.padBackspace.TabIndex = 25;
            this.padBackspace.Text = "Back";
            this.padBackspace.UseVisualStyleBackColor = false;
            this.padBackspace.Click += new System.EventHandler(this.padBackspace_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 575);
            this.Controls.Add(this.padBackspace);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.pad12);
            this.Controls.Add(this.padProcent);
            this.Controls.Add(this.pad11);
            this.Controls.Add(this.padSqrt);
            this.Controls.Add(this.padPower);
            this.Controls.Add(this.OperationClearOneDigit);
            this.Controls.Add(this.OperationMult);
            this.Controls.Add(this.OperationDiv);
            this.Controls.Add(this.OperationClear);
            this.Controls.Add(this.OperationMinus);
            this.Controls.Add(this.OperationPlus);
            this.Controls.Add(this.OperationResult);
            this.Controls.Add(this.display);
            this.Controls.Add(this.pad10);
            this.Controls.Add(this.pad9);
            this.Controls.Add(this.pad8);
            this.Controls.Add(this.pad7);
            this.Controls.Add(this.pad6);
            this.Controls.Add(this.pad5);
            this.Controls.Add(this.pad4);
            this.Controls.Add(this.pad3);
            this.Controls.Add(this.pad2);
            this.Controls.Add(this.pad1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalc";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Operation_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }   

        #endregion

        private System.Windows.Forms.Button pad1;
        private System.Windows.Forms.Button pad2;
        private System.Windows.Forms.Button pad3;
        private System.Windows.Forms.Button pad4;
        private System.Windows.Forms.Button pad5;
        private System.Windows.Forms.Button pad6;
        private System.Windows.Forms.Button pad7;
        private System.Windows.Forms.Button pad8;
        private System.Windows.Forms.Button pad9;
        private System.Windows.Forms.Button pad10;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button OperationResult;
        private System.Windows.Forms.Button OperationPlus;
        private System.Windows.Forms.Button OperationMinus;
        private System.Windows.Forms.Button OperationClear;
        private System.Windows.Forms.Button OperationDiv;
        private System.Windows.Forms.Button OperationMult;
        private System.Windows.Forms.Button OperationClearOneDigit;
        private System.Windows.Forms.Button padPower;
        private System.Windows.Forms.Button padSqrt;
        private System.Windows.Forms.Button pad11;
        private System.Windows.Forms.Button padProcent;
        private System.Windows.Forms.Button pad12;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Button padBackspace;
    }
}

