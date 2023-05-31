using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Verdandi.Windows.TaskEditWindow
{
    /// <summary>
    /// Interaction logic for TaskEditWindow.xaml
    /// </summary>
    public partial class TaskEditWindow : Window
    {
        public TaskEditWindow()
        {
            InitializeComponent();
        }

        private static ResourceManager resourceMan;
        public static ResourceManager ResourceManager => resourceMan ??= new ResourceManager("Verdandi.Properties.Resources", typeof(TaskEditWindow).Assembly);
    }
}
