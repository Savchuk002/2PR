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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PR2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public RotateTransform3D myYRotate, myXRotate, myZRotate, myZRotate2, myYRotate2;
        public AxisAngleRotation3D myYAxis, myXAxis, myZAxis2, myZAxis, myYAxis2;
        public Transform3DGroup myTransform1, myTransform2;
        public DispatcherTimer MyTimer;
        public Window1()
        {
            InitializeComponent();
            MyTimer = new DispatcherTimer();
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Interval = new TimeSpan(100);
            myYAxis = new AxisAngleRotation3D();
            myYAxis.Axis = new Vector3D(0, 1, 0);
            myYAxis.Angle = 0;
            myYRotate = new RotateTransform3D();
            myYRotate.Rotation = myYAxis;

            myZAxis = new AxisAngleRotation3D();
            myZAxis.Axis = new Vector3D(0, 0, 1);
            myZAxis.Angle = 0;
            myZRotate = new RotateTransform3D();
            myZRotate.Rotation = myZAxis;

            myTransform1 = new Transform3DGroup();
            MyModel.Transform = myTransform1;
            myTransform1.Children.Add(myYRotate);
            myTransform1.Children.Add(myZRotate);
            //Створюємо перетворення для 2 об'єктів
            myYRotate2 = new RotateTransform3D();
            myYAxis2 = new AxisAngleRotation3D();
            myYAxis2.Axis = new Vector3D(0, 1, 0);
            myYAxis2.Angle = 0;
            myYRotate2.Rotation = myYAxis2;
            myZRotate2 = new RotateTransform3D();
            myZAxis2 = new AxisAngleRotation3D();
            myZAxis2.Axis = new Vector3D(0, 0, 1);
            myZAxis2.Angle = 0;
            myZRotate2.Rotation = myZAxis2;
            myTransform2 = new Transform3DGroup();
            MyModel2.Transform = myTransform2;
            myTransform2.Children.Add(myYRotate2);
            myTransform2.Children.Add(myZRotate2);
        }
    
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {




        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            myYAxis.Angle += 1;
            myZAxis.Angle += 1;
            myYAxis2.Angle -= 1;
            myZAxis2.Angle -= 1;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MyTimer.Start();

        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MyTimer.Stop();

        }
    }
}
