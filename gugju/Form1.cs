namespace gugju
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random rand_x = new Random();
            Random rand_y = new Random();
            Bitmap animal = Resource1.pik;
            Bitmap fead = Resource1.eda;
            for (int i = 0;i<10;i++)
            {
                int X = pictureBox1.Location.X + rand_x.Next(10, pictureBox1.Size.Width - 10);
                int Y = pictureBox1.Location.Y + rand_y.Next(10, pictureBox1.Size.Height - 10);
                //if(X<=)
                int X1 = rand_x.Next(-50, 50);
                int Y1 = rand_x.Next(-50, 50);
                e.Graphics.DrawImage(animal, new Point(X,Y));
                e.Graphics.DrawImage(fead,new Point(X+X1,Y+Y1));
            }
        }
    }
}
