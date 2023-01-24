using System.Security.Cryptography;
using System.Numerics;
using Nethereum.Signer;
    
namespace Sdk
{
    public class EthereumSigner
    {

        private EthereumMessageSigner _signer;
        private EthECKey _privateKey;

        public EthereumSigner(string privateKey)
        {
            _signer = new EthereumMessageSigner();
            _privateKey = new EthECKey(privateKey);
        }

        public string SignMessage(string message)
        {
            return _signer.EncodeUTF8AndSign(message, _privateKey);
        }
            
    }
}