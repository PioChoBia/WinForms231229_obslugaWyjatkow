namespace WinForms231229_obslugaWyjatkow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "c:\\users\\gab\\desktop\\a.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fileStream;
            StreamReader streamReader;
            string wyjatekPoczatek = "wyjatek:\n";
            string path = textBox1.Text;
            string zawartosc = "";
            try
            {
                //otwarcie strumienia pliku
                fileStream = new FileStream(
                    path,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.None
                    );
                //otawrcie stumienia odczytu na strumieñ pliku
                streamReader = new StreamReader(fileStream);
                //wpisanie zawartoœci pliku
                zawartosc = streamReader.ReadToEnd();
                //zamykamy strumienie
                streamReader.Close();
                fileStream.Close();
            }
            catch(FileNotFoundException ex)
            {
                labelWyjatek.Text = wyjatekPoczatek + "brak pliku";
            }
            catch(DirectoryNotFoundException ex)
            {
                labelWyjatek.Text = wyjatekPoczatek + "nie odnaleziono takiego katalogu";
            }
            finally
            {
                richTextBox1.Text = zawartosc;
                if (zawartosc != "")
                {
                    labelWyjatek.Text = "wszystko OK";
                }
                
            }


        }

        private void labelWyjatek_Click(object sender, EventArgs e)
        {

        }
    }
}