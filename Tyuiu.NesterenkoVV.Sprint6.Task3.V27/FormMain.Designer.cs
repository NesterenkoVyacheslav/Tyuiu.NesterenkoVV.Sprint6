
namespace Tyuiu.NesterenkoVV.Sprint6.Task3.V27
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
            groupBoxUsl = new GroupBox();
            textBoxInfo = new TextBox();
            dataGridViewMatrix = new DataGridView();
            groupBoxRes = new GroupBox();
            buttonDone = new Button();
            buttonInfo = new Button();
            groupBoxUsl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(textBoxInfo);
            groupBoxUsl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxUsl.Location = new Point(12, 23);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(416, 283);
            groupBoxUsl.TabIndex = 1;
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
            textBoxInfo.Text = "Дана матрица 5 на 5. Отсортировать 4 столбец по возрастанию.\r\n";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(434, 49);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(232, 257);
            dataGridViewMatrix.TabIndex = 2;
            dataGridViewMatrix.CellContentClick += dataGridViewMatrix_CellContentClick;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(buttonDone);
            groupBoxRes.Controls.Add(buttonInfo);
            groupBoxRes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxRes.Location = new Point(698, 49);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(206, 245);
            groupBoxRes.TabIndex = 3;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат:";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Transparent;
            buttonDone.FlatStyle = FlatStyle.Popup;
            buttonDone.Location = new Point(92, 160);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 79);
            buttonDone.TabIndex = 8;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Transparent;
            buttonInfo.FlatStyle = FlatStyle.Popup;
            buttonInfo.Location = new Point(6, 160);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(64, 79);
            buttonInfo.TabIndex = 7;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 317);
            Controls.Add(groupBoxRes);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(groupBoxUsl);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 27 | Нестеренко. В. В.";
            Load += Form1_Load;
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxRes.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void dataGridViewMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBoxUsl;
        private TextBox textBoxInfo;
        private DataGridView dataGridViewMatrix;
        private GroupBox groupBoxRes;
        private Button buttonInfo;
        private Button buttonDone;
    }
}
