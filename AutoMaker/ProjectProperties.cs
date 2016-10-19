using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMaker
{
    class ProjectProperties
    {
        private string appName;// 앱이름

        // 앱이름
        [CategoryAttribute("문서 설정"),
         DescriptionAttribute("앱이름")]
        public string AppName
        {
            get
            {
                return appName;
            }

            set
            {
                appName = value;
            }
        }
    }
}
