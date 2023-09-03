using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class VideoData : Subject
    {
        private string _title;

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string value)
        {
            VideoDataChanged();
            _title = value;
        }

        private string _description;

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string value)
        {
            VideoDataChanged();

            _description = value;
        }

        private string _fileName;

        public string GetFileName()
        {
            return _fileName;
        }

        public void SetFileName(string value)
        {
            VideoDataChanged();

            _fileName = value;
        }

        private void VideoDataChanged()
        {       
            NotifyObservers(this, null);
        }
    }
}
