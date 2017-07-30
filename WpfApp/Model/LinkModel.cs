using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Model
{
    public class LinkModel: ObservableObject
    {
        private int id;
        public int Id {
            get { return id; }
            set { id = value; RaisePropertyChanged(() => Id); }
        }

        private string title;
        public string Title {
            get { return title; }
            set { title = value; RaisePropertyChanged(() => Title); }
        }

        public string url;
        public string Url {
            get { return url; }
            set { url = value; RaisePropertyChanged(() => Url); }
        }
    }
}
