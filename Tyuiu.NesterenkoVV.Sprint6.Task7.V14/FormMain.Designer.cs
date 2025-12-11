namespace Tyuiu.NesterenkoVV.Sprint6.Task7.V14
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxOutPutData = new GroupBox();
            buttonSaveFile = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxCondition = new GroupBox();
            textBoxInfo = new TextBox();
            groupBoxInput = new GroupBox();
            dataGridViewInput = new DataGridView();
            groupBoxResult = new GroupBox();
            dataGridViewResult = new DataGridView();
            toolTipButton = new ToolTip(components);
            saveFileDialogTask = new SaveFileDialog();
            openFileDialogTask = new OpenFileDialog();
            groupBoxOutPutData.SuspendLayout();
            groupBoxCondition.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(buttonSaveFile);
            groupBoxOutPutData.Controls.Add(buttonOpenFile);
            groupBoxOutPutData.Controls.Add(buttonHelp);
            groupBoxOutPutData.Controls.Add(buttonDone);
            groupBoxOutPutData.Location = new Point(12, 12);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(1068, 86);
            groupBoxOutPutData.TabIndex = 10;
            groupBoxOutPutData.TabStop = false;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Enabled = false;
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(256, 16);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(111, 60);
            buttonSaveFile.TabIndex = 9;
            toolTipButton.SetToolTip(buttonSaveFile, "Сохрнить файл");
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(22, 16);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(111, 60);
            buttonOpenFile.TabIndex = 6;
            toolTipButton.SetToolTip(buttonOpenFile, "Загрузить файл");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(951, 15);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(111, 71);
            buttonHelp.TabIndex = 8;
            toolTipButton.SetToolTip(buttonHelp, "Информация о разработчике");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(139, 16);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(111, 60);
            buttonDone.TabIndex = 7;
            toolTipButton.SetToolTip(buttonDone, "Заменяет во 2 строке все чётные числа на 44");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(textBoxInfo);
            groupBoxCondition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxCondition.Location = new Point(12, 104);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(1074, 133);
            groupBoxCondition.TabIndex = 11;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие:";
            // 
            // textBoxInfo
            // 
            textBoxInfo.BorderStyle = BorderStyle.None;
            textBoxInfo.Location = new Point(6, 16);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(1062, 97);
            textBoxInfo.TabIndex = 12;
            textBoxInfo.TabStop = false;
            textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewInput);
            groupBoxInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxInput.Location = new Point(12, 243);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(526, 289);
            groupBoxInput.TabIndex = 12;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.ColumnHeadersVisible = false;
            dataGridViewInput.Location = new Point(10, 26);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.ReadOnly = true;
            dataGridViewInput.RowHeadersVisible = false;
            dataGridViewInput.Size = new Size(510, 257);
            dataGridViewInput.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxResult.Location = new Point(558, 243);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(528, 298);
            groupBoxResult.TabIndex = 13;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Ввод";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Enabled = false;
            dataGridViewResult.Location = new Point(12, 26);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(510, 257);
            dataGridViewResult.TabIndex = 1;
            // 
            // toolTipButton
            // 
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 544);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxCondition);
            Controls.Add(groupBoxOutPutData);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 14 | Нестеренко. В. В.";
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOutPutData;
        private Button buttonOpenFile;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxCondition;
        private TextBox textBoxInfo;
        private GroupBox groupBoxInput;
        private DataGridView dataGridViewResult;
        private DataGridView dataGridViewInput;
        private GroupBox groupBoxResult;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogTask;
        private Button buttonSaveFile;
        private OpenFileDialog openFileDialogTask;
    }
}
