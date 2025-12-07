namespace Tyuiu.NesterenkoVV.Sprint6.Task0.V19
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBoxFormula = new PictureBox();
            groupBoxData = new GroupBox();
            textBoxInfo = new TextBox();
            groupBox = new GroupBox();
            textBoxVarA = new TextBox();
            textBoxData = new TextBox();
            groupBoxResult = new GroupBox();
            buttonDone = new Button();
            textBoxResult = new TextBox();
            textBoxTextResult = new TextBox();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxData.SuspendLayout();
            groupBox.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(325, 59);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(310, 82);
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;
            pictureBoxFormula.Click += pictureBoxForm_Click;
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(textBoxInfo);
            groupBoxData.Controls.Add(pictureBoxFormula);
            groupBoxData.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxData.ImeMode = ImeMode.Alpha;
            groupBoxData.Location = new Point(6, 12);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(653, 189);
            groupBoxData.TabIndex = 0;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Условие :";
            // 
            // textBoxInfo
            // 
            textBoxInfo.HideSelection = false;
            textBoxInfo.ImeMode = ImeMode.Off;
            textBoxInfo.Location = new Point(15, 46);
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(196, 47);
            textBoxInfo.TabIndex = 3;
            textBoxInfo.Text = "Подсчитать выражение";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBoxVarA);
            groupBox.Controls.Add(textBoxData);
            groupBox.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox.ImeMode = ImeMode.Alpha;
            groupBox.Location = new Point(6, 207);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(315, 188);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Ввод данных";
            // 
            // textBoxVarA
            // 
            textBoxVarA.HideSelection = false;
            textBoxVarA.ImeMode = ImeMode.Off;
            textBoxVarA.Location = new Point(135, 46);
            textBoxVarA.Name = "textBoxVarA";
            textBoxVarA.Size = new Size(114, 47);
            textBoxVarA.TabIndex = 3;
            textBoxVarA.KeyPress += textBoxVarA_KeyPress;
            // 
            // textBoxData
            // 
            textBoxData.HideSelection = false;
            textBoxData.ImeMode = ImeMode.Off;
            textBoxData.Location = new Point(15, 46);
            textBoxData.Name = "textBoxData";
            textBoxData.ReadOnly = true;
            textBoxData.Size = new Size(114, 47);
            textBoxData.TabIndex = 2;
            textBoxData.Text = "Введите A:\r\n";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(buttonInfo);
            groupBoxResult.Controls.Add(buttonDone);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Controls.Add(textBoxTextResult);
            groupBoxResult.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxResult.ImeMode = ImeMode.Alpha;
            groupBoxResult.Location = new Point(332, 207);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(315, 188);
            groupBoxResult.TabIndex = 3;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // buttonDone
            // 
            buttonDone.FlatStyle = FlatStyle.Popup;
            buttonDone.Location = new Point(123, 128);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(138, 47);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.HideSelection = false;
            textBoxResult.ImeMode = ImeMode.Off;
            textBoxResult.Location = new Point(132, 46);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(114, 47);
            textBoxResult.TabIndex = 4;
            // 
            // textBoxTextResult
            // 
            textBoxTextResult.HideSelection = false;
            textBoxTextResult.ImeMode = ImeMode.Off;
            textBoxTextResult.Location = new Point(12, 46);
            textBoxTextResult.Name = "textBoxTextResult";
            textBoxTextResult.ReadOnly = true;
            textBoxTextResult.Size = new Size(114, 47);
            textBoxTextResult.TabIndex = 2;
            textBoxTextResult.Text = "Результат:\r\n";
            // 
            // buttonInfo
            // 
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Location = new Point(43, 132);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(44, 39);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "?";
            buttonInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonInfo.UseCompatibleTextRendering = true;
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 407);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBox);
            Controls.Add(groupBoxData);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 19 | Нестеренко. В. В.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxData.ResumeLayout(false);
            groupBoxData.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxData;
        private GroupBox groupBox;
        private TextBox textBoxData;
        private GroupBox groupBoxResult;
        private TextBox textBoxTextResult;
        private TextBox textBoxVarA;
        private Button buttonDone;
        private TextBox textBoxResult;
        private TextBox textBoxInfo;
        private Button buttonInfo;
    }
}
