namespace Tyuiu.NesterenkoVV.Sprint6.Task4.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxUsl = new GroupBox();
            textBoxInfo = new TextBox();
            groupBoxInput = new GroupBox();
            buttonSave = new Button();
            buttonInfo = new Button();
            buttonDone = new Button();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            groupBoxResult = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult = new TextBox();
            groupBoxUsl.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(textBoxInfo);
            groupBoxUsl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxUsl.Location = new Point(12, 12);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(404, 124);
            groupBoxUsl.TabIndex = 2;
            groupBoxUsl.TabStop = false;
            groupBoxUsl.Text = "Условие";
            // 
            // textBoxInfo
            // 
            textBoxInfo.BorderStyle = BorderStyle.FixedSingle;
            textBoxInfo.Location = new Point(6, 26);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(385, 85);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.TabStop = false;
            textBoxInfo.Text = "Протабулировать функцию от -5 до 5.\r\nРезультат вывести в textBOX.Вывести функицию и сохранить в OutPutFileTask4V3.txt\r\n";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(buttonSave);
            groupBoxInput.Controls.Add(buttonInfo);
            groupBoxInput.Controls.Add(buttonDone);
            groupBoxInput.Controls.Add(textBoxStop);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Controls.Add(textBoxB);
            groupBoxInput.Controls.Add(textBoxA);
            groupBoxInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxInput.Location = new Point(435, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(683, 124);
            groupBoxInput.TabIndex = 3;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных:";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Aqua;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Location = new Point(434, 30);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 79);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.ActiveCaption;
            buttonInfo.FlatStyle = FlatStyle.Popup;
            buttonInfo.Location = new Point(354, 30);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(64, 79);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.FlatStyle = FlatStyle.Popup;
            buttonDone.Location = new Point(557, 30);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 79);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxStop
            // 
            textBoxStop.BorderStyle = BorderStyle.FixedSingle;
            textBoxStop.Location = new Point(189, 77);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(149, 27);
            textBoxStop.TabIndex = 4;
            textBoxStop.TabStop = false;
            // 
            // textBoxStart
            // 
            textBoxStart.BorderStyle = BorderStyle.FixedSingle;
            textBoxStart.Location = new Point(6, 77);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(149, 27);
            textBoxStart.TabIndex = 3;
            textBoxStart.TabStop = false;
            // 
            // textBoxB
            // 
            textBoxB.BorderStyle = BorderStyle.FixedSingle;
            textBoxB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxB.Location = new Point(189, 26);
            textBoxB.Name = "textBoxB";
            textBoxB.ReadOnly = true;
            textBoxB.Size = new Size(149, 23);
            textBoxB.TabIndex = 2;
            textBoxB.TabStop = false;
            textBoxB.Text = "Введите конец шага:";
            // 
            // textBoxA
            // 
            textBoxA.BorderStyle = BorderStyle.FixedSingle;
            textBoxA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxA.Location = new Point(6, 30);
            textBoxA.Name = "textBoxA";
            textBoxA.ReadOnly = true;
            textBoxA.Size = new Size(149, 23);
            textBoxA.TabIndex = 1;
            textBoxA.TabStop = false;
            textBoxA.Text = "Введите начало шага:";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartFunction);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxResult.Location = new Point(18, 142);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(1032, 461);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод:";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(395, 26);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(551, 411);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // textBoxResult
            // 
            textBoxResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult.Location = new Point(6, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(339, 411);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 627);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxUsl);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 3 | Нестеренко. В. В.";
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl;
        private TextBox textBoxInfo;
        private GroupBox groupBoxInput;
        private Button buttonSave;
        private Button buttonInfo;
        private Button buttonDone;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
