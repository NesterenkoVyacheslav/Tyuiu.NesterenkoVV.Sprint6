using Tyuiu.NesterenkoVV.Sprint6.Task3.V27.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mat = new int[5, 5] { { 9, 13, -14, 23, 1 }, { 15, -17, 21, 25, 23 }, { -4, 29, -20, -10, 14 }, { 27, 33, 12, 33, -12 }, { 18, 9, 5, 6, 3 } };

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var matrix = ds.Calculate(mat);
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dataGridViewMatrix.ColumnCount = cols;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToInt32(matrix[i, j]);
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-25-1 Нестеренко Вячеслав Владимирович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
