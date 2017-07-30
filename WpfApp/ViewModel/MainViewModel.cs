using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Input;
using WpfApp.Model;
using Zeor.Common;
using System.Linq;
using System.Collections.Generic;
using Zeor.Interface;
using Zeor.Entity;
using AutoMapper;

namespace WpfApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private SpliderInfoModel spliderInfo;
        public SpliderInfoModel SpliderInfo
        {
            get { return spliderInfo; }
            set { spliderInfo = value; RaisePropertyChanged(() => SpliderInfo); }
        }

        private IList<LinkModel> links;
        public IList<LinkModel> Links
        {
            get { return links; }
            set { links = value;RaisePropertyChanged(() => Links); }
        }

        public RelayCommand StartCommand { get; set; }

        public RelayCommand NextCommand { get; set; }

        public RelayCommand HistoryDataCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            SpliderInfo = new SpliderInfoModel() { };
            Links = new List<LinkModel>();
            StartCommand = new RelayCommand(Start);
            NextCommand = new RelayCommand(Next);
            HistoryDataCommand = new RelayCommand(HistoryData);

            ILinksService service = IOCContainer.Instance.Resolve<ILinksService>();
            Links = Mapper.DynamicMap<IList<LinksModel>, IList<LinkModel>>(service.QueryLinks(null).Data);
        }

        private void Start()
        {
            var r = spliderInfo.Domain;
            
        }

        private void Next() {
            HttpHelper httpHelper = new HttpHelper() { };
            var sr = httpHelper.GetHtml(new HttpItem()
            {
                URL = spliderInfo.Domain,
                Timeout = 5600
            });

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(sr.Html);
            var nodes = doc.DocumentNode.Descendants("a").Where(x => x.GetAttributeValue("href", true)).ToList();
            foreach(var node in nodes)
            {
                Links.Add(new LinkModel() {Id=nodes.IndexOf(node)+1,Title = node.InnerHtml, Url = node.GetAttributeValue("href","") });
            }

            IList<LinksModel> models = Mapper.DynamicMap<IList<LinkModel>, IList<LinksModel>>(Links);
            ILinksService service = IOCContainer.Instance.Resolve<ILinksService>();
            service.Save(models);
        }

        private void HistoryData()
        {
            ILinksService service = IOCContainer.Instance.Resolve<ILinksService>();
            Links=Mapper.DynamicMap<IList<LinksModel>,IList<LinkModel>>(service.QueryLinks(null).Data);
        }
    }
}
