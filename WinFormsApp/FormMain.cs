using Library5;
namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        Random rnd = new Random();
        static int M;
        static int N;

        public static int[,] InputArray(int M, int N, int n1, int n2)
        {
            Random rnd = new Random();

            int[,] array = new int[M, N];

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j > 0)
                    {
                        if (array[i, j - 1] % 2 == 0)
                        {
                            array[i, j] = rnd.Next(n1, n2);
                            if (array[i, j] % 2 == 0)
                            {
                                array[i, j]++;
                            }
                        }
                        if (array[i, j - 1] % 2 != 0)
                        {
                            array[i, j] = rnd.Next(n1, n2);
                            if (array[i, j] % 2 != 0)
                            {
                                array[i, j]++;
                            }
                        }

                    }
                    else
                    {
                        array[i, j] = rnd.Next(n1, n2);
                    }

                }

            }
            return array;




        }
        private void buttonResult_DAA_Click(object seder, EventArgs e)
        {
            M = Convert.ToInt32(textBoxInput_M_DAA.Text);
            N = Convert.ToInt32(textBoxInput_N_DAA.Text);
            try
            {

                int n1 = Convert.ToInt32(textBoxInput_n1_DAA.Text);
                int n2 = Convert.ToInt32(textBoxInput_n2_DAA.Text);
                int c = Convert.ToInt32(textBoxInput_c_DAA.Text);
                int k = Convert.ToInt32(textBoxInput_k_DAA.Text);
                int l = Convert.ToInt32(textBoxInput_L_DAA.Text);
                int[,] arrayN = InputArray(M, N, n1, n2);
                int rows = arrayN.GetUpperBound(0) + 1;
                int columns = arrayN.Length / rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewArray_DAA.Rows[i].Cells[j].Value = arrayN[i, j];
                    }

                }

                textBoxOutput_DAA.Text = Convert.ToString(ds.GetMatrix(arrayN, n1, n2, c, k, l));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxInput_n1_DAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (Convert.ToInt32(textBoxInput_n1_DAA.Text) < Convert.ToInt32(textBoxInput_n2_DAA.Text)) && (Convert.ToInt32(textBoxInput_k_DAA.Text) < Convert.ToInt32(textBoxInput_L_DAA.Text)) && (Convert.ToInt32(textBoxInput_c_DAA.Text) < Convert.ToInt32(textBoxInput_N_DAA.Text)))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт - ревью выполнил студент группы РППб-24-1 Диканов Артём Алексеевич", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            dataGridViewArray_DAA.ColumnCount = 50;
            dataGridViewArray_DAA.RowCount = 50;
            for (int p = 0; p < 50; p++)
            {
                dataGridViewArray_DAA.Columns[p].Width = 15;
            }

        }


    }
}
