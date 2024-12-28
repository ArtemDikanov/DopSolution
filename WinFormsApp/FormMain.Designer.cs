namespace WinFormsApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_DAA = new GroupBox();
            textBoxCondition_DAA = new TextBox();
            groupBoxInputData_DAA = new GroupBox();
            textBoxInput_M_DAA = new TextBox();
            textBoxInput_k_DAA = new TextBox();
            textBoxInput_n2_DAA = new TextBox();
            textBoxInput_L_DAA = new TextBox();
            textBoxInput_c_DAA = new TextBox();
            textBoxInput_n1_DAA = new TextBox();
            textBoxInput_N_DAA = new TextBox();
            textBox_M_DAA = new TextBox();
            textBox_n1_DAA = new TextBox();
            textBox_n2_DAA = new TextBox();
            textBox_c_DAA = new TextBox();
            textBox_k_DAA = new TextBox();
            textBox_L_DAA = new TextBox();
            textBox_N_DAA = new TextBox();
            groupBoxArray_DAA = new GroupBox();
            dataGridViewArray_DAA = new DataGridView();
            groupBoxOutputData_DAA = new GroupBox();
            textBoxOutput_DAA = new TextBox();
            textBoxResult_DAA = new TextBox();
            groupBoxButtons_DAA = new GroupBox();
            buttonHelp_DAA = new Button();
            buttonResult_DAA = new Button();
            groupBoxCondition_DAA.SuspendLayout();
            groupBoxInputData_DAA.SuspendLayout();
            groupBoxArray_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray_DAA).BeginInit();
            groupBoxOutputData_DAA.SuspendLayout();
            groupBoxButtons_DAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_DAA
            // 
            groupBoxCondition_DAA.Controls.Add(textBoxCondition_DAA);
            groupBoxCondition_DAA.Location = new Point(0, 12);
            groupBoxCondition_DAA.Name = "groupBoxCondition_DAA";
            groupBoxCondition_DAA.Size = new Size(343, 250);
            groupBoxCondition_DAA.TabIndex = 0;
            groupBoxCondition_DAA.TabStop = false;
            groupBoxCondition_DAA.Text = "Условие";
            // 
            // textBoxCondition_DAA
            // 
            textBoxCondition_DAA.BackColor = SystemColors.MenuBar;
            textBoxCondition_DAA.BorderStyle = BorderStyle.None;
            textBoxCondition_DAA.Location = new Point(12, 31);
            textBoxCondition_DAA.Multiline = true;
            textBoxCondition_DAA.Name = "textBoxCondition_DAA";
            textBoxCondition_DAA.ReadOnly = true;
            textBoxCondition_DAA.Size = new Size(325, 177);
            textBoxCondition_DAA.TabIndex = 0;
            textBoxCondition_DAA.Text = resources.GetString("textBoxCondition_DAA.Text");
            // 
            // groupBoxInputData_DAA
            // 
            groupBoxInputData_DAA.Controls.Add(textBoxInput_M_DAA);
            groupBoxInputData_DAA.Controls.Add(textBoxInput_k_DAA);
            groupBoxInputData_DAA.Controls.Add(textBoxInput_n2_DAA);
            groupBoxInputData_DAA.Controls.Add(textBoxInput_L_DAA);
            groupBoxInputData_DAA.Controls.Add(textBoxInput_c_DAA);
            groupBoxInputData_DAA.Controls.Add(textBoxInput_n1_DAA);
            groupBoxInputData_DAA.Controls.Add(textBoxInput_N_DAA);
            groupBoxInputData_DAA.Controls.Add(textBox_M_DAA);
            groupBoxInputData_DAA.Controls.Add(textBox_n1_DAA);
            groupBoxInputData_DAA.Controls.Add(textBox_n2_DAA);
            groupBoxInputData_DAA.Controls.Add(textBox_c_DAA);
            groupBoxInputData_DAA.Controls.Add(textBox_k_DAA);
            groupBoxInputData_DAA.Controls.Add(textBox_L_DAA);
            groupBoxInputData_DAA.Controls.Add(textBox_N_DAA);
            groupBoxInputData_DAA.Location = new Point(360, 12);
            groupBoxInputData_DAA.Name = "groupBoxInputData_DAA";
            groupBoxInputData_DAA.Size = new Size(191, 250);
            groupBoxInputData_DAA.TabIndex = 1;
            groupBoxInputData_DAA.TabStop = false;
            groupBoxInputData_DAA.Text = "Ввод данных";
            // 
            // textBoxInput_M_DAA
            // 
            textBoxInput_M_DAA.Location = new Point(60, 54);
            textBoxInput_M_DAA.Name = "textBoxInput_M_DAA";
            textBoxInput_M_DAA.Size = new Size(100, 23);
            textBoxInput_M_DAA.TabIndex = 13;
            textBoxInput_M_DAA.KeyPress += textBoxInput_n1_DAA_KeyPress;
            // 
            // textBoxInput_k_DAA
            // 
            textBoxInput_k_DAA.Location = new Point(60, 170);
            textBoxInput_k_DAA.Name = "textBoxInput_k_DAA";
            textBoxInput_k_DAA.Size = new Size(100, 23);
            textBoxInput_k_DAA.TabIndex = 12;
            textBoxInput_k_DAA.KeyPress += textBoxInput_n1_DAA_KeyPress;
            // 
            // textBoxInput_n2_DAA
            // 
            textBoxInput_n2_DAA.Location = new Point(60, 112);
            textBoxInput_n2_DAA.Name = "textBoxInput_n2_DAA";
            textBoxInput_n2_DAA.Size = new Size(100, 23);
            textBoxInput_n2_DAA.TabIndex = 11;
            textBoxInput_n2_DAA.KeyPress += textBoxInput_n1_DAA_KeyPress;
            // 
            // textBoxInput_L_DAA
            // 
            textBoxInput_L_DAA.Location = new Point(60, 199);
            textBoxInput_L_DAA.Name = "textBoxInput_L_DAA";
            textBoxInput_L_DAA.Size = new Size(100, 23);
            textBoxInput_L_DAA.TabIndex = 10;
            textBoxInput_L_DAA.KeyPress += textBoxInput_n1_DAA_KeyPress;
            // 
            // textBoxInput_c_DAA
            // 
            textBoxInput_c_DAA.Location = new Point(60, 141);
            textBoxInput_c_DAA.Name = "textBoxInput_c_DAA";
            textBoxInput_c_DAA.Size = new Size(100, 23);
            textBoxInput_c_DAA.TabIndex = 9;
            textBoxInput_c_DAA.KeyPress += textBoxInput_n1_DAA_KeyPress;
            // 
            // textBoxInput_n1_DAA
            // 
            textBoxInput_n1_DAA.Location = new Point(60, 83);
            textBoxInput_n1_DAA.Name = "textBoxInput_n1_DAA";
            textBoxInput_n1_DAA.Size = new Size(100, 23);
            textBoxInput_n1_DAA.TabIndex = 8;
            textBoxInput_n1_DAA.KeyPress += textBoxInput_n1_DAA_KeyPress;
            // 
            // textBoxInput_N_DAA
            // 
            textBoxInput_N_DAA.Location = new Point(60, 25);
            textBoxInput_N_DAA.Name = "textBoxInput_N_DAA";
            textBoxInput_N_DAA.Size = new Size(100, 23);
            textBoxInput_N_DAA.TabIndex = 7;
            textBoxInput_N_DAA.KeyPress += textBoxInput_n1_DAA_KeyPress;
            // 
            // textBox_M_DAA
            // 
            textBox_M_DAA.BackColor = SystemColors.MenuBar;
            textBox_M_DAA.BorderStyle = BorderStyle.None;
            textBox_M_DAA.Location = new Point(16, 57);
            textBox_M_DAA.Name = "textBox_M_DAA";
            textBox_M_DAA.ReadOnly = true;
            textBox_M_DAA.Size = new Size(26, 16);
            textBox_M_DAA.TabIndex = 6;
            textBox_M_DAA.Text = "M:";
            // 
            // textBox_n1_DAA
            // 
            textBox_n1_DAA.BackColor = SystemColors.MenuBar;
            textBox_n1_DAA.BorderStyle = BorderStyle.None;
            textBox_n1_DAA.Location = new Point(16, 86);
            textBox_n1_DAA.Name = "textBox_n1_DAA";
            textBox_n1_DAA.ReadOnly = true;
            textBox_n1_DAA.Size = new Size(26, 16);
            textBox_n1_DAA.TabIndex = 5;
            textBox_n1_DAA.Text = "n1:";
            // 
            // textBox_n2_DAA
            // 
            textBox_n2_DAA.BackColor = SystemColors.MenuBar;
            textBox_n2_DAA.BorderStyle = BorderStyle.None;
            textBox_n2_DAA.Location = new Point(16, 115);
            textBox_n2_DAA.Name = "textBox_n2_DAA";
            textBox_n2_DAA.ReadOnly = true;
            textBox_n2_DAA.Size = new Size(26, 16);
            textBox_n2_DAA.TabIndex = 4;
            textBox_n2_DAA.Text = "n2:";
            // 
            // textBox_c_DAA
            // 
            textBox_c_DAA.BackColor = SystemColors.MenuBar;
            textBox_c_DAA.BorderStyle = BorderStyle.None;
            textBox_c_DAA.Location = new Point(16, 144);
            textBox_c_DAA.Name = "textBox_c_DAA";
            textBox_c_DAA.ReadOnly = true;
            textBox_c_DAA.Size = new Size(26, 16);
            textBox_c_DAA.TabIndex = 3;
            textBox_c_DAA.Text = "c:";
            // 
            // textBox_k_DAA
            // 
            textBox_k_DAA.BackColor = SystemColors.MenuBar;
            textBox_k_DAA.BorderStyle = BorderStyle.None;
            textBox_k_DAA.Location = new Point(16, 173);
            textBox_k_DAA.Name = "textBox_k_DAA";
            textBox_k_DAA.ReadOnly = true;
            textBox_k_DAA.Size = new Size(26, 16);
            textBox_k_DAA.TabIndex = 2;
            textBox_k_DAA.Text = "k:";
            // 
            // textBox_L_DAA
            // 
            textBox_L_DAA.BackColor = SystemColors.MenuBar;
            textBox_L_DAA.BorderStyle = BorderStyle.None;
            textBox_L_DAA.Location = new Point(16, 202);
            textBox_L_DAA.Name = "textBox_L_DAA";
            textBox_L_DAA.ReadOnly = true;
            textBox_L_DAA.Size = new Size(26, 16);
            textBox_L_DAA.TabIndex = 1;
            textBox_L_DAA.Text = "l:";
            // 
            // textBox_N_DAA
            // 
            textBox_N_DAA.BackColor = SystemColors.MenuBar;
            textBox_N_DAA.BorderStyle = BorderStyle.None;
            textBox_N_DAA.Location = new Point(16, 28);
            textBox_N_DAA.Name = "textBox_N_DAA";
            textBox_N_DAA.ReadOnly = true;
            textBox_N_DAA.Size = new Size(26, 16);
            textBox_N_DAA.TabIndex = 0;
            textBox_N_DAA.Text = "N:";
            // 
            // groupBoxArray_DAA
            // 
            groupBoxArray_DAA.Controls.Add(dataGridViewArray_DAA);
            groupBoxArray_DAA.Location = new Point(568, 12);
            groupBoxArray_DAA.Name = "groupBoxArray_DAA";
            groupBoxArray_DAA.Size = new Size(235, 250);
            groupBoxArray_DAA.TabIndex = 2;
            groupBoxArray_DAA.TabStop = false;
            groupBoxArray_DAA.Text = "Массив";
            // 
            // dataGridViewArray_DAA
            // 
            dataGridViewArray_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArray_DAA.Location = new Point(6, 22);
            dataGridViewArray_DAA.Name = "dataGridViewArray_DAA";
            dataGridViewArray_DAA.Size = new Size(223, 222);
            dataGridViewArray_DAA.TabIndex = 0;
            // 
            // groupBoxOutputData_DAA
            // 
            groupBoxOutputData_DAA.Controls.Add(textBoxOutput_DAA);
            groupBoxOutputData_DAA.Controls.Add(textBoxResult_DAA);
            groupBoxOutputData_DAA.Location = new Point(574, 268);
            groupBoxOutputData_DAA.Name = "groupBoxOutputData_DAA";
            groupBoxOutputData_DAA.Size = new Size(229, 170);
            groupBoxOutputData_DAA.TabIndex = 3;
            groupBoxOutputData_DAA.TabStop = false;
            groupBoxOutputData_DAA.Text = "Результат";
            // 
            // textBoxOutput_DAA
            // 
            textBoxOutput_DAA.Location = new Point(11, 66);
            textBoxOutput_DAA.Name = "textBoxOutput_DAA";
            textBoxOutput_DAA.ReadOnly = true;
            textBoxOutput_DAA.Size = new Size(100, 23);
            textBoxOutput_DAA.TabIndex = 1;
            // 
            // textBoxResult_DAA
            // 
            textBoxResult_DAA.BackColor = SystemColors.MenuBar;
            textBoxResult_DAA.BorderStyle = BorderStyle.None;
            textBoxResult_DAA.Location = new Point(11, 31);
            textBoxResult_DAA.Name = "textBoxResult_DAA";
            textBoxResult_DAA.ReadOnly = true;
            textBoxResult_DAA.Size = new Size(121, 16);
            textBoxResult_DAA.TabIndex = 0;
            textBoxResult_DAA.Text = "Среднее значение:";
            // 
            // groupBoxButtons_DAA
            // 
            groupBoxButtons_DAA.Controls.Add(buttonHelp_DAA);
            groupBoxButtons_DAA.Controls.Add(buttonResult_DAA);
            groupBoxButtons_DAA.Location = new Point(0, 268);
            groupBoxButtons_DAA.Name = "groupBoxButtons_DAA";
            groupBoxButtons_DAA.Size = new Size(568, 170);
            groupBoxButtons_DAA.TabIndex = 4;
            groupBoxButtons_DAA.TabStop = false;
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.BackColor = Color.FromArgb(128, 255, 255);
            buttonHelp_DAA.Location = new Point(314, 66);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(102, 48);
            buttonHelp_DAA.TabIndex = 1;
            buttonHelp_DAA.Text = "Справка";
            buttonHelp_DAA.UseVisualStyleBackColor = false;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // buttonResult_DAA
            // 
            buttonResult_DAA.BackColor = Color.FromArgb(128, 255, 128);
            buttonResult_DAA.Location = new Point(149, 66);
            buttonResult_DAA.Name = "buttonResult_DAA";
            buttonResult_DAA.Size = new Size(102, 48);
            buttonResult_DAA.TabIndex = 0;
            buttonResult_DAA.Text = "Выполнить";
            buttonResult_DAA.UseVisualStyleBackColor = false;
            buttonResult_DAA.Click += buttonResult_DAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxButtons_DAA);
            Controls.Add(groupBoxOutputData_DAA);
            Controls.Add(groupBoxArray_DAA);
            Controls.Add(groupBoxInputData_DAA);
            Controls.Add(groupBoxCondition_DAA);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт- ревью | Спринт 6 | Диканов А.А.";
            Load += FormMain_Load;
            groupBoxCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.PerformLayout();
            groupBoxInputData_DAA.ResumeLayout(false);
            groupBoxInputData_DAA.PerformLayout();
            groupBoxArray_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray_DAA).EndInit();
            groupBoxOutputData_DAA.ResumeLayout(false);
            groupBoxOutputData_DAA.PerformLayout();
            groupBoxButtons_DAA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAA;
        private TextBox textBoxCondition_DAA;
        private GroupBox groupBoxInputData_DAA;
        private GroupBox groupBoxArray_DAA;
        private DataGridView dataGridViewArray_DAA;
        private GroupBox groupBoxOutputData_DAA;
        private TextBox textBoxInput_M_DAA;
        private TextBox textBoxInput_k_DAA;
        private TextBox textBoxInput_n2_DAA;
        private TextBox textBoxInput_L_DAA;
        private TextBox textBoxInput_c_DAA;
        private TextBox textBoxInput_n1_DAA;
        private TextBox textBoxInput_N_DAA;
        private TextBox textBox_M_DAA;
        private TextBox textBox_n1_DAA;
        private TextBox textBox_n2_DAA;
        private TextBox textBox_c_DAA;
        private TextBox textBox_k_DAA;
        private TextBox textBox_L_DAA;
        private TextBox textBox_N_DAA;
        private TextBox textBoxOutput_DAA;
        private TextBox textBoxResult_DAA;
        private GroupBox groupBoxButtons_DAA;
        private Button buttonResult_DAA;
        private Button buttonHelp_DAA;
    }
}
