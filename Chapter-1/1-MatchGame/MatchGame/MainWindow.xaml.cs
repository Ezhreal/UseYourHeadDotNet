using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            List<string> animalsEmoji = new List<string>()
           {
               "🐶", "🐶",
               "🐱", "🐱",
               "🐭", "🐭",
               "🐹", "🐹",
               "🐰", "🐰",
               "🦊", "🦊",
               "🐻", "🐻",
               "🐼", "🐼"
           };

            Random sortAnimals = new Random();
            var textBlocks = mainGrid.Children.OfType<TextBlock>().ToList();
            Debug.WriteLine($"Número de TextBlocks: {textBlocks.Count}");
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                // Check if there are still emojis available
                if (animalsEmoji.Count == 0)
                    break;  // or regenerate the list if you need more emojis

                int index = sortAnimals.Next(animalsEmoji.Count);
                string nextEmoji = animalsEmoji[index];
                textBlock.Text = nextEmoji;
                textBlock.Tag = nextEmoji;
                animalsEmoji.RemoveAt(index);
            }
        }
    }
}