using ParkCinema.Commands;
using ParkCinema.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Rectangle = System.Drawing.Rectangle;

namespace ParkCinema.ViewModels
{
    public class TicketUCViewModel : BaseViewModel
    {
        public void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // draw the background of the control onto the bitmap
                graphics.FillRectangle(new SolidBrush(Color.White), targetBounds);

                // create a rectangle that represents the area of the control to render
                Rectangle sourceBounds = new Rectangle(10,50,300,500);
                sourceBounds.Intersect(targetBounds);

                // render the control to the bitmap
                this.DrawToBitmap(bitmap, sourceBounds);

                // draw the borders of the control onto the bitmap
                graphics.DrawRectangle(new Pen(Color.Black), targetBounds);
            }
        }
        
        public List<int> SelectedRows { get; set; } = new List<int> { };
        public List<int> SelectedColumns { get; set; } = new List<int> { };
        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; OnPropertyChanged(); }
        }

        private MovieSchedule movie;

        public MovieSchedule Movie
        {
            get { return movie; }
            set { movie = value; OnPropertyChanged(); }
        }
        private int selectedRow;

        public int SelectedRow
        {
            get { return selectedRow; }
            set { selectedRow = value; OnPropertyChanged(); }
        }
        private int selectedColumn;

        public int SelectedColumn
        {
            get { return selectedColumn; }
            set { selectedColumn = value; OnPropertyChanged(); }
        }
        

        static int i = 0;
        public RelayCommand CloseCommand { get; set; }
        public TicketUCViewModel()
        {

            if (SelectedColumns.Count != 0 && SelectedRows.Count != 0)
            {
                SelectedColumn = SelectedColumns[i];
                SelectedRow = SelectedRows[i];
                i++;
            }
            CloseCommand = new RelayCommand((obj) =>
            {
                int n = 0;
                var myControl = obj as UserControl;
                foreach (var item in App.MyGrid.Children)
                {
                    if (item == myControl)
                    {
                        App.MyGrid.Children.RemoveAt(n);
                        break;
                    }
                    n++;
                }
            });
        }
    }
}
