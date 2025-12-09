using Tyuiu.NesterenkoVV.Sprint6.Task1.V6.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task1.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxVarStart.Text);
                int stopstep = Convert.ToInt32(textBoxVarEnd.Text);
                string strLine;
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                double[] array;
                array = new double[len];
                array = ds.GetMassFunction(startstep, stopstep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X    |   f(x)  |" + Environment.NewLine);
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}    |   {1,5:f2}  | ", startstep, array[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startstep++;
                }
                textBoxResult.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-25-1 Нестеренко Вячеслав Владимирович", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonResult_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
