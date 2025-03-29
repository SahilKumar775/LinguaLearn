using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Se_iteration01
{
    public class Home
    {
        private Point mouseDown;
        private FlowLayoutPanel Parent;

        public  Home(FlowLayoutPanel panel)
        {
            Parent = panel;
            AssignEvent(panel);
        }

        private void AssignEvent(Control control)
        { control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;
            foreach(Control child  in control.Controls)
            {
                AssignEvent(child);
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.mouseDown = Cursor.Position;
        }

        private void MouseDown(object sender,MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            Point pointDiff=new Point(Cursor.Position.X+mouseDown.X,Cursor.Position.Y+mouseDown.Y);

            if ((mouseDown.X == Cursor.Position.X) && (mouseDown.Y == Cursor.Position.Y))
                return;
            Point curr = Parent.AutoScrollPosition;
            Parent.AutoScrollPosition = new Point(Math.Abs(curr.X) - pointDiff.X, Math.Abs(curr.Y) - pointDiff.Y);
            mouseDown = Cursor.Position;

        }
    }
}
