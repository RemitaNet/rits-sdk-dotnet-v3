using System;
using System.Collections.Generic;
  
using System.Text;
  

namespace RemitaRITsGateway.Com.Systemspecs.Paymentinfra.RitsGetBankList
{
    public class GetActiveBankPayload
    {
        private string _requestId;

        public string RequestId
        {
            get { return _requestId; }
            set { _requestId = value; }
        }

    }
}
