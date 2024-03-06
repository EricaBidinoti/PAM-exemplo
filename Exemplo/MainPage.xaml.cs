namespace Exemplo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string name = " ";

        //Metodo Construtor
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
        }

        private void OnMessageClicked(object sender, EventArgs e)
        {
            name = NameEntry.Text;
            MessageLabel.Text =$"Hello, {name}!";
        }
    }

}
