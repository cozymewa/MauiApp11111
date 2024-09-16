namespace MauiApp11111
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //wygenerowanie liczby losowej
            Random r = new Random();
            //genrujemy rzut kostką K6 - <1;6>
            int diceRoll = r.Next(1, 7);
            //wyświetlenie wyniku
            RollValueLabel.Text = "Wysolowany rzut: " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
