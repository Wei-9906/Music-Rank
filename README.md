# Music-Rank


![image](https://github.com/user-attachments/assets/64d86649-f044-468f-995e-f867ddbe958b)
![image](https://github.com/user-attachments/assets/1f5bbbef-15c0-4fb1-986c-6fb0050b2f90)
![image](https://github.com/user-attachments/assets/60355a73-80d7-4347-bff1-eb8e79b980a2)



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


        string[] song = new string[] { "稻香", "屋梅子醬", "在樹上唱歌", "溫柔", "好不容易" };
        string[] singer = new string[] { "周杰倫", "李榮浩", "郭靜", "五月天", "告五人" };
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
            string msg = $"找不到{search}";
            int index = Array.IndexOf(singer, search);
            //當index找不到時 為-1
            if (index >= 0)
            {
                msg = "排名\t歌手\t歌曲" + Environment.NewLine;
                while (index >= 0) //只要index>=0就一直執行此迴圈
                {
                    msg += $"{no[index]}\t{singer[index]}\t{song[index]}" + Environment.NewLine;
                    index = Array.IndexOf(singer, search, index + 1);
                }
            }
            MessageBox.Show(msg, "查詢結果"); //查詢結果為msgbox的title
        }
    }
}

