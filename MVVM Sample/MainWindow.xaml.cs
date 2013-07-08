using System;
using System.Collections.Generic;
using System.Linq;
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
using MVVM_Sample.ViewModels;

namespace MVVM_Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DragControlViewModel();
        }

        private bool isControlDragging;
        private UIElement draggingControl;

        private void DragControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isControlDragging = true;
            draggingControl = sender as UIElement;
        }

        private void DragControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isControlDragging = false;
            draggingControl = null;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isControlDragging && draggingControl != null)
            {

            }
        }
    }
}
