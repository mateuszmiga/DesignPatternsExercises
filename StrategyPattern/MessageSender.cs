using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MessageSender : ISender
    {
        private ISender _sender;
        public MessageSender(ISender strategy)
        {
            _sender = strategy;
        }
        public void SetStrategy(ISender strategy)
        {
            _sender = strategy;
        }

        public void Send(string message)
        {
            _sender.Send(message);
        }


        
    }
}
