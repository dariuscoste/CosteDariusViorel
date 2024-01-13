namespace CosteDariusViorel
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
            count++;

            if (count == 1)
                CounterBtn.Text = $"You clicked one time";
            else
                CounterBtn.Text = $"You clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
