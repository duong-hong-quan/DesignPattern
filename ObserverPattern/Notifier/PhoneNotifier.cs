using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Notifier
{
    public class PhoneNotifier : Observer
    {
        public PhoneNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);

        }
        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine("Notify all subscribers via PHONE with new data" +
                                                  "\n\tName: {0}" +
                                                  "\n\tDescription: {1}" +
                                                  "\n\tFile name: {2}", videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName());

            }
        }
    }
}
