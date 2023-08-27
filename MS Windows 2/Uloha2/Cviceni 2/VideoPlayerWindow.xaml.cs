using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cviceni_2
{
    /// <summary>
    /// Interaction logic for VideoPlayerWindow.xaml
    /// </summary>
    public partial class VideoPlayerWindow : Window
    {

        private bool isDraggingSlider = false;

        public VideoPlayerWindow()
        {
            InitializeComponent();

            // Nastavení zdroje videa (můžete změnit na vaše video)
            mediaElement.Source = new Uri("d:/Škola/Vysoká škola Finanční a Správní/VSFS/4.Semester/MS WIndows/DU/Machři2.mp4", UriKind.RelativeOrAbsolute);
        }

            // Definice událostí pomocí klíčového slova 'event'
             public event RoutedEventHandler PlayClicked;
             public event RoutedEventHandler PauseClicked;
             

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
            PlayClicked?.Invoke(this, e); // Vyvolání události PlayClicked
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
            PauseClicked?.Invoke(this, e); // Vyvolání události PauseClicked
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!isDraggingSlider)
            {
                // Nastavení pozice videa na hodnotu posuvníku
                mediaElement.Position = TimeSpan.FromSeconds(slider.Value * mediaElement.NaturalDuration.TimeSpan.TotalSeconds);
            }
        }
        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            // Nastavení maximální hodnoty posuvníku na celkovou délku videa
            slider.Maximum = mediaElement.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void Slider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            // Začátek tažení posuvníku
            isDraggingSlider = true;
        }

        private void Slider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            // Konec tažení posuvníku
            isDraggingSlider = false;
            // Nastavení pozice videa na hodnotu posuvníku po dokončení tažení
            mediaElement.Position = TimeSpan.FromSeconds(slider.Value);
        }

    }
    }

