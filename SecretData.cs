using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPI1
{
    // This is where confidential data for testing is stored.
    // In production, data is read from Azure KeyVault

    class SecretData
    {
        public string email_sender { set; get; }
        public string email_pass { set; get; }
        public string host { set; get; }
        public int port { set; get; }

        public string email_recipient { set; get; } // destination

        public string ApiKey_EasyPost { set; get; }

        public SecretData()
        {
            InitSecretData();
        }

        private void InitSecretData()
        {
            this.email_sender    = "your@email.com";
            this.email_pass      = "yourpass";
            this.host            = "smtp.yourserver.com";
            this.port            = 577;

            this.email_recipient = "recipient@email.com";

            this.ApiKey_EasyPost = "";
        }

    }
}
