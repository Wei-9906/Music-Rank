namespace array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        string[] song = new string[] { "�_��", "�α��l��", "�b��W�ۺq", "�ŬX", "�n���e��" };
        string[] singer = new string[] { "�P�N��", "���a�E", "���R", "�����", "�i���H" };
        int[] no = new int[] { 1, 2, 3, 4, 5 };


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            int[] no2 = new int[no.Length];
            no.CopyTo(no2, 0);
            Array.Sort(no, song);
            Array.Sort(no2, singer);


            for (int i = 0; i < no.Length; i++)
            {
                textBox1.Text +=$"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            string[] song2 = new string[song.Length];
            song.CopyTo(song2, 0);
            Array.Sort(song, no);
            Array.Sort(song2, singer);


            for (int i = 0; i < no.Length; i++)
            {
                textBox1.Text +=$"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            string[] singer2 = new string[singer.Length];
            singer.CopyTo(singer2, 0);
            Array.Sort(singer, no);
            Array.Sort(singer2, song);


            for (int i = 0; i < no.Length; i++)
            {
                textBox1.Text +=$"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string search = textBox2.Text;
            string msg = $"�䤣��{search}";
            int index = Array.IndexOf(singer, search);
            //��index�䤣��� ��-1
            if (index >= 0)
            {
                msg = "�ƦW\t�q��\t�q��" + Environment.NewLine;
                while (index >= 0) //�u�nindex>=0�N�@�����榹�j��
                {
                    msg += $"{no[index]}\t{singer[index]}\t{song[index]}" + Environment.NewLine;
                    index = Array.IndexOf(singer, search, index + 1);
                }
            }
            MessageBox.Show(msg, "�d�ߵ��G"); //�d�ߵ��G��msgbox��title
        }
    }
}