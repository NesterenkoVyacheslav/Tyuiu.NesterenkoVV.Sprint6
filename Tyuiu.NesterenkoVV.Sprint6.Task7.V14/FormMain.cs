using System.Windows.Forms;
using Tyuiu.NesterenkoVV.Sprint6.Task7.V14.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();

        static int rows;
        static int columns;
        static string openFilePath;

        private int[,] LoadMatrix(string path)
        {
            string data = File.ReadAllText(path);

            string[] lines = data.Split("\n", StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(";").Length;


            int[,] inputMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");

                for (int j = 0; j < columns; j++)
                {
                    inputMatrix[i, j] = Convert.ToInt32(line[j]);
                }
            }

            return inputMatrix;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }


        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            try
            {
                int[,] matrix = LoadMatrix(openFilePath);
                dataGridViewInput.ColumnCount = columns;
                dataGridViewInput.RowCount = rows;
                dataGridViewResult.ColumnCount = columns;
                dataGridViewResult.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInput.Columns[i].Width = 35;
                    dataGridViewResult.Columns[i].Width = 35;
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInput.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }

                buttonDone.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Введены невернные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] doneMatrix = ds.GetMatrix(openFilePath);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = doneMatrix[i, j];
                }
            }

            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutDataFileTask7V22.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();

            string path = saveFileDialogTask.FileName;
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == columns - 1)
                        str += dataGridViewResult.Rows[i].Cells[j].Value;
                    else
                        str += dataGridViewResult.Rows[i].Cells[j].Value + ";";
                }
                str += "\n";
            }

        }
    }
}

