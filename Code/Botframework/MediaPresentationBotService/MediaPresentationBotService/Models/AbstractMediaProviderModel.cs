using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MediaPresentationBotService.Models
{
    public abstract class AbstractMediaProviderModel
    {
        public virtual async Task ConnectAsync()
        {
            throw new NotImplementedException();
        }

        public virtual async Task DisconnectAsync()
        {
            throw new NotImplementedException();
        }


        public virtual async Task RetrieveData()
        {
            throw new NotImplementedException();
        }

    }
}