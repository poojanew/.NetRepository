using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Aug8_
{
    class email_sms
    {
        public virtual void msgsent()
        {
            Console.WriteLine("Notification sent");
        }
    }

    class viaEmail : email_sms
    {
        public override void msgsent()
        {
            Console.WriteLine("Notification sent via email");

        }
    }

    class viaSms : email_sms
    {
        public override void msgsent()
        {
            Console.WriteLine("Notification sent via sms");

        }
    }
}
