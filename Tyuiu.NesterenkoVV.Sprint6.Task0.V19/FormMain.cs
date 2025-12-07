using Tyuiu.NesterenkoVV.Sprint6.Task0.V19.Lib;

namespace Tyuiu.NesterenkoVV.Sprint6.Task0.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try

            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxForm_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar <= 47) || (e.KeyChar >= 58)) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-25-1 Нестеренко Вячеслав Владимирович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
