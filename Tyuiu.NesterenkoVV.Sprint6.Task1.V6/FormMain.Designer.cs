namespace Tyuiu.NesterenkoVV.Sprint6.Task1.V6
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
            groupСonditions = new GroupBox();
            pictureFormula = new PictureBox();
            textBox1 = new TextBox();
            groupData = new GroupBox();
            buttonInfo = new Button();
            buttonResult = new Button();
            textBoxVarEnd = new TextBox();
            textBoxVarStart = new TextBox();
            textEnd = new TextBox();
            textStart = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            textBoxRData = new TextBox();
            groupСonditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFormula).BeginInit();
            groupData.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupСonditions
            // 
            groupСonditions.Controls.Add(pictureFormula);
            groupСonditions.Controls.Add(textBox1);
            groupСonditions.Location = new Point(12, 12);
            groupСonditions.Name = "groupСonditions";
            groupСonditions.Size = new Size(503, 263);
            groupСonditions.TabIndex = 0;
            groupСonditions.TabStop = false;
            groupСonditions.Text = "Условия";
            // 
            // pictureFormula
            // 
            pictureFormula.Image = (Image)resources.GetObject("pictureFormula.Image");
            pictureFormula.Location = new Point(6, 88);
            pictureFormula.Name = "pictureFormula";
            pictureFormula.Size = new Size(480, 50);
            pictureFormula.TabIndex = 1;
            pictureFormula.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(6, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(383, 51);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапазоне .\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupData
            // 
            groupData.Controls.Add(buttonInfo);
            groupData.Controls.Add(buttonResult);
            groupData.Controls.Add(textBoxVarEnd);
            groupData.Controls.Add(textBoxVarStart);
            groupData.Controls.Add(textEnd);
            groupData.Controls.Add(textStart);
            groupData.Location = new Point(12, 281);
            groupData.Name = "groupData";
            groupData.Size = new Size(503, 141);
            groupData.TabIndex = 2;
            groupData.TabStop = false;
            groupData.Text = "Ввод данных";
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.Highlight;
            buttonInfo.FlatStyle = FlatStyle.Popup;
            buttonInfo.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInfo.Location = new Point(274, 43);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(82, 81);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Green;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonResult.Location = new Point(362, 43);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(124, 81);
            buttonResult.TabIndex = 5;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            buttonResult.MouseDown += buttonResult_MouseDown;
            // 
            // textBoxVarEnd
            // 
            textBoxVarEnd.BorderStyle = BorderStyle.FixedSingle;
            textBoxVarEnd.Location = new Point(153, 101);
            textBoxVarEnd.Name = "textBoxVarEnd";
            textBoxVarEnd.Size = new Size(100, 23);
            textBoxVarEnd.TabIndex = 4;
            // 
            // textBoxVarStart
            // 
            textBoxVarStart.BorderStyle = BorderStyle.FixedSingle;
            textBoxVarStart.Location = new Point(21, 101);
            textBoxVarStart.Name = "textBoxVarStart";
            textBoxVarStart.Size = new Size(100, 23);
            textBoxVarStart.TabIndex = 3;
            // 
            // textEnd
            // 
            textEnd.BorderStyle = BorderStyle.FixedSingle;
            textEnd.Location = new Point(153, 60);
            textEnd.Name = "textEnd";
            textEnd.ReadOnly = true;
            textEnd.Size = new Size(100, 23);
            textEnd.TabIndex = 2;
            textEnd.Text = "Конец шага:";
            // 
            // textStart
            // 
            textStart.BorderStyle = BorderStyle.FixedSingle;
            textStart.Location = new Point(21, 60);
            textStart.Name = "textStart";
            textStart.ReadOnly = true;
            textStart.Size = new Size(100, 23);
            textStart.TabIndex = 1;
            textStart.Text = "Старт шага:";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Controls.Add(textBoxRData);
            groupBoxResult.Location = new Point(521, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(267, 410);
            groupBoxResult.TabIndex = 3;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 44);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(255, 360);
            textBoxResult.TabIndex = 1;
            // 
            // textBoxRData
            // 
            textBoxRData.BorderStyle = BorderStyle.None;
            textBoxRData.Location = new Point(6, 22);
            textBoxRData.Name = "textBoxRData";
            textBoxRData.ReadOnly = true;
            textBoxRData.Size = new Size(100, 16);
            textBoxRData.TabIndex = 0;
            textBoxRData.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupData);
            Controls.Add(groupСonditions);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 6 | Нестеренко В. В. ";
            groupСonditions.ResumeLayout(false);
            groupСonditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFormula).EndInit();
            groupData.ResumeLayout(false);
            groupData.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupСonditions;
        private TextBox textBox1;
        private PictureBox pictureFormula;
        private GroupBox groupData;
        private TextBox textBoxVarEnd;
        private TextBox textBoxVarStart;
        private TextBox textEnd;
        private TextBox textStart;
        private GroupBox groupBoxResult;
        private Button buttonInfo;
        private Button buttonResult;
        private TextBox textBoxRData;
        private TextBox textBoxResult;
    }
}
