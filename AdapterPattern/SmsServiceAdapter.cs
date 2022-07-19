using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class SmsServiceAdapter : IEmailService
    {
        private ISmsService smsService;

        public SmsServiceAdapter(ISmsService smsService)
        {
            this.smsService = smsService;
        }

        public void SendEmailMessage()
        {            
            smsService.SendSmsMessage();
        }
    }
}
