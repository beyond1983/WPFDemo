using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Model
{
    /// <summary>
    /// 抓取基础信息
    /// </summary>
    public class SpliderInfoModel : ObservableObject
    {
        private string domain;
        /// <summary>
        /// 域名地址
        /// </summary>
        public string Domain
        {
            get { return domain; }
            set { domain = value; RaisePropertyChanged(() => Domain); }
        }

        private string title;
        /// <summary>
        /// 任务名称
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value;RaisePropertyChanged(() => Title); }
        }
    }
}
