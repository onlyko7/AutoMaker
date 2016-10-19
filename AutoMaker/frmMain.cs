using CommonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMaker
{
    public partial class frmMain : Form
    {
        private Pen pen;
        private Graphics gPen;        
        private bool bLeftButtonDown; // 왼쪽마우스 눌러진 상태
        private Point pSelectedTopLeft;
        private Point pSelectedBottomRight;
        private Point penClickPoint;

        public frmMain()
        {
            InitializeComponent();

            // pen 초기화
            pen = new Pen(Color.Red, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            pSelectedTopLeft = new Point();
            pSelectedBottomRight = new Point();            
        }

        private void btCapture_Click(object sender, EventArgs e)
        {
            BlueStacks bs = new BlueStacks();

            capture(bs);
        }

        /**
         * Blue Stack 화면 캡쳐
         */
        public void capture(BlueStacks bs)
        {
            /* 윈도우 현재 위치 가져오기 */
            if (bs.find(bs.HWnd) == false)
            {
                // MessageBox.Show("Start 버튼 클릭 후 캡쳐해 주세요.");
                return;
            }

            /* 현재 화면 캡쳐 */
            Bitmap bmp = new Bitmap(bs.Width, bs.Height);
            //bmp = Window((IntPtr)blueStack.HWnd, blueStack.Left, blueStack.Top, blueStack.Width, blueStack.Height);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.CopyFromScreen(bs.Left, bs.Top, 0, 0, bmp.Size);
                //bool b = PrintWindow((IntPtr)blueStack.HWnd, gr.GetHdc(), 0);
                //SendMessage((IntPtr)blueStack.HWnd, WM_PRINTCLIENT, gr.GetHdc(), (IntPtr)COMBINED_PRINTFLAGS);
            }            

            /* 캡쳐화면 모니터링 */
#if DEBUG
            picMonitor.Image = bmp;
#endif       
            // 선택영역 사각형용 그래픽스 객체 생성            
            gPen = picMonitor.CreateGraphics();
        }

        private void picMonitor_MouseDown(object sender, MouseEventArgs e)
        {

            bLeftButtonDown = true;

            // 마우스 커서모양변경
            this.Cursor = Cursors.Cross;

            // 현재 클릭 위치 저장
            penClickPoint = new Point(e.X, e.Y);

            //화면초기화
            picMonitor.Refresh();
        }

        private void picMonitor_MouseMove(object sender, MouseEventArgs e)
        {
            //마우스 X,Y 좌표에따라 사각형을 생성하고 전에 사각형은 삭제           

            if (!bLeftButtonDown) return;

            //X좌표 계산
            if (e.X < penClickPoint.X)
            {
                pSelectedTopLeft.X = e.X + pnlMonitor.HorizontalScroll.Value;
                pSelectedBottomRight.X = penClickPoint.X + pnlMonitor.HorizontalScroll.Value;
            }
            else
            {
                pSelectedTopLeft.X = penClickPoint.X + pnlMonitor.HorizontalScroll.Value;
                pSelectedBottomRight.X = e.X + pnlMonitor.HorizontalScroll.Value;
            }

            //Y좌표계산
            if (e.Y < penClickPoint.Y)
            {
                pSelectedTopLeft.Y = e.Y + pnlMonitor.VerticalScroll.Value;
                pSelectedBottomRight.Y = penClickPoint.Y + pnlMonitor.VerticalScroll.Value;
            }
            else
            {
                pSelectedTopLeft.Y = penClickPoint.Y + pnlMonitor.VerticalScroll.Value;
                pSelectedBottomRight.Y = e.Y + pnlMonitor.VerticalScroll.Value;
            }

            //화면초기화
            picMonitor.Refresh();
            //사각형 그리기
            gPen.DrawRectangle(pen, pSelectedTopLeft.X - pnlMonitor.HorizontalScroll.Value, pSelectedTopLeft.Y - pnlMonitor.VerticalScroll.Value , pSelectedBottomRight.X - pSelectedTopLeft.X, pSelectedBottomRight.Y - pSelectedTopLeft.Y);

            //Console.WriteLine("그리기 {0} {1} {2} {3} ", pSelectedTopLeft.X, pSelectedTopLeft.Y, pSelectedBottomRight.X - pSelectedTopLeft.X, pSelectedBottomRight.Y - pSelectedTopLeft.Y);

        }

        private void picMonitor_MouseUp(object sender, MouseEventArgs e)
        {
            bLeftButtonDown = false;            

            // 모니터에 선택영역 표시
            // 점선의 넓이만큼 빼준다
            int w = pSelectedBottomRight.X - pSelectedTopLeft.X + 2; // 넓이
            int h = pSelectedBottomRight.Y - pSelectedTopLeft.Y + 2; // 높이

            if (w <= 0 || h <= 0) return;

            Bitmap bmp = new Bitmap(w, h);

            Graphics g = Graphics.FromImage(bmp);

            Size s = new Size(w, h);

            Control c = (Control)sender;
            Point p = c.PointToScreen(new Point(c.Left, c.Top));

            x.Text = pSelectedTopLeft.X.ToString();
            y.Text = pSelectedTopLeft.Y.ToString();

            // 사각형 지우고 캡쳐
            picMonitor.Refresh(); 

            g.CopyFromScreen(p.X + pSelectedTopLeft.X - 4, p.Y + pSelectedTopLeft.Y - 4, 0, 0, s);

            picSubMonitor.Image = bmp;
        }

        private void picMonitor_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void picMonitor_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void 작업폴더열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 작업폴더 열기
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string selected = dialog.SelectedPath;

            lblHome.Text = selected;
        }

        private void 프로젝트저장CtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로젝트 저장");
        }

        private void 프로젝트열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // AppSettings 클래스를 만들어 PropertyGrid에 표시합니다.  
            ProjectProperties projectProperties = new ProjectProperties();
            propertyGrid.SelectedObject = projectProperties;

        }
    }
}
