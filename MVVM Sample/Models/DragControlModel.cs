using System.Windows;

namespace MVVM_Sample.Models
{
    public class DragControlModel
    {
        public DragControlModel()
        {
            Position = new Point(10, 10);
            Content = "Input text here.";
        }

        public Point Position { get; set; }
        public string Content { get; set; }
    }
}
