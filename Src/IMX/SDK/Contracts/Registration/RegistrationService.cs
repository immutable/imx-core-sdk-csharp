using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Contracts.Registration.ContractDefinition;

namespace Contracts.Registration
{
    public partial class RegistrationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, RegistrationDeployment registrationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<RegistrationDeployment>().SendRequestAndWaitForReceiptAsync(registrationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, RegistrationDeployment registrationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<RegistrationDeployment>().SendRequestAsync(registrationDeployment);
        }

        public static async Task<RegistrationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, RegistrationDeployment registrationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, registrationDeployment, cancellationTokenSource);
            return new RegistrationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.IWeb3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public RegistrationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public RegistrationService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> ImxQueryAsync(ImxFunction imxFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ImxFunction, string>(imxFunction, blockParameter);
        }

        
        public Task<string> ImxQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ImxFunction, string>(null, blockParameter);
        }

        public Task<bool> IsRegisteredQueryAsync(IsRegisteredFunction isRegisteredFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsRegisteredFunction, bool>(isRegisteredFunction, blockParameter);
        }

        
        public Task<bool> IsRegisteredQueryAsync(BigInteger starkKey, BlockParameter blockParameter = null)
        {
            var isRegisteredFunction = new IsRegisteredFunction();
                isRegisteredFunction.StarkKey = starkKey;
            
            return ContractHandler.QueryAsync<IsRegisteredFunction, bool>(isRegisteredFunction, blockParameter);
        }

        public Task<string> RegisterAndDepositNftRequestAsync(RegisterAndDepositNftFunction registerAndDepositNftFunction)
        {
             return ContractHandler.SendRequestAsync(registerAndDepositNftFunction);
        }

        public Task<TransactionReceipt> RegisterAndDepositNftRequestAndWaitForReceiptAsync(RegisterAndDepositNftFunction registerAndDepositNftFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndDepositNftFunction, cancellationToken);
        }

        public Task<string> RegisterAndDepositNftRequestAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger vaultId, BigInteger tokenId)
        {
            var registerAndDepositNftFunction = new RegisterAndDepositNftFunction();
                registerAndDepositNftFunction.EthKey = ethKey;
                registerAndDepositNftFunction.StarkKey = starkKey;
                registerAndDepositNftFunction.Signature = signature;
                registerAndDepositNftFunction.AssetType = assetType;
                registerAndDepositNftFunction.VaultId = vaultId;
                registerAndDepositNftFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(registerAndDepositNftFunction);
        }

        public Task<TransactionReceipt> RegisterAndDepositNftRequestAndWaitForReceiptAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger vaultId, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var registerAndDepositNftFunction = new RegisterAndDepositNftFunction();
                registerAndDepositNftFunction.EthKey = ethKey;
                registerAndDepositNftFunction.StarkKey = starkKey;
                registerAndDepositNftFunction.Signature = signature;
                registerAndDepositNftFunction.AssetType = assetType;
                registerAndDepositNftFunction.VaultId = vaultId;
                registerAndDepositNftFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndDepositNftFunction, cancellationToken);
        }

        public Task<string> RegisterAndWithdrawRequestAsync(RegisterAndWithdrawFunction registerAndWithdrawFunction)
        {
             return ContractHandler.SendRequestAsync(registerAndWithdrawFunction);
        }

        public Task<TransactionReceipt> RegisterAndWithdrawRequestAndWaitForReceiptAsync(RegisterAndWithdrawFunction registerAndWithdrawFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndWithdrawFunction, cancellationToken);
        }

        public Task<string> RegisterAndWithdrawRequestAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType)
        {
            var registerAndWithdrawFunction = new RegisterAndWithdrawFunction();
                registerAndWithdrawFunction.EthKey = ethKey;
                registerAndWithdrawFunction.StarkKey = starkKey;
                registerAndWithdrawFunction.Signature = signature;
                registerAndWithdrawFunction.AssetType = assetType;
            
             return ContractHandler.SendRequestAsync(registerAndWithdrawFunction);
        }

        public Task<TransactionReceipt> RegisterAndWithdrawRequestAndWaitForReceiptAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, CancellationTokenSource cancellationToken = null)
        {
            var registerAndWithdrawFunction = new RegisterAndWithdrawFunction();
                registerAndWithdrawFunction.EthKey = ethKey;
                registerAndWithdrawFunction.StarkKey = starkKey;
                registerAndWithdrawFunction.Signature = signature;
                registerAndWithdrawFunction.AssetType = assetType;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndWithdrawFunction, cancellationToken);
        }

        public Task<string> RegisterAndWithdrawNftRequestAsync(RegisterAndWithdrawNftFunction registerAndWithdrawNftFunction)
        {
             return ContractHandler.SendRequestAsync(registerAndWithdrawNftFunction);
        }

        public Task<TransactionReceipt> RegisterAndWithdrawNftRequestAndWaitForReceiptAsync(RegisterAndWithdrawNftFunction registerAndWithdrawNftFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndWithdrawNftFunction, cancellationToken);
        }

        public Task<string> RegisterAndWithdrawNftRequestAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger tokenId)
        {
            var registerAndWithdrawNftFunction = new RegisterAndWithdrawNftFunction();
                registerAndWithdrawNftFunction.EthKey = ethKey;
                registerAndWithdrawNftFunction.StarkKey = starkKey;
                registerAndWithdrawNftFunction.Signature = signature;
                registerAndWithdrawNftFunction.AssetType = assetType;
                registerAndWithdrawNftFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(registerAndWithdrawNftFunction);
        }

        public Task<TransactionReceipt> RegisterAndWithdrawNftRequestAndWaitForReceiptAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var registerAndWithdrawNftFunction = new RegisterAndWithdrawNftFunction();
                registerAndWithdrawNftFunction.EthKey = ethKey;
                registerAndWithdrawNftFunction.StarkKey = starkKey;
                registerAndWithdrawNftFunction.Signature = signature;
                registerAndWithdrawNftFunction.AssetType = assetType;
                registerAndWithdrawNftFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndWithdrawNftFunction, cancellationToken);
        }

        public Task<string> RegisterAndWithdrawNftToRequestAsync(RegisterAndWithdrawNftToFunction registerAndWithdrawNftToFunction)
        {
             return ContractHandler.SendRequestAsync(registerAndWithdrawNftToFunction);
        }

        public Task<TransactionReceipt> RegisterAndWithdrawNftToRequestAndWaitForReceiptAsync(RegisterAndWithdrawNftToFunction registerAndWithdrawNftToFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndWithdrawNftToFunction, cancellationToken);
        }

        public Task<string> RegisterAndWithdrawNftToRequestAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger tokenId, string recipient)
        {
            var registerAndWithdrawNftToFunction = new RegisterAndWithdrawNftToFunction();
                registerAndWithdrawNftToFunction.EthKey = ethKey;
                registerAndWithdrawNftToFunction.StarkKey = starkKey;
                registerAndWithdrawNftToFunction.Signature = signature;
                registerAndWithdrawNftToFunction.AssetType = assetType;
                registerAndWithdrawNftToFunction.TokenId = tokenId;
                registerAndWithdrawNftToFunction.Recipient = recipient;
            
             return ContractHandler.SendRequestAsync(registerAndWithdrawNftToFunction);
        }

        public Task<TransactionReceipt> RegisterAndWithdrawNftToRequestAndWaitForReceiptAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger tokenId, string recipient, CancellationTokenSource cancellationToken = null)
        {
            var registerAndWithdrawNftToFunction = new RegisterAndWithdrawNftToFunction();
                registerAndWithdrawNftToFunction.EthKey = ethKey;
                registerAndWithdrawNftToFunction.StarkKey = starkKey;
                registerAndWithdrawNftToFunction.Signature = signature;
                registerAndWithdrawNftToFunction.AssetType = assetType;
                registerAndWithdrawNftToFunction.TokenId = tokenId;
                registerAndWithdrawNftToFunction.Recipient = recipient;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndWithdrawNftToFunction, cancellationToken);
        }

        public Task<string> RegisterAndWithdrawToRequestAsync(RegisterAndWithdrawToFunction registerAndWithdrawToFunction)
        {
             return ContractHandler.SendRequestAsync(registerAndWithdrawToFunction);
        }

        public Task<TransactionReceipt> RegisterAndWithdrawToRequestAndWaitForReceiptAsync(RegisterAndWithdrawToFunction registerAndWithdrawToFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndWithdrawToFunction, cancellationToken);
        }

        public Task<string> RegisterAndWithdrawToRequestAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, string recipient)
        {
            var registerAndWithdrawToFunction = new RegisterAndWithdrawToFunction();
                registerAndWithdrawToFunction.EthKey = ethKey;
                registerAndWithdrawToFunction.StarkKey = starkKey;
                registerAndWithdrawToFunction.Signature = signature;
                registerAndWithdrawToFunction.AssetType = assetType;
                registerAndWithdrawToFunction.Recipient = recipient;
            
             return ContractHandler.SendRequestAsync(registerAndWithdrawToFunction);
        }

        public Task<TransactionReceipt> RegisterAndWithdrawToRequestAndWaitForReceiptAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, string recipient, CancellationTokenSource cancellationToken = null)
        {
            var registerAndWithdrawToFunction = new RegisterAndWithdrawToFunction();
                registerAndWithdrawToFunction.EthKey = ethKey;
                registerAndWithdrawToFunction.StarkKey = starkKey;
                registerAndWithdrawToFunction.Signature = signature;
                registerAndWithdrawToFunction.AssetType = assetType;
                registerAndWithdrawToFunction.Recipient = recipient;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndWithdrawToFunction, cancellationToken);
        }

        public Task<string> RegsiterAndWithdrawAndMintRequestAsync(RegsiterAndWithdrawAndMintFunction regsiterAndWithdrawAndMintFunction)
        {
             return ContractHandler.SendRequestAsync(regsiterAndWithdrawAndMintFunction);
        }

        public Task<TransactionReceipt> RegsiterAndWithdrawAndMintRequestAndWaitForReceiptAsync(RegsiterAndWithdrawAndMintFunction regsiterAndWithdrawAndMintFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(regsiterAndWithdrawAndMintFunction, cancellationToken);
        }

        public Task<string> RegsiterAndWithdrawAndMintRequestAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, byte[] mintingBlob)
        {
            var regsiterAndWithdrawAndMintFunction = new RegsiterAndWithdrawAndMintFunction();
                regsiterAndWithdrawAndMintFunction.EthKey = ethKey;
                regsiterAndWithdrawAndMintFunction.StarkKey = starkKey;
                regsiterAndWithdrawAndMintFunction.Signature = signature;
                regsiterAndWithdrawAndMintFunction.AssetType = assetType;
                regsiterAndWithdrawAndMintFunction.MintingBlob = mintingBlob;
            
             return ContractHandler.SendRequestAsync(regsiterAndWithdrawAndMintFunction);
        }

        public Task<TransactionReceipt> RegsiterAndWithdrawAndMintRequestAndWaitForReceiptAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, byte[] mintingBlob, CancellationTokenSource cancellationToken = null)
        {
            var regsiterAndWithdrawAndMintFunction = new RegsiterAndWithdrawAndMintFunction();
                regsiterAndWithdrawAndMintFunction.EthKey = ethKey;
                regsiterAndWithdrawAndMintFunction.StarkKey = starkKey;
                regsiterAndWithdrawAndMintFunction.Signature = signature;
                regsiterAndWithdrawAndMintFunction.AssetType = assetType;
                regsiterAndWithdrawAndMintFunction.MintingBlob = mintingBlob;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(regsiterAndWithdrawAndMintFunction, cancellationToken);
        }
    }
}
