namespace Tyuiu.NesterenkoVV.Sprint6.Task2.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxUsl = new GroupBox();
            textBoxInfo = new TextBox();
            groupBoxInput = new GroupBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            groupBoxRes = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            groupBoxUsl.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(textBoxInfo);
            groupBoxUsl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxUsl.Location = new Point(31, 12);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(510, 202);
            groupBoxUsl.TabIndex = 0;
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
            textBoxInfo.Text = "Протабулировать функцию на заданном диапазоне .\r\nРезультат вывести в виде таблицы и функции\r\n\r\n";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(buttonInfo);
            groupBoxInput.Controls.Add(buttonDone);
            groupBoxInput.Controls.Add(textBoxStop);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Controls.Add(textBoxB);
            groupBoxInput.Controls.Add(textBoxA);
            groupBoxInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxInput.Location = new Point(45, 256);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(531, 156);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных:";
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.ActiveCaption;
            buttonInfo.FlatStyle = FlatStyle.Popup;
            buttonInfo.Location = new Point(347, 30);
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
            buttonDone.Location = new Point(417, 30);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 79);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
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
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(chartFunction);
            groupBoxRes.Controls.Add(dataGridViewFunction);
            groupBoxRes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxRes.Location = new Point(598, 20);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(473, 392);
            groupBoxRes.TabIndex = 1;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат:";
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(167, 39);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(306, 306);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { x, FX });
            dataGridViewFunction.Location = new Point(37, 37);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.Size = new Size(105, 302);
            dataGridViewFunction.TabIndex = 0;
            // 
            // x
            // 
            x.HeaderText = "X";
            x.Name = "x";
            x.Width = 50;
            // 
            // FX
            // 
            FX.HeaderText = "F(X)";
            FX.Name = "FX";
            FX.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 450);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxUsl);
            Name = "FormMain";
            Text = "Form1";
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl;
        private TextBox textBoxInfo;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxRes;
        private TextBox textBoxA;
        private Button buttonInfo;
        private Button buttonDone;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private TextBox textBoxB;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn FX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
