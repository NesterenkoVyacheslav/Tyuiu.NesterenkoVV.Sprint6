namespace Tyuiu.NesterenkoVV.Sprint6.Task6.V16
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
            groupBoxUsl = new GroupBox();
            textBoxInfo = new TextBox();
            textBoxLoadFromFile = new TextBox();
            textBoxResult = new TextBox();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            buttonHelp = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            groupBoxOutPutData = new GroupBox();
            groupBoxUsl.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(textBoxInfo);
            groupBoxUsl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxUsl.Location = new Point(12, 78);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(1154, 186);
            groupBoxUsl.TabIndex = 3;
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
            textBoxInfo.Size = new Size(1135, 144);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.TabStop = false;
            textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoadFromFile.Location = new Point(18, 270);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ReadOnly = true;
            textBoxLoadFromFile.Size = new Size(567, 370);
            textBoxLoadFromFile.TabIndex = 4;
            // 
            // textBoxResult
            // 
            textBoxResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult.Location = new Point(599, 270);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(554, 370);
            textBoxResult.TabIndex = 5;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(22, 16);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(111, 60);
            buttonOpenFile.TabIndex = 6;
            toolTip.SetToolTip(buttonOpenFile, "Выберите файл");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(139, 16);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(111, 60);
            buttonDone.TabIndex = 7;
            toolTip.SetToolTip(buttonDone, "Производит поиск вхожденний слов с буквой b");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(1024, 11);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(111, 71);
            buttonHelp.TabIndex = 8;
            toolTip.SetToolTip(buttonHelp, "О программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(buttonOpenFile);
            groupBoxOutPutData.Controls.Add(buttonHelp);
            groupBoxOutPutData.Controls.Add(buttonDone);
            groupBoxOutPutData.Location = new Point(12, 12);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(1141, 86);
            groupBoxOutPutData.TabIndex = 9;
            groupBoxOutPutData.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 670);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxLoadFromFile);
            Controls.Add(groupBoxUsl);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 16 | Нестеренко. В. В.";
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            groupBoxOutPutData.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxUsl;
        private TextBox textBoxInfo;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxResult;
        private Button buttonOpenFile;
        private Button buttonDone;
        private Button buttonHelp;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogTask;
        private GroupBox groupBoxOutPutData;
    }
}
