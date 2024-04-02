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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace PR2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {


        public Window2()
        {
            InitializeComponent();
            StartShipAnimation();
        }

        private void StartShipAnimation()
        {
            // Вертикальная анимация (покачивание вверх-вниз)
            DoubleAnimation verticalAnimation = new DoubleAnimation();
            verticalAnimation.From = 0;
            verticalAnimation.To = 15;
            verticalAnimation.Duration = new Duration(TimeSpan.FromSeconds(1.5));
            verticalAnimation.AutoReverse = true;
            verticalAnimation.RepeatBehavior = RepeatBehavior.Forever;

            // Горизонтальная анимация (покачивание влево-вправо)
            DoubleAnimation horizontalAnimation = new DoubleAnimation();
            horizontalAnimation.From = 0;
            horizontalAnimation.To = 30;
            horizontalAnimation.Duration = new Duration(TimeSpan.FromSeconds(3));
            horizontalAnimation.AutoReverse = true;
            horizontalAnimation.RepeatBehavior = RepeatBehavior.Forever;

            TranslateTransform translateTransform = new TranslateTransform();
            canvas.RenderTransform = translateTransform;

            // Создаем и применяем анимации
            translateTransform.BeginAnimation(TranslateTransform.YProperty, verticalAnimation);
            translateTransform.BeginAnimation(TranslateTransform.XProperty, horizontalAnimation);
        }

    }
}