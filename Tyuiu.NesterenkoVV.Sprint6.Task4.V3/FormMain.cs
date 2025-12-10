using Tyuiu.NesterenkoVV.Sprint6.Task4.V3.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task4.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-25-1 Нестеренко Вячеслав Владимирович", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);
                var valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult.Text = "";

                chartFunction.Series[0].Points.Clear();

                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string temppath = Path.GetTempPath();
                string newpath = Path.Combine(temppath, "OutPutFileTask4V3.txt");
                FileInfo fileinfo = new FileInfo(newpath);
                if (fileinfo.Exists)
                {
                    File.Delete(newpath);
                }
                File.WriteAllText(newpath, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + newpath + "сохранён успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = newpath;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
