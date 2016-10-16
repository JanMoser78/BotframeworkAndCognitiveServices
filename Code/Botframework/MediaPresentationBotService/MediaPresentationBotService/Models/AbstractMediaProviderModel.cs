using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MediaPresentationBotService.Models
{
    public abstract class AbstractMediaProviderModel
    {
        protected IMediaServiceConfiguration _mediaServiceConfiguration;

        public AbstractMediaProviderModel(IMediaServiceConfiguration serviceConfiguration)
        {
            _mediaServiceConfiguration = serviceConfiguration;
        }
        public virtual async Task ConnectAsync()
        {
            throw new NotImplementedException();
        }

        public virtual async Task DisconnectAsync()
        {
            throw new NotImplementedException();
        }


        public virtual async Task RetrieveDataAsync()
        {
            throw new NotImplementedException();
        }

    }
}