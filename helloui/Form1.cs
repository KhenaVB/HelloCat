namespace helloui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moesiz_Button_Click(object sender, EventArgs e)
        {
            kekw.Visible = !kekw.Visible;
        }

        private void veel_gram_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbutton_Click(object sender, EventArgs e)
        {
            int gram = Int32.Parse(veel_gram_textbox.Text);
            int euro = gram * 75;

            resultaatgram_label.Text = String.Format("het kost €{0}", euro);
            resultaatgram_label.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}