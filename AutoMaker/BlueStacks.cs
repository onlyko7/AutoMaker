using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLib
{
    public class BlueStacks
    {        
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int FindWindowEx(int hWnd1, int hWnd2, string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int GetWindowRect(int hwnd, ref RECT lpRect);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(int hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(int hWnd, int nCmdShow);
        [DllImport("user32")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);


        private const string pgmPath = "C:/ProgramData/BlueStacksGameManager/BlueStacks.exe";
        private const int SW_SHOWNORMAL = 1;
        public const int baseWidth = 1283; // 캡쳐기준 블루스택 화면 크기
        public const int baseHeight = 726; // 상단바 포함 760


        //윈도우 좌표 및 크기
        private int top = 0;
        private int left = 0;
        private int right = 0;
        private int bottom = 0;
        private int width = 0;
        private int height = 0;
        private double scale = 1.0;
        private int hWnd;

        public int Top
        {
            get
            {
                return top;
            }

            set
            {
                top = value;
            }
        }

        public int Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        public int Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

        public int Bottom
        {
            get
            {
                return bottom;
            }

            set
            {
                bottom = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public double Scale
        {
            get
            {
                return scale;
            }

            set
            {
                scale = value;
            }
        }

        public int HWnd
        {
            get
            {
                return hWnd;
            }

            set
            {
                hWnd = value;
            }
        }

        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

       
        public BlueStacks()
        {
            //변수 선언 및 초기화
            HWnd = 0; //윈도우 핸들러
            RECT stRect = default(RECT); //윈도우 크기정보

            //Blue Stack 창이 떠있는지 확인
            HWnd = FindWindow(null, "Bluestacks App Player");
            if (HWnd == 0)
            {
                //Blue Stack이 떠 있지 않으면 실행시킨다.                
                /*
                try
                {
                    Process.Start(pgmPath);
                }catch(Exception e)
                {
                    return;
                }
                
                Thread.Sleep(3000);

                //실행 확인
                HWnd = FindWindow(null, "BlueStacks App Player");
                if (HWnd == 0) return;   
                */
                MessageBox.Show("BlueStacks Not Found");
                return;
            }
            
            //윈도우 위치 및 크기정보 가져오기            
            GetWindowRect(HWnd, ref stRect);

            Top = stRect.top;
            Left = stRect.left;
            Right = stRect.right;
            Bottom = stRect.bottom;
            Height = Bottom - Top;
            Width = Right - Left;
            Scale = (double)Width / (double)baseWidth;
        }

        // parentHwnd :부모창 윈도우핸들
        // name : 찾을 창이름
        public int findWindow(int parentHWnd, string name)
        {
            return 0;
        }


        public int findSevenKnights()
        {
            StringBuilder sb = new StringBuilder(260);

            int lHWnd = FindWindow(null, "Bluestacks App Player");
            //int lHWnd = FindWindow(null, "다운로드");

            // 현재 창 이름 출력
            //GetWindowText((IntPtr)lHWnd, sb, 260);
            //MessageBox.Show(HWnd + "|" + sb.ToString());

            // 블루스택의 첫번째 자식창을 찾아서 탐색 시작
            int childNode = FindWindowEx(lHWnd, 0, null, null);
            if (childNode != 0)
            {
                //세븐나이츠 안드로이드 플러그인 핸들을 찾아서 리턴함
                return findChildWindow(lHWnd, childNode, 0);
            }

            return 0;
        }

        public int findChildWindow(int parent, int currNode, int level)
        {
            StringBuilder sb = new StringBuilder(260);

            int childNode = 0;
            int sevenKnights = 0;

            int i = 0;
            while (currNode != 0)
            {
                // 현재 창 이름 출력
                if (currNode != 0)
                {
                    GetWindowText((IntPtr)currNode, sb, 260);
                    //MessageBox.Show(level + "|" + i + "|" + currNode + "|" + sb.ToString());
                    if ("세븐나이츠".Equals(sb.ToString().Trim()))
                    {
                        return FindWindowEx(currNode, 0, null, "BlueStacks Android Plugin");
                    }
                }

                // 자식창이 있으면 탐색
                childNode = FindWindowEx(currNode, 0, null, null);
                if (childNode != 0)
                {

                    sevenKnights = findChildWindow(currNode, childNode, level + 1);
                    if (sevenKnights != 0)
                    {
                        //세븐나이츠의 안드로이그 플러그인 리턴
                        return sevenKnights;
                    }
                }

                // 다음창 검색 없으면 끝낸다
                currNode = FindWindowEx(parent, currNode, null, null);

                i++;
            }
            return 0;
        }

        public static int findSevenKnights2()
        {
            StringBuilder sb = new StringBuilder(260);

            int HWnd = FindWindow(null, "Bluestacks App Player");
            int currChild = 0;
            int prevChild = 0;

            for (int i = 0; i < 10; i++)
            {
                currChild = FindWindowEx(HWnd, prevChild, null, null);
                if (currChild == 0) break;

                int lcurrChild = 0;
                int lprevChild = 0;
                for (int j = 0; j < 10; j++)
                {
                    lcurrChild = FindWindowEx(currChild, lprevChild, null, null);
                    if (lcurrChild == 0) break;

                    GetWindowText((IntPtr)lcurrChild, sb, 260);
                    if ("세븐나이츠".Equals(sb.ToString().Trim()))
                    {
                        return FindWindowEx(lcurrChild, 0, null, "BlueStacks Android Plugin");
                    }
                    lprevChild = lcurrChild;
                }
                GetWindowText((IntPtr)currChild, sb, 260);
                prevChild = currChild;
            }

            return 0;
        }

        public bool isActive()
        {
            //Blue Stack 창이 떠있는지 확인            
            if (FindWindow(null, "BlueStacks App Player") == 0)
                return false;
            else
                return true;
        }

        public static BlueStacks getBlueStack()
        {
            BlueStacks bs = new BlueStacks();

            if (bs.isActive())
                return bs;
            else
                return null;
        }
        public bool find(int pHWnd)
        {            
            RECT stRect = default(RECT); //윈도우 크기정보

            /* Blue Stack 창 찾기 */
            if (pHWnd == 0)
            {
                return false;                
            }

            /* 윈도우 위치 및 크기정보 가져오기 */
            GetWindowRect(pHWnd, ref stRect);

            if (stRect.top < 0)
            {
                // 윈도우가 최소화 되어있다면 활성화 시킨다
                //ShowWindowAsync(HWnd, SW_SHOWNORMAL);

                //Thread.Sleep(3000);

                /* 윈도우 위치 및 크기정보 가져오기 */
                //GetWindowRect(HWnd, ref stRect);
            }

            // 윈도우에 포커스를 줘서 최상위로 만든다
            // SetForegroundWindow(HWnd);


            Top = stRect.top;
            Left = stRect.left;
            Right = stRect.right;
            Bottom = stRect.bottom;
            Height = Bottom - Top;
            Width = Right - Left;
            Scale = (double)Width / (double)baseWidth;

            return true;
        }
        public bool find()
        {
            /* 변수선언 및 초기화 */
            HWnd = 0; //윈도우 핸들러

            RECT stRect = default(RECT); //윈도우 크기정보

            /* Blue Stack 창 찾기 */
            if (HWnd == 0)
            {
                HWnd = findSevenKnights();

                if (HWnd == 0)
                {
                    return false;
                }
            }

            /* 윈도우 위치 및 크기정보 가져오기 */
            GetWindowRect(HWnd, ref stRect);

            if (stRect.top < 0)
            {
                // 윈도우가 최소화 되어있다면 활성화 시킨다
                //ShowWindowAsync(HWnd, SW_SHOWNORMAL);

                //Thread.Sleep(3000);

                /* 윈도우 위치 및 크기정보 가져오기 */
                //GetWindowRect(HWnd, ref stRect);
            }

            // 윈도우에 포커스를 줘서 최상위로 만든다
            // SetForegroundWindow(HWnd);


            Top = stRect.top;
            Left = stRect.left;
            Right = stRect.right;
            Bottom = stRect.bottom;
            Height = Bottom - Top;
            Width = Right - Left;
            Scale = (double)Width / (double)baseWidth;

            return true;
        }
    }
}
