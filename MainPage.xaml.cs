namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {
        public string Firstname { get; set; }
        public Color ColorRed { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Firstname = "Hello, MAUI";
            ColorRed = Colors.Red;

            this.BindingContext = this;
        }

        private void OnChangedLabelName(object sender, EventArgs e)
        {
            this.Resources["StaticUsername"] = "Peter Butter";
        }

        private void OnChangedLabelNameDynamic(object sender, EventArgs e)
        {
            this.Resources["DynamicUsername"] = "Mr. John Doe";
        }

        private void OnChangedBackgroundColorGray(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightGray;
        }

        private void OnChangedBackgroundColorGreen(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Green;
        }

        private void OnChangedBackgroundColorLightBlue(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightBlue;
        }

        private void OnChangedBoxViewColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.Red;
        }
    }

}
