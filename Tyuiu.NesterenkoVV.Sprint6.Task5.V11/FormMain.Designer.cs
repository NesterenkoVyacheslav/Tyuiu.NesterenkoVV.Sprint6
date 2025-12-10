namespace Tyuiu.NesterenkoVV.Sprint6.Task5.V11
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
            buttonDone = new Button();
            buttonOpenFile = new Button();
            buttonInfo = new Button();
            groupBoxResult = new GroupBox();
            dataGridViewResult = new DataGridView();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxUsl.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(textBoxInfo);
            groupBoxUsl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxUsl.Location = new Point(12, 12);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(404, 124);
            groupBoxUsl.TabIndex = 3;
            groupBoxUsl.TabStop = false;
            groupBoxUsl.Text = "Условие";
            // 
            // textBoxInfo
            // 
            textBoxInfo.BorderStyle = BorderStyle.FixedSingle;
            textBoxInfo.Location = new Point(0, 20);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(385, 85);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.TabStop = false;
            textBoxInfo.Text = "Прочитать данные из факла и вывести их";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.FlatStyle = FlatStyle.Popup;
            buttonDone.Location = new Point(680, 38);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 79);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.Aqua;
            buttonOpenFile.FlatStyle = FlatStyle.Popup;
            buttonOpenFile.Location = new Point(548, 38);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(108, 79);
            buttonOpenFile.TabIndex = 8;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.ActiveCaption;
            buttonInfo.FlatStyle = FlatStyle.Popup;
            buttonInfo.Location = new Point(460, 38);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(64, 79);
            buttonInfo.TabIndex = 9;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Controls.Add(chartDiag);
            groupBoxResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxResult.Location = new Point(12, 142);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(776, 296);
            groupBoxResult.TabIndex = 10;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод:";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(6, 26);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.Size = new Size(240, 270);
            dataGridViewResult.TabIndex = 2;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(365, 0);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(451, 300);
            chartDiag.TabIndex = 1;
            chartDiag.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonInfo);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxUsl);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 11 | Нестеренко. В. В.";
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl;
        private TextBox textBoxInfo;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonInfo;
        private GroupBox groupBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private DataGridView dataGridViewResult;
    }
}
