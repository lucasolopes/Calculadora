namespace Calculadora
{
    partial class Main
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_history = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_ruber = new System.Windows.Forms.Button();
            this.btn_separator = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(2, 3);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(88, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Calculadora";
            // 
            // lbl_history
            // 
            this.lbl_history.AutoSize = true;
            this.lbl_history.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_history.Location = new System.Drawing.Point(294, 35);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(0, 15);
            this.lbl_history.TabIndex = 1;
            // 
            // txt_input
            // 
            this.txt_input.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_input.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_input.Location = new System.Drawing.Point(12, 64);
            this.txt_input.MaxLength = 0;
            this.txt_input.Name = "txt_input";
            this.txt_input.ReadOnly = true;
            this.txt_input.ShortcutsEnabled = false;
            this.txt_input.Size = new System.Drawing.Size(317, 36);
            this.txt_input.TabIndex = 0;
            this.txt_input.TabStop = false;
            this.txt_input.Text = "0";
            this.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_equal.Location = new System.Drawing.Point(252, 282);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(84, 45);
            this.btn_equal.TabIndex = 23;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.equal_click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(252, 238);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 45);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.operador_click);
            // 
            // btn_subtract
            // 
            this.btn_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_subtract.Location = new System.Drawing.Point(252, 194);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(84, 45);
            this.btn_subtract.TabIndex = 21;
            this.btn_subtract.Text = "-";
            this.btn_subtract.UseVisualStyleBackColor = true;
            this.btn_subtract.Click += new System.EventHandler(this.operador_click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_multiply.Location = new System.Drawing.Point(252, 150);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(84, 45);
            this.btn_multiply.TabIndex = 20;
            this.btn_multiply.Text = "X";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.operador_click);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_division.Location = new System.Drawing.Point(252, 106);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(84, 45);
            this.btn_division.TabIndex = 19;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.operador_click);
            // 
            // btn_ruber
            // 
            this.btn_ruber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ruber.Location = new System.Drawing.Point(169, 106);
            this.btn_ruber.Name = "btn_ruber";
            this.btn_ruber.Size = new System.Drawing.Size(84, 45);
            this.btn_ruber.TabIndex = 18;
            this.btn_ruber.Text = "←";
            this.btn_ruber.UseVisualStyleBackColor = true;
            this.btn_ruber.Click += new System.EventHandler(this.btn_ruber_Click);
            // 
            // btn_separator
            // 
            this.btn_separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_separator.Location = new System.Drawing.Point(169, 282);
            this.btn_separator.Name = "btn_separator";
            this.btn_separator.Size = new System.Drawing.Size(83, 45);
            this.btn_separator.TabIndex = 17;
            this.btn_separator.Text = ",";
            this.btn_separator.UseVisualStyleBackColor = true;
            this.btn_separator.Click += new System.EventHandler(this.btn_separator_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(169, 238);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(83, 45);
            this.btn_3.TabIndex = 16;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.number_click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(169, 194);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(83, 45);
            this.btn_6.TabIndex = 15;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.number_click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(169, 150);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(83, 45);
            this.btn_9.TabIndex = 14;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.number_click);
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clearAll.Location = new System.Drawing.Point(86, 106);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(83, 45);
            this.btn_clearAll.TabIndex = 12;
            this.btn_clearAll.Text = "C";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            this.btn_clearAll.Click += new System.EventHandler(this.clear_all_click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_0.Location = new System.Drawing.Point(86, 282);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(84, 45);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.number_click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(86, 238);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(84, 45);
            this.btn_2.TabIndex = 10;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.number_click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(86, 194);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(84, 45);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.number_click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(86, 150);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(84, 45);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.number_click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(3, 106);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 45);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "CE";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.clear_click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(4, 238);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(83, 45);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.number_click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(4, 194);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(83, 45);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.number_click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(4, 150);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(83, 45);
            this.btn_7.TabIndex = 2;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.number_click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(339, 331);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_subtract);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_ruber);
            this.Controls.Add(this.btn_separator);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_5);
            this.MinimumSize = new System.Drawing.Size(355, 370);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_name;
        private Button btn_equal;
        private Button btn_add;
        private Button btn_subtract;
        private Button btn_multiply;
        private Button btn_division;
        private Button btn_ruber;
        private Button btn_separator;
        private Button btn_3;
        private Button btn_6;
        private Button btn_9;
        private Button btn_clearAll;
        private Button btn_0;
        private Button btn_2;
        private Button btn_5;
        private Button btn_8;
        private Button btn_clear;
        private Button btn_1;
        private Button btn_4;
        private Button btn_7;
        private Label lbl_history;
        private TextBox txt_input;
    }
}