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
using Contracts.Core.ContractDefinition;

namespace Contracts.Core
{
    public partial class CoreService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, CoreDeployment coreDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<CoreDeployment>().SendRequestAndWaitForReceiptAsync(coreDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, CoreDeployment coreDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<CoreDeployment>().SendRequestAsync(coreDeployment);
        }

        public static async Task<CoreService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, CoreDeployment coreDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, coreDeployment, cancellationTokenSource);
            return new CoreService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.IWeb3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public CoreService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public CoreService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> AnnounceAvailabilityVerifierRemovalIntentRequestAsync(AnnounceAvailabilityVerifierRemovalIntentFunction announceAvailabilityVerifierRemovalIntentFunction)
        {
             return ContractHandler.SendRequestAsync(announceAvailabilityVerifierRemovalIntentFunction);
        }

        public Task<TransactionReceipt> AnnounceAvailabilityVerifierRemovalIntentRequestAndWaitForReceiptAsync(AnnounceAvailabilityVerifierRemovalIntentFunction announceAvailabilityVerifierRemovalIntentFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(announceAvailabilityVerifierRemovalIntentFunction, cancellationToken);
        }

        public Task<string> AnnounceAvailabilityVerifierRemovalIntentRequestAsync(string returnValue1)
        {
            var announceAvailabilityVerifierRemovalIntentFunction = new AnnounceAvailabilityVerifierRemovalIntentFunction();
                announceAvailabilityVerifierRemovalIntentFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(announceAvailabilityVerifierRemovalIntentFunction);
        }

        public Task<TransactionReceipt> AnnounceAvailabilityVerifierRemovalIntentRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var announceAvailabilityVerifierRemovalIntentFunction = new AnnounceAvailabilityVerifierRemovalIntentFunction();
                announceAvailabilityVerifierRemovalIntentFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(announceAvailabilityVerifierRemovalIntentFunction, cancellationToken);
        }

        public Task<string> AnnounceVerifierRemovalIntentRequestAsync(AnnounceVerifierRemovalIntentFunction announceVerifierRemovalIntentFunction)
        {
             return ContractHandler.SendRequestAsync(announceVerifierRemovalIntentFunction);
        }

        public Task<TransactionReceipt> AnnounceVerifierRemovalIntentRequestAndWaitForReceiptAsync(AnnounceVerifierRemovalIntentFunction announceVerifierRemovalIntentFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(announceVerifierRemovalIntentFunction, cancellationToken);
        }

        public Task<string> AnnounceVerifierRemovalIntentRequestAsync(string returnValue1)
        {
            var announceVerifierRemovalIntentFunction = new AnnounceVerifierRemovalIntentFunction();
                announceVerifierRemovalIntentFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(announceVerifierRemovalIntentFunction);
        }

        public Task<TransactionReceipt> AnnounceVerifierRemovalIntentRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var announceVerifierRemovalIntentFunction = new AnnounceVerifierRemovalIntentFunction();
                announceVerifierRemovalIntentFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(announceVerifierRemovalIntentFunction, cancellationToken);
        }

        public Task<string> DepositRequestAsync(DepositFunction depositFunction)
        {
             return ContractHandler.SendRequestAsync(depositFunction);
        }

        public Task<TransactionReceipt> DepositRequestAndWaitForReceiptAsync(DepositFunction depositFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositFunction, cancellationToken);
        }

        public Task<string> DepositRequestAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId)
        {
            var depositFunction = new DepositFunction();
                depositFunction.StarkKey = starkKey;
                depositFunction.AssetType = assetType;
                depositFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAsync(depositFunction);
        }

        public Task<TransactionReceipt> DepositRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, CancellationTokenSource cancellationToken = null)
        {
            var depositFunction = new DepositFunction();
                depositFunction.StarkKey = starkKey;
                depositFunction.AssetType = assetType;
                depositFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositFunction, cancellationToken);
        }

        public Task<string> DepositRequestAsync(Deposit1Function deposit1Function)
        {
             return ContractHandler.SendRequestAsync(deposit1Function);
        }

        public Task<TransactionReceipt> DepositRequestAndWaitForReceiptAsync(Deposit1Function deposit1Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(deposit1Function, cancellationToken);
        }

        public Task<string> DepositRequestAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, BigInteger quantizedAmount)
        {
            var deposit1Function = new Deposit1Function();
                deposit1Function.StarkKey = starkKey;
                deposit1Function.AssetType = assetType;
                deposit1Function.VaultId = vaultId;
                deposit1Function.QuantizedAmount = quantizedAmount;
            
             return ContractHandler.SendRequestAsync(deposit1Function);
        }

        public Task<TransactionReceipt> DepositRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, BigInteger quantizedAmount, CancellationTokenSource cancellationToken = null)
        {
            var deposit1Function = new Deposit1Function();
                deposit1Function.StarkKey = starkKey;
                deposit1Function.AssetType = assetType;
                deposit1Function.VaultId = vaultId;
                deposit1Function.QuantizedAmount = quantizedAmount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(deposit1Function, cancellationToken);
        }

        public Task<string> DepositCancelRequestAsync(DepositCancelFunction depositCancelFunction)
        {
             return ContractHandler.SendRequestAsync(depositCancelFunction);
        }

        public Task<TransactionReceipt> DepositCancelRequestAndWaitForReceiptAsync(DepositCancelFunction depositCancelFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositCancelFunction, cancellationToken);
        }

        public Task<string> DepositCancelRequestAsync(BigInteger starkKey, BigInteger assetId, BigInteger vaultId)
        {
            var depositCancelFunction = new DepositCancelFunction();
                depositCancelFunction.StarkKey = starkKey;
                depositCancelFunction.AssetId = assetId;
                depositCancelFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAsync(depositCancelFunction);
        }

        public Task<TransactionReceipt> DepositCancelRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger assetId, BigInteger vaultId, CancellationTokenSource cancellationToken = null)
        {
            var depositCancelFunction = new DepositCancelFunction();
                depositCancelFunction.StarkKey = starkKey;
                depositCancelFunction.AssetId = assetId;
                depositCancelFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositCancelFunction, cancellationToken);
        }

        public Task<string> DepositERC20RequestAsync(DepositERC20Function depositERC20Function)
        {
             return ContractHandler.SendRequestAsync(depositERC20Function);
        }

        public Task<TransactionReceipt> DepositERC20RequestAndWaitForReceiptAsync(DepositERC20Function depositERC20Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositERC20Function, cancellationToken);
        }

        public Task<string> DepositERC20RequestAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, BigInteger quantizedAmount)
        {
            var depositERC20Function = new DepositERC20Function();
                depositERC20Function.StarkKey = starkKey;
                depositERC20Function.AssetType = assetType;
                depositERC20Function.VaultId = vaultId;
                depositERC20Function.QuantizedAmount = quantizedAmount;
            
             return ContractHandler.SendRequestAsync(depositERC20Function);
        }

        public Task<TransactionReceipt> DepositERC20RequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, BigInteger quantizedAmount, CancellationTokenSource cancellationToken = null)
        {
            var depositERC20Function = new DepositERC20Function();
                depositERC20Function.StarkKey = starkKey;
                depositERC20Function.AssetType = assetType;
                depositERC20Function.VaultId = vaultId;
                depositERC20Function.QuantizedAmount = quantizedAmount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositERC20Function, cancellationToken);
        }

        public Task<string> DepositEthRequestAsync(DepositEthFunction depositEthFunction)
        {
             return ContractHandler.SendRequestAsync(depositEthFunction);
        }

        public Task<TransactionReceipt> DepositEthRequestAndWaitForReceiptAsync(DepositEthFunction depositEthFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositEthFunction, cancellationToken);
        }

        public Task<string> DepositEthRequestAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId)
        {
            var depositEthFunction = new DepositEthFunction();
                depositEthFunction.StarkKey = starkKey;
                depositEthFunction.AssetType = assetType;
                depositEthFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAsync(depositEthFunction);
        }

        public Task<TransactionReceipt> DepositEthRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, CancellationTokenSource cancellationToken = null)
        {
            var depositEthFunction = new DepositEthFunction();
                depositEthFunction.StarkKey = starkKey;
                depositEthFunction.AssetType = assetType;
                depositEthFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositEthFunction, cancellationToken);
        }

        public Task<string> DepositNftRequestAsync(DepositNftFunction depositNftFunction)
        {
             return ContractHandler.SendRequestAsync(depositNftFunction);
        }

        public Task<TransactionReceipt> DepositNftRequestAndWaitForReceiptAsync(DepositNftFunction depositNftFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositNftFunction, cancellationToken);
        }

        public Task<string> DepositNftRequestAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, BigInteger tokenId)
        {
            var depositNftFunction = new DepositNftFunction();
                depositNftFunction.StarkKey = starkKey;
                depositNftFunction.AssetType = assetType;
                depositNftFunction.VaultId = vaultId;
                depositNftFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(depositNftFunction);
        }

        public Task<TransactionReceipt> DepositNftRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var depositNftFunction = new DepositNftFunction();
                depositNftFunction.StarkKey = starkKey;
                depositNftFunction.AssetType = assetType;
                depositNftFunction.VaultId = vaultId;
                depositNftFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositNftFunction, cancellationToken);
        }

        public Task<string> DepositNftReclaimRequestAsync(DepositNftReclaimFunction depositNftReclaimFunction)
        {
             return ContractHandler.SendRequestAsync(depositNftReclaimFunction);
        }

        public Task<TransactionReceipt> DepositNftReclaimRequestAndWaitForReceiptAsync(DepositNftReclaimFunction depositNftReclaimFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositNftReclaimFunction, cancellationToken);
        }

        public Task<string> DepositNftReclaimRequestAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, BigInteger tokenId)
        {
            var depositNftReclaimFunction = new DepositNftReclaimFunction();
                depositNftReclaimFunction.StarkKey = starkKey;
                depositNftReclaimFunction.AssetType = assetType;
                depositNftReclaimFunction.VaultId = vaultId;
                depositNftReclaimFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(depositNftReclaimFunction);
        }

        public Task<TransactionReceipt> DepositNftReclaimRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger assetType, BigInteger vaultId, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var depositNftReclaimFunction = new DepositNftReclaimFunction();
                depositNftReclaimFunction.StarkKey = starkKey;
                depositNftReclaimFunction.AssetType = assetType;
                depositNftReclaimFunction.VaultId = vaultId;
                depositNftReclaimFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositNftReclaimFunction, cancellationToken);
        }

        public Task<string> DepositReclaimRequestAsync(DepositReclaimFunction depositReclaimFunction)
        {
             return ContractHandler.SendRequestAsync(depositReclaimFunction);
        }

        public Task<TransactionReceipt> DepositReclaimRequestAndWaitForReceiptAsync(DepositReclaimFunction depositReclaimFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositReclaimFunction, cancellationToken);
        }

        public Task<string> DepositReclaimRequestAsync(BigInteger starkKey, BigInteger assetId, BigInteger vaultId)
        {
            var depositReclaimFunction = new DepositReclaimFunction();
                depositReclaimFunction.StarkKey = starkKey;
                depositReclaimFunction.AssetId = assetId;
                depositReclaimFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAsync(depositReclaimFunction);
        }

        public Task<TransactionReceipt> DepositReclaimRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger assetId, BigInteger vaultId, CancellationTokenSource cancellationToken = null)
        {
            var depositReclaimFunction = new DepositReclaimFunction();
                depositReclaimFunction.StarkKey = starkKey;
                depositReclaimFunction.AssetId = assetId;
                depositReclaimFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositReclaimFunction, cancellationToken);
        }

        public Task<string> EscapeRequestAsync(EscapeFunction escapeFunction)
        {
             return ContractHandler.SendRequestAsync(escapeFunction);
        }

        public Task<TransactionReceipt> EscapeRequestAndWaitForReceiptAsync(EscapeFunction escapeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(escapeFunction, cancellationToken);
        }

        public Task<string> EscapeRequestAsync(BigInteger starkKey, BigInteger vaultId, BigInteger assetId, BigInteger quantizedAmount)
        {
            var escapeFunction = new EscapeFunction();
                escapeFunction.StarkKey = starkKey;
                escapeFunction.VaultId = vaultId;
                escapeFunction.AssetId = assetId;
                escapeFunction.QuantizedAmount = quantizedAmount;
            
             return ContractHandler.SendRequestAsync(escapeFunction);
        }

        public Task<TransactionReceipt> EscapeRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger vaultId, BigInteger assetId, BigInteger quantizedAmount, CancellationTokenSource cancellationToken = null)
        {
            var escapeFunction = new EscapeFunction();
                escapeFunction.StarkKey = starkKey;
                escapeFunction.VaultId = vaultId;
                escapeFunction.AssetId = assetId;
                escapeFunction.QuantizedAmount = quantizedAmount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(escapeFunction, cancellationToken);
        }

        public Task<string> FreezeRequestRequestAsync(FreezeRequestFunction freezeRequestFunction)
        {
             return ContractHandler.SendRequestAsync(freezeRequestFunction);
        }

        public Task<TransactionReceipt> FreezeRequestRequestAndWaitForReceiptAsync(FreezeRequestFunction freezeRequestFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(freezeRequestFunction, cancellationToken);
        }

        public Task<string> FreezeRequestRequestAsync(BigInteger starkKey, BigInteger vaultId)
        {
            var freezeRequestFunction = new FreezeRequestFunction();
                freezeRequestFunction.StarkKey = starkKey;
                freezeRequestFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAsync(freezeRequestFunction);
        }

        public Task<TransactionReceipt> FreezeRequestRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger vaultId, CancellationTokenSource cancellationToken = null)
        {
            var freezeRequestFunction = new FreezeRequestFunction();
                freezeRequestFunction.StarkKey = starkKey;
                freezeRequestFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(freezeRequestFunction, cancellationToken);
        }

        public Task<string> FullWithdrawalRequestRequestAsync(FullWithdrawalRequestFunction fullWithdrawalRequestFunction)
        {
             return ContractHandler.SendRequestAsync(fullWithdrawalRequestFunction);
        }

        public Task<TransactionReceipt> FullWithdrawalRequestRequestAndWaitForReceiptAsync(FullWithdrawalRequestFunction fullWithdrawalRequestFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(fullWithdrawalRequestFunction, cancellationToken);
        }

        public Task<string> FullWithdrawalRequestRequestAsync(BigInteger starkKey, BigInteger vaultId)
        {
            var fullWithdrawalRequestFunction = new FullWithdrawalRequestFunction();
                fullWithdrawalRequestFunction.StarkKey = starkKey;
                fullWithdrawalRequestFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAsync(fullWithdrawalRequestFunction);
        }

        public Task<TransactionReceipt> FullWithdrawalRequestRequestAndWaitForReceiptAsync(BigInteger starkKey, BigInteger vaultId, CancellationTokenSource cancellationToken = null)
        {
            var fullWithdrawalRequestFunction = new FullWithdrawalRequestFunction();
                fullWithdrawalRequestFunction.StarkKey = starkKey;
                fullWithdrawalRequestFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(fullWithdrawalRequestFunction, cancellationToken);
        }

        public Task<byte[]> GetAssetInfoQueryAsync(GetAssetInfoFunction getAssetInfoFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetAssetInfoFunction, byte[]>(getAssetInfoFunction, blockParameter);
        }

        
        public Task<byte[]> GetAssetInfoQueryAsync(BigInteger assetType, BlockParameter blockParameter = null)
        {
            var getAssetInfoFunction = new GetAssetInfoFunction();
                getAssetInfoFunction.AssetType = assetType;
            
            return ContractHandler.QueryAsync<GetAssetInfoFunction, byte[]>(getAssetInfoFunction, blockParameter);
        }

        public Task<BigInteger> GetCancellationRequestQueryAsync(GetCancellationRequestFunction getCancellationRequestFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCancellationRequestFunction, BigInteger>(getCancellationRequestFunction, blockParameter);
        }

        
        public Task<BigInteger> GetCancellationRequestQueryAsync(BigInteger starkKey, BigInteger assetId, BigInteger vaultId, BlockParameter blockParameter = null)
        {
            var getCancellationRequestFunction = new GetCancellationRequestFunction();
                getCancellationRequestFunction.StarkKey = starkKey;
                getCancellationRequestFunction.AssetId = assetId;
                getCancellationRequestFunction.VaultId = vaultId;
            
            return ContractHandler.QueryAsync<GetCancellationRequestFunction, BigInteger>(getCancellationRequestFunction, blockParameter);
        }

        public Task<BigInteger> GetDepositBalanceQueryAsync(GetDepositBalanceFunction getDepositBalanceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetDepositBalanceFunction, BigInteger>(getDepositBalanceFunction, blockParameter);
        }

        
        public Task<BigInteger> GetDepositBalanceQueryAsync(BigInteger starkKey, BigInteger assetId, BigInteger vaultId, BlockParameter blockParameter = null)
        {
            var getDepositBalanceFunction = new GetDepositBalanceFunction();
                getDepositBalanceFunction.StarkKey = starkKey;
                getDepositBalanceFunction.AssetId = assetId;
                getDepositBalanceFunction.VaultId = vaultId;
            
            return ContractHandler.QueryAsync<GetDepositBalanceFunction, BigInteger>(getDepositBalanceFunction, blockParameter);
        }

        public Task<string> GetEthKeyQueryAsync(GetEthKeyFunction getEthKeyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetEthKeyFunction, string>(getEthKeyFunction, blockParameter);
        }

        
        public Task<string> GetEthKeyQueryAsync(BigInteger starkKey, BlockParameter blockParameter = null)
        {
            var getEthKeyFunction = new GetEthKeyFunction();
                getEthKeyFunction.StarkKey = starkKey;
            
            return ContractHandler.QueryAsync<GetEthKeyFunction, string>(getEthKeyFunction, blockParameter);
        }

        public Task<BigInteger> GetFullWithdrawalRequestQueryAsync(GetFullWithdrawalRequestFunction getFullWithdrawalRequestFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetFullWithdrawalRequestFunction, BigInteger>(getFullWithdrawalRequestFunction, blockParameter);
        }

        
        public Task<BigInteger> GetFullWithdrawalRequestQueryAsync(BigInteger starkKey, BigInteger vaultId, BlockParameter blockParameter = null)
        {
            var getFullWithdrawalRequestFunction = new GetFullWithdrawalRequestFunction();
                getFullWithdrawalRequestFunction.StarkKey = starkKey;
                getFullWithdrawalRequestFunction.VaultId = vaultId;
            
            return ContractHandler.QueryAsync<GetFullWithdrawalRequestFunction, BigInteger>(getFullWithdrawalRequestFunction, blockParameter);
        }

        public Task<BigInteger> GetLastBatchIdQueryAsync(GetLastBatchIdFunction getLastBatchIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetLastBatchIdFunction, BigInteger>(getLastBatchIdFunction, blockParameter);
        }

        
        public Task<BigInteger> GetLastBatchIdQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetLastBatchIdFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GetOrderRootQueryAsync(GetOrderRootFunction getOrderRootFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetOrderRootFunction, BigInteger>(getOrderRootFunction, blockParameter);
        }

        
        public Task<BigInteger> GetOrderRootQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetOrderRootFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GetOrderTreeHeightQueryAsync(GetOrderTreeHeightFunction getOrderTreeHeightFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetOrderTreeHeightFunction, BigInteger>(getOrderTreeHeightFunction, blockParameter);
        }

        
        public Task<BigInteger> GetOrderTreeHeightQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetOrderTreeHeightFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GetQuantizedDepositBalanceQueryAsync(GetQuantizedDepositBalanceFunction getQuantizedDepositBalanceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetQuantizedDepositBalanceFunction, BigInteger>(getQuantizedDepositBalanceFunction, blockParameter);
        }

        
        public Task<BigInteger> GetQuantizedDepositBalanceQueryAsync(BigInteger starkKey, BigInteger assetId, BigInteger vaultId, BlockParameter blockParameter = null)
        {
            var getQuantizedDepositBalanceFunction = new GetQuantizedDepositBalanceFunction();
                getQuantizedDepositBalanceFunction.StarkKey = starkKey;
                getQuantizedDepositBalanceFunction.AssetId = assetId;
                getQuantizedDepositBalanceFunction.VaultId = vaultId;
            
            return ContractHandler.QueryAsync<GetQuantizedDepositBalanceFunction, BigInteger>(getQuantizedDepositBalanceFunction, blockParameter);
        }

        public Task<BigInteger> GetQuantumQueryAsync(GetQuantumFunction getQuantumFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetQuantumFunction, BigInteger>(getQuantumFunction, blockParameter);
        }

        
        public Task<BigInteger> GetQuantumQueryAsync(BigInteger presumedAssetType, BlockParameter blockParameter = null)
        {
            var getQuantumFunction = new GetQuantumFunction();
                getQuantumFunction.PresumedAssetType = presumedAssetType;
            
            return ContractHandler.QueryAsync<GetQuantumFunction, BigInteger>(getQuantumFunction, blockParameter);
        }

        public Task<string> GetRegisteredAvailabilityVerifiersRequestAsync(GetRegisteredAvailabilityVerifiersFunction getRegisteredAvailabilityVerifiersFunction)
        {
             return ContractHandler.SendRequestAsync(getRegisteredAvailabilityVerifiersFunction);
        }

        public Task<string> GetRegisteredAvailabilityVerifiersRequestAsync()
        {
             return ContractHandler.SendRequestAsync<GetRegisteredAvailabilityVerifiersFunction>();
        }

        public Task<TransactionReceipt> GetRegisteredAvailabilityVerifiersRequestAndWaitForReceiptAsync(GetRegisteredAvailabilityVerifiersFunction getRegisteredAvailabilityVerifiersFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(getRegisteredAvailabilityVerifiersFunction, cancellationToken);
        }

        public Task<TransactionReceipt> GetRegisteredAvailabilityVerifiersRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<GetRegisteredAvailabilityVerifiersFunction>(null, cancellationToken);
        }

        public Task<string> GetRegisteredVerifiersRequestAsync(GetRegisteredVerifiersFunction getRegisteredVerifiersFunction)
        {
             return ContractHandler.SendRequestAsync(getRegisteredVerifiersFunction);
        }

        public Task<string> GetRegisteredVerifiersRequestAsync()
        {
             return ContractHandler.SendRequestAsync<GetRegisteredVerifiersFunction>();
        }

        public Task<TransactionReceipt> GetRegisteredVerifiersRequestAndWaitForReceiptAsync(GetRegisteredVerifiersFunction getRegisteredVerifiersFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(getRegisteredVerifiersFunction, cancellationToken);
        }

        public Task<TransactionReceipt> GetRegisteredVerifiersRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<GetRegisteredVerifiersFunction>(null, cancellationToken);
        }

        public Task<BigInteger> GetSequenceNumberQueryAsync(GetSequenceNumberFunction getSequenceNumberFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetSequenceNumberFunction, BigInteger>(getSequenceNumberFunction, blockParameter);
        }

        
        public Task<BigInteger> GetSequenceNumberQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetSequenceNumberFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GetVaultRootQueryAsync(GetVaultRootFunction getVaultRootFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetVaultRootFunction, BigInteger>(getVaultRootFunction, blockParameter);
        }

        
        public Task<BigInteger> GetVaultRootQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetVaultRootFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GetVaultTreeHeightQueryAsync(GetVaultTreeHeightFunction getVaultTreeHeightFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetVaultTreeHeightFunction, BigInteger>(getVaultTreeHeightFunction, blockParameter);
        }

        
        public Task<BigInteger> GetVaultTreeHeightQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetVaultTreeHeightFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GetWithdrawalBalanceQueryAsync(GetWithdrawalBalanceFunction getWithdrawalBalanceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetWithdrawalBalanceFunction, BigInteger>(getWithdrawalBalanceFunction, blockParameter);
        }

        
        public Task<BigInteger> GetWithdrawalBalanceQueryAsync(BigInteger ownerKey, BigInteger assetId, BlockParameter blockParameter = null)
        {
            var getWithdrawalBalanceFunction = new GetWithdrawalBalanceFunction();
                getWithdrawalBalanceFunction.OwnerKey = ownerKey;
                getWithdrawalBalanceFunction.AssetId = assetId;
            
            return ContractHandler.QueryAsync<GetWithdrawalBalanceFunction, BigInteger>(getWithdrawalBalanceFunction, blockParameter);
        }

        public Task<string> IsAvailabilityVerifierRequestAsync(IsAvailabilityVerifierFunction isAvailabilityVerifierFunction)
        {
             return ContractHandler.SendRequestAsync(isAvailabilityVerifierFunction);
        }

        public Task<TransactionReceipt> IsAvailabilityVerifierRequestAndWaitForReceiptAsync(IsAvailabilityVerifierFunction isAvailabilityVerifierFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isAvailabilityVerifierFunction, cancellationToken);
        }

        public Task<string> IsAvailabilityVerifierRequestAsync(string returnValue1)
        {
            var isAvailabilityVerifierFunction = new IsAvailabilityVerifierFunction();
                isAvailabilityVerifierFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(isAvailabilityVerifierFunction);
        }

        public Task<TransactionReceipt> IsAvailabilityVerifierRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var isAvailabilityVerifierFunction = new IsAvailabilityVerifierFunction();
                isAvailabilityVerifierFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isAvailabilityVerifierFunction, cancellationToken);
        }

        public Task<string> IsFrozenRequestAsync(IsFrozenFunction isFrozenFunction)
        {
             return ContractHandler.SendRequestAsync(isFrozenFunction);
        }

        public Task<string> IsFrozenRequestAsync()
        {
             return ContractHandler.SendRequestAsync<IsFrozenFunction>();
        }

        public Task<TransactionReceipt> IsFrozenRequestAndWaitForReceiptAsync(IsFrozenFunction isFrozenFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isFrozenFunction, cancellationToken);
        }

        public Task<TransactionReceipt> IsFrozenRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<IsFrozenFunction>(null, cancellationToken);
        }

        public Task<string> IsOperatorRequestAsync(IsOperatorFunction isOperatorFunction)
        {
             return ContractHandler.SendRequestAsync(isOperatorFunction);
        }

        public Task<TransactionReceipt> IsOperatorRequestAndWaitForReceiptAsync(IsOperatorFunction isOperatorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isOperatorFunction, cancellationToken);
        }

        public Task<string> IsOperatorRequestAsync(string returnValue1)
        {
            var isOperatorFunction = new IsOperatorFunction();
                isOperatorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(isOperatorFunction);
        }

        public Task<TransactionReceipt> IsOperatorRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var isOperatorFunction = new IsOperatorFunction();
                isOperatorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isOperatorFunction, cancellationToken);
        }

        public Task<string> IsTokenAdminRequestAsync(IsTokenAdminFunction isTokenAdminFunction)
        {
             return ContractHandler.SendRequestAsync(isTokenAdminFunction);
        }

        public Task<TransactionReceipt> IsTokenAdminRequestAndWaitForReceiptAsync(IsTokenAdminFunction isTokenAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isTokenAdminFunction, cancellationToken);
        }

        public Task<string> IsTokenAdminRequestAsync(string returnValue1)
        {
            var isTokenAdminFunction = new IsTokenAdminFunction();
                isTokenAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(isTokenAdminFunction);
        }

        public Task<TransactionReceipt> IsTokenAdminRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var isTokenAdminFunction = new IsTokenAdminFunction();
                isTokenAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isTokenAdminFunction, cancellationToken);
        }

        public Task<string> IsUserAdminRequestAsync(IsUserAdminFunction isUserAdminFunction)
        {
             return ContractHandler.SendRequestAsync(isUserAdminFunction);
        }

        public Task<TransactionReceipt> IsUserAdminRequestAndWaitForReceiptAsync(IsUserAdminFunction isUserAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isUserAdminFunction, cancellationToken);
        }

        public Task<string> IsUserAdminRequestAsync(string returnValue1)
        {
            var isUserAdminFunction = new IsUserAdminFunction();
                isUserAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(isUserAdminFunction);
        }

        public Task<TransactionReceipt> IsUserAdminRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var isUserAdminFunction = new IsUserAdminFunction();
                isUserAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isUserAdminFunction, cancellationToken);
        }

        public Task<string> IsVerifierRequestAsync(IsVerifierFunction isVerifierFunction)
        {
             return ContractHandler.SendRequestAsync(isVerifierFunction);
        }

        public Task<TransactionReceipt> IsVerifierRequestAndWaitForReceiptAsync(IsVerifierFunction isVerifierFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isVerifierFunction, cancellationToken);
        }

        public Task<string> IsVerifierRequestAsync(string returnValue1)
        {
            var isVerifierFunction = new IsVerifierFunction();
                isVerifierFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(isVerifierFunction);
        }

        public Task<TransactionReceipt> IsVerifierRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var isVerifierFunction = new IsVerifierFunction();
                isVerifierFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(isVerifierFunction, cancellationToken);
        }

        public Task<string> MainAcceptGovernanceRequestAsync(MainAcceptGovernanceFunction mainAcceptGovernanceFunction)
        {
             return ContractHandler.SendRequestAsync(mainAcceptGovernanceFunction);
        }

        public Task<string> MainAcceptGovernanceRequestAsync()
        {
             return ContractHandler.SendRequestAsync<MainAcceptGovernanceFunction>();
        }

        public Task<TransactionReceipt> MainAcceptGovernanceRequestAndWaitForReceiptAsync(MainAcceptGovernanceFunction mainAcceptGovernanceFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mainAcceptGovernanceFunction, cancellationToken);
        }

        public Task<TransactionReceipt> MainAcceptGovernanceRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<MainAcceptGovernanceFunction>(null, cancellationToken);
        }

        public Task<string> MainCancelNominationRequestAsync(MainCancelNominationFunction mainCancelNominationFunction)
        {
             return ContractHandler.SendRequestAsync(mainCancelNominationFunction);
        }

        public Task<string> MainCancelNominationRequestAsync()
        {
             return ContractHandler.SendRequestAsync<MainCancelNominationFunction>();
        }

        public Task<TransactionReceipt> MainCancelNominationRequestAndWaitForReceiptAsync(MainCancelNominationFunction mainCancelNominationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mainCancelNominationFunction, cancellationToken);
        }

        public Task<TransactionReceipt> MainCancelNominationRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<MainCancelNominationFunction>(null, cancellationToken);
        }

        public Task<string> MainIsGovernorRequestAsync(MainIsGovernorFunction mainIsGovernorFunction)
        {
             return ContractHandler.SendRequestAsync(mainIsGovernorFunction);
        }

        public Task<TransactionReceipt> MainIsGovernorRequestAndWaitForReceiptAsync(MainIsGovernorFunction mainIsGovernorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mainIsGovernorFunction, cancellationToken);
        }

        public Task<string> MainIsGovernorRequestAsync(string returnValue1)
        {
            var mainIsGovernorFunction = new MainIsGovernorFunction();
                mainIsGovernorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(mainIsGovernorFunction);
        }

        public Task<TransactionReceipt> MainIsGovernorRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var mainIsGovernorFunction = new MainIsGovernorFunction();
                mainIsGovernorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mainIsGovernorFunction, cancellationToken);
        }

        public Task<string> MainNominateNewGovernorRequestAsync(MainNominateNewGovernorFunction mainNominateNewGovernorFunction)
        {
             return ContractHandler.SendRequestAsync(mainNominateNewGovernorFunction);
        }

        public Task<TransactionReceipt> MainNominateNewGovernorRequestAndWaitForReceiptAsync(MainNominateNewGovernorFunction mainNominateNewGovernorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mainNominateNewGovernorFunction, cancellationToken);
        }

        public Task<string> MainNominateNewGovernorRequestAsync(string returnValue1)
        {
            var mainNominateNewGovernorFunction = new MainNominateNewGovernorFunction();
                mainNominateNewGovernorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(mainNominateNewGovernorFunction);
        }

        public Task<TransactionReceipt> MainNominateNewGovernorRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var mainNominateNewGovernorFunction = new MainNominateNewGovernorFunction();
                mainNominateNewGovernorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mainNominateNewGovernorFunction, cancellationToken);
        }

        public Task<string> MainRemoveGovernorRequestAsync(MainRemoveGovernorFunction mainRemoveGovernorFunction)
        {
             return ContractHandler.SendRequestAsync(mainRemoveGovernorFunction);
        }

        public Task<TransactionReceipt> MainRemoveGovernorRequestAndWaitForReceiptAsync(MainRemoveGovernorFunction mainRemoveGovernorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mainRemoveGovernorFunction, cancellationToken);
        }

        public Task<string> MainRemoveGovernorRequestAsync(string returnValue1)
        {
            var mainRemoveGovernorFunction = new MainRemoveGovernorFunction();
                mainRemoveGovernorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(mainRemoveGovernorFunction);
        }

        public Task<TransactionReceipt> MainRemoveGovernorRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var mainRemoveGovernorFunction = new MainRemoveGovernorFunction();
                mainRemoveGovernorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mainRemoveGovernorFunction, cancellationToken);
        }

        public Task<string> OnERC721ReceivedRequestAsync(OnERC721ReceivedFunction onERC721ReceivedFunction)
        {
             return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public Task<string> OnERC721ReceivedRequestAsync(string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.ReturnValue2 = returnValue2;
                onERC721ReceivedFunction.ReturnValue3 = returnValue3;
                onERC721ReceivedFunction.ReturnValue4 = returnValue4;
            
             return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4, CancellationTokenSource cancellationToken = null)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.ReturnValue2 = returnValue2;
                onERC721ReceivedFunction.ReturnValue3 = returnValue3;
                onERC721ReceivedFunction.ReturnValue4 = returnValue4;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public Task<string> RegisterAndDepositERC20RequestAsync(RegisterAndDepositERC20Function registerAndDepositERC20Function)
        {
             return ContractHandler.SendRequestAsync(registerAndDepositERC20Function);
        }

        public Task<TransactionReceipt> RegisterAndDepositERC20RequestAndWaitForReceiptAsync(RegisterAndDepositERC20Function registerAndDepositERC20Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndDepositERC20Function, cancellationToken);
        }

        public Task<string> RegisterAndDepositERC20RequestAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger vaultId, BigInteger quantizedAmount)
        {
            var registerAndDepositERC20Function = new RegisterAndDepositERC20Function();
                registerAndDepositERC20Function.EthKey = ethKey;
                registerAndDepositERC20Function.StarkKey = starkKey;
                registerAndDepositERC20Function.Signature = signature;
                registerAndDepositERC20Function.AssetType = assetType;
                registerAndDepositERC20Function.VaultId = vaultId;
                registerAndDepositERC20Function.QuantizedAmount = quantizedAmount;
            
             return ContractHandler.SendRequestAsync(registerAndDepositERC20Function);
        }

        public Task<TransactionReceipt> RegisterAndDepositERC20RequestAndWaitForReceiptAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger vaultId, BigInteger quantizedAmount, CancellationTokenSource cancellationToken = null)
        {
            var registerAndDepositERC20Function = new RegisterAndDepositERC20Function();
                registerAndDepositERC20Function.EthKey = ethKey;
                registerAndDepositERC20Function.StarkKey = starkKey;
                registerAndDepositERC20Function.Signature = signature;
                registerAndDepositERC20Function.AssetType = assetType;
                registerAndDepositERC20Function.VaultId = vaultId;
                registerAndDepositERC20Function.QuantizedAmount = quantizedAmount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndDepositERC20Function, cancellationToken);
        }

        public Task<string> RegisterAndDepositEthRequestAsync(RegisterAndDepositEthFunction registerAndDepositEthFunction)
        {
             return ContractHandler.SendRequestAsync(registerAndDepositEthFunction);
        }

        public Task<TransactionReceipt> RegisterAndDepositEthRequestAndWaitForReceiptAsync(RegisterAndDepositEthFunction registerAndDepositEthFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndDepositEthFunction, cancellationToken);
        }

        public Task<string> RegisterAndDepositEthRequestAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger vaultId)
        {
            var registerAndDepositEthFunction = new RegisterAndDepositEthFunction();
                registerAndDepositEthFunction.EthKey = ethKey;
                registerAndDepositEthFunction.StarkKey = starkKey;
                registerAndDepositEthFunction.Signature = signature;
                registerAndDepositEthFunction.AssetType = assetType;
                registerAndDepositEthFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAsync(registerAndDepositEthFunction);
        }

        public Task<TransactionReceipt> RegisterAndDepositEthRequestAndWaitForReceiptAsync(string ethKey, BigInteger starkKey, byte[] signature, BigInteger assetType, BigInteger vaultId, CancellationTokenSource cancellationToken = null)
        {
            var registerAndDepositEthFunction = new RegisterAndDepositEthFunction();
                registerAndDepositEthFunction.EthKey = ethKey;
                registerAndDepositEthFunction.StarkKey = starkKey;
                registerAndDepositEthFunction.Signature = signature;
                registerAndDepositEthFunction.AssetType = assetType;
                registerAndDepositEthFunction.VaultId = vaultId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAndDepositEthFunction, cancellationToken);
        }

        public Task<string> RegisterAvailabilityVerifierRequestAsync(RegisterAvailabilityVerifierFunction registerAvailabilityVerifierFunction)
        {
             return ContractHandler.SendRequestAsync(registerAvailabilityVerifierFunction);
        }

        public Task<TransactionReceipt> RegisterAvailabilityVerifierRequestAndWaitForReceiptAsync(RegisterAvailabilityVerifierFunction registerAvailabilityVerifierFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAvailabilityVerifierFunction, cancellationToken);
        }

        public Task<string> RegisterAvailabilityVerifierRequestAsync(string returnValue1, string returnValue2)
        {
            var registerAvailabilityVerifierFunction = new RegisterAvailabilityVerifierFunction();
                registerAvailabilityVerifierFunction.ReturnValue1 = returnValue1;
                registerAvailabilityVerifierFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAsync(registerAvailabilityVerifierFunction);
        }

        public Task<TransactionReceipt> RegisterAvailabilityVerifierRequestAndWaitForReceiptAsync(string returnValue1, string returnValue2, CancellationTokenSource cancellationToken = null)
        {
            var registerAvailabilityVerifierFunction = new RegisterAvailabilityVerifierFunction();
                registerAvailabilityVerifierFunction.ReturnValue1 = returnValue1;
                registerAvailabilityVerifierFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerAvailabilityVerifierFunction, cancellationToken);
        }

        public Task<string> RegisterOperatorRequestAsync(RegisterOperatorFunction registerOperatorFunction)
        {
             return ContractHandler.SendRequestAsync(registerOperatorFunction);
        }

        public Task<TransactionReceipt> RegisterOperatorRequestAndWaitForReceiptAsync(RegisterOperatorFunction registerOperatorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerOperatorFunction, cancellationToken);
        }

        public Task<string> RegisterOperatorRequestAsync(string returnValue1)
        {
            var registerOperatorFunction = new RegisterOperatorFunction();
                registerOperatorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(registerOperatorFunction);
        }

        public Task<TransactionReceipt> RegisterOperatorRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var registerOperatorFunction = new RegisterOperatorFunction();
                registerOperatorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerOperatorFunction, cancellationToken);
        }

        public Task<string> RegisterTokenRequestAsync(RegisterTokenFunction registerTokenFunction)
        {
             return ContractHandler.SendRequestAsync(registerTokenFunction);
        }

        public Task<TransactionReceipt> RegisterTokenRequestAndWaitForReceiptAsync(RegisterTokenFunction registerTokenFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerTokenFunction, cancellationToken);
        }

        public Task<string> RegisterTokenRequestAsync(BigInteger returnValue1, byte[] returnValue2)
        {
            var registerTokenFunction = new RegisterTokenFunction();
                registerTokenFunction.ReturnValue1 = returnValue1;
                registerTokenFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAsync(registerTokenFunction);
        }

        public Task<TransactionReceipt> RegisterTokenRequestAndWaitForReceiptAsync(BigInteger returnValue1, byte[] returnValue2, CancellationTokenSource cancellationToken = null)
        {
            var registerTokenFunction = new RegisterTokenFunction();
                registerTokenFunction.ReturnValue1 = returnValue1;
                registerTokenFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerTokenFunction, cancellationToken);
        }

        public Task<string> RegisterTokenAdminRequestAsync(RegisterTokenAdminFunction registerTokenAdminFunction)
        {
             return ContractHandler.SendRequestAsync(registerTokenAdminFunction);
        }

        public Task<TransactionReceipt> RegisterTokenAdminRequestAndWaitForReceiptAsync(RegisterTokenAdminFunction registerTokenAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerTokenAdminFunction, cancellationToken);
        }

        public Task<string> RegisterTokenAdminRequestAsync(string returnValue1)
        {
            var registerTokenAdminFunction = new RegisterTokenAdminFunction();
                registerTokenAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(registerTokenAdminFunction);
        }

        public Task<TransactionReceipt> RegisterTokenAdminRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var registerTokenAdminFunction = new RegisterTokenAdminFunction();
                registerTokenAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerTokenAdminFunction, cancellationToken);
        }

        public Task<string> RegisterUserRequestAsync(RegisterUserFunction registerUserFunction)
        {
             return ContractHandler.SendRequestAsync(registerUserFunction);
        }

        public Task<TransactionReceipt> RegisterUserRequestAndWaitForReceiptAsync(RegisterUserFunction registerUserFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerUserFunction, cancellationToken);
        }

        public Task<string> RegisterUserRequestAsync(string returnValue1, BigInteger returnValue2, byte[] returnValue3)
        {
            var registerUserFunction = new RegisterUserFunction();
                registerUserFunction.ReturnValue1 = returnValue1;
                registerUserFunction.ReturnValue2 = returnValue2;
                registerUserFunction.ReturnValue3 = returnValue3;
            
             return ContractHandler.SendRequestAsync(registerUserFunction);
        }

        public Task<TransactionReceipt> RegisterUserRequestAndWaitForReceiptAsync(string returnValue1, BigInteger returnValue2, byte[] returnValue3, CancellationTokenSource cancellationToken = null)
        {
            var registerUserFunction = new RegisterUserFunction();
                registerUserFunction.ReturnValue1 = returnValue1;
                registerUserFunction.ReturnValue2 = returnValue2;
                registerUserFunction.ReturnValue3 = returnValue3;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerUserFunction, cancellationToken);
        }

        public Task<string> RegisterUserAdminRequestAsync(RegisterUserAdminFunction registerUserAdminFunction)
        {
             return ContractHandler.SendRequestAsync(registerUserAdminFunction);
        }

        public Task<TransactionReceipt> RegisterUserAdminRequestAndWaitForReceiptAsync(RegisterUserAdminFunction registerUserAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerUserAdminFunction, cancellationToken);
        }

        public Task<string> RegisterUserAdminRequestAsync(string returnValue1)
        {
            var registerUserAdminFunction = new RegisterUserAdminFunction();
                registerUserAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(registerUserAdminFunction);
        }

        public Task<TransactionReceipt> RegisterUserAdminRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var registerUserAdminFunction = new RegisterUserAdminFunction();
                registerUserAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerUserAdminFunction, cancellationToken);
        }

        public Task<string> RegisterVerifierRequestAsync(RegisterVerifierFunction registerVerifierFunction)
        {
             return ContractHandler.SendRequestAsync(registerVerifierFunction);
        }

        public Task<TransactionReceipt> RegisterVerifierRequestAndWaitForReceiptAsync(RegisterVerifierFunction registerVerifierFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerVerifierFunction, cancellationToken);
        }

        public Task<string> RegisterVerifierRequestAsync(string returnValue1, string returnValue2)
        {
            var registerVerifierFunction = new RegisterVerifierFunction();
                registerVerifierFunction.ReturnValue1 = returnValue1;
                registerVerifierFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAsync(registerVerifierFunction);
        }

        public Task<TransactionReceipt> RegisterVerifierRequestAndWaitForReceiptAsync(string returnValue1, string returnValue2, CancellationTokenSource cancellationToken = null)
        {
            var registerVerifierFunction = new RegisterVerifierFunction();
                registerVerifierFunction.ReturnValue1 = returnValue1;
                registerVerifierFunction.ReturnValue2 = returnValue2;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerVerifierFunction, cancellationToken);
        }

        public Task<string> RemoveAvailabilityVerifierRequestAsync(RemoveAvailabilityVerifierFunction removeAvailabilityVerifierFunction)
        {
             return ContractHandler.SendRequestAsync(removeAvailabilityVerifierFunction);
        }

        public Task<TransactionReceipt> RemoveAvailabilityVerifierRequestAndWaitForReceiptAsync(RemoveAvailabilityVerifierFunction removeAvailabilityVerifierFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAvailabilityVerifierFunction, cancellationToken);
        }

        public Task<string> RemoveAvailabilityVerifierRequestAsync(string returnValue1)
        {
            var removeAvailabilityVerifierFunction = new RemoveAvailabilityVerifierFunction();
                removeAvailabilityVerifierFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(removeAvailabilityVerifierFunction);
        }

        public Task<TransactionReceipt> RemoveAvailabilityVerifierRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var removeAvailabilityVerifierFunction = new RemoveAvailabilityVerifierFunction();
                removeAvailabilityVerifierFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAvailabilityVerifierFunction, cancellationToken);
        }

        public Task<string> RemoveVerifierRequestAsync(RemoveVerifierFunction removeVerifierFunction)
        {
             return ContractHandler.SendRequestAsync(removeVerifierFunction);
        }

        public Task<TransactionReceipt> RemoveVerifierRequestAndWaitForReceiptAsync(RemoveVerifierFunction removeVerifierFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeVerifierFunction, cancellationToken);
        }

        public Task<string> RemoveVerifierRequestAsync(string returnValue1)
        {
            var removeVerifierFunction = new RemoveVerifierFunction();
                removeVerifierFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(removeVerifierFunction);
        }

        public Task<TransactionReceipt> RemoveVerifierRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var removeVerifierFunction = new RemoveVerifierFunction();
                removeVerifierFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeVerifierFunction, cancellationToken);
        }

        public Task<string> UnFreezeRequestAsync(UnFreezeFunction unFreezeFunction)
        {
             return ContractHandler.SendRequestAsync(unFreezeFunction);
        }

        public Task<string> UnFreezeRequestAsync()
        {
             return ContractHandler.SendRequestAsync<UnFreezeFunction>();
        }

        public Task<TransactionReceipt> UnFreezeRequestAndWaitForReceiptAsync(UnFreezeFunction unFreezeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(unFreezeFunction, cancellationToken);
        }

        public Task<TransactionReceipt> UnFreezeRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<UnFreezeFunction>(null, cancellationToken);
        }

        public Task<string> UnregisterOperatorRequestAsync(UnregisterOperatorFunction unregisterOperatorFunction)
        {
             return ContractHandler.SendRequestAsync(unregisterOperatorFunction);
        }

        public Task<TransactionReceipt> UnregisterOperatorRequestAndWaitForReceiptAsync(UnregisterOperatorFunction unregisterOperatorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(unregisterOperatorFunction, cancellationToken);
        }

        public Task<string> UnregisterOperatorRequestAsync(string returnValue1)
        {
            var unregisterOperatorFunction = new UnregisterOperatorFunction();
                unregisterOperatorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(unregisterOperatorFunction);
        }

        public Task<TransactionReceipt> UnregisterOperatorRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var unregisterOperatorFunction = new UnregisterOperatorFunction();
                unregisterOperatorFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(unregisterOperatorFunction, cancellationToken);
        }

        public Task<string> UnregisterTokenAdminRequestAsync(UnregisterTokenAdminFunction unregisterTokenAdminFunction)
        {
             return ContractHandler.SendRequestAsync(unregisterTokenAdminFunction);
        }

        public Task<TransactionReceipt> UnregisterTokenAdminRequestAndWaitForReceiptAsync(UnregisterTokenAdminFunction unregisterTokenAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(unregisterTokenAdminFunction, cancellationToken);
        }

        public Task<string> UnregisterTokenAdminRequestAsync(string returnValue1)
        {
            var unregisterTokenAdminFunction = new UnregisterTokenAdminFunction();
                unregisterTokenAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(unregisterTokenAdminFunction);
        }

        public Task<TransactionReceipt> UnregisterTokenAdminRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var unregisterTokenAdminFunction = new UnregisterTokenAdminFunction();
                unregisterTokenAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(unregisterTokenAdminFunction, cancellationToken);
        }

        public Task<string> UnregisterUserAdminRequestAsync(UnregisterUserAdminFunction unregisterUserAdminFunction)
        {
             return ContractHandler.SendRequestAsync(unregisterUserAdminFunction);
        }

        public Task<TransactionReceipt> UnregisterUserAdminRequestAndWaitForReceiptAsync(UnregisterUserAdminFunction unregisterUserAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(unregisterUserAdminFunction, cancellationToken);
        }

        public Task<string> UnregisterUserAdminRequestAsync(string returnValue1)
        {
            var unregisterUserAdminFunction = new UnregisterUserAdminFunction();
                unregisterUserAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(unregisterUserAdminFunction);
        }

        public Task<TransactionReceipt> UnregisterUserAdminRequestAndWaitForReceiptAsync(string returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var unregisterUserAdminFunction = new UnregisterUserAdminFunction();
                unregisterUserAdminFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(unregisterUserAdminFunction, cancellationToken);
        }

        public Task<string> UpdateStateRequestAsync(UpdateStateFunction updateStateFunction)
        {
             return ContractHandler.SendRequestAsync(updateStateFunction);
        }

        public Task<TransactionReceipt> UpdateStateRequestAndWaitForReceiptAsync(UpdateStateFunction updateStateFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updateStateFunction, cancellationToken);
        }

        public Task<string> UpdateStateRequestAsync(List<BigInteger> publicInput, List<BigInteger> applicationData)
        {
            var updateStateFunction = new UpdateStateFunction();
                updateStateFunction.PublicInput = publicInput;
                updateStateFunction.ApplicationData = applicationData;
            
             return ContractHandler.SendRequestAsync(updateStateFunction);
        }

        public Task<TransactionReceipt> UpdateStateRequestAndWaitForReceiptAsync(List<BigInteger> publicInput, List<BigInteger> applicationData, CancellationTokenSource cancellationToken = null)
        {
            var updateStateFunction = new UpdateStateFunction();
                updateStateFunction.PublicInput = publicInput;
                updateStateFunction.ApplicationData = applicationData;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updateStateFunction, cancellationToken);
        }

        public Task<string> WithdrawRequestAsync(WithdrawFunction withdrawFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public Task<string> WithdrawRequestAsync(BigInteger ownerKey, BigInteger assetType)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.OwnerKey = ownerKey;
                withdrawFunction.AssetType = assetType;
            
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger ownerKey, BigInteger assetType, CancellationTokenSource cancellationToken = null)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.OwnerKey = ownerKey;
                withdrawFunction.AssetType = assetType;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public Task<string> WithdrawAndMintRequestAsync(WithdrawAndMintFunction withdrawAndMintFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawAndMintFunction);
        }

        public Task<TransactionReceipt> WithdrawAndMintRequestAndWaitForReceiptAsync(WithdrawAndMintFunction withdrawAndMintFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawAndMintFunction, cancellationToken);
        }

        public Task<string> WithdrawAndMintRequestAsync(BigInteger ownerKey, BigInteger assetType, byte[] mintingBlob)
        {
            var withdrawAndMintFunction = new WithdrawAndMintFunction();
                withdrawAndMintFunction.OwnerKey = ownerKey;
                withdrawAndMintFunction.AssetType = assetType;
                withdrawAndMintFunction.MintingBlob = mintingBlob;
            
             return ContractHandler.SendRequestAsync(withdrawAndMintFunction);
        }

        public Task<TransactionReceipt> WithdrawAndMintRequestAndWaitForReceiptAsync(BigInteger ownerKey, BigInteger assetType, byte[] mintingBlob, CancellationTokenSource cancellationToken = null)
        {
            var withdrawAndMintFunction = new WithdrawAndMintFunction();
                withdrawAndMintFunction.OwnerKey = ownerKey;
                withdrawAndMintFunction.AssetType = assetType;
                withdrawAndMintFunction.MintingBlob = mintingBlob;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawAndMintFunction, cancellationToken);
        }

        public Task<string> WithdrawNftRequestAsync(WithdrawNftFunction withdrawNftFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawNftFunction);
        }

        public Task<TransactionReceipt> WithdrawNftRequestAndWaitForReceiptAsync(WithdrawNftFunction withdrawNftFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawNftFunction, cancellationToken);
        }

        public Task<string> WithdrawNftRequestAsync(BigInteger ownerKey, BigInteger assetType, BigInteger tokenId)
        {
            var withdrawNftFunction = new WithdrawNftFunction();
                withdrawNftFunction.OwnerKey = ownerKey;
                withdrawNftFunction.AssetType = assetType;
                withdrawNftFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(withdrawNftFunction);
        }

        public Task<TransactionReceipt> WithdrawNftRequestAndWaitForReceiptAsync(BigInteger ownerKey, BigInteger assetType, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var withdrawNftFunction = new WithdrawNftFunction();
                withdrawNftFunction.OwnerKey = ownerKey;
                withdrawNftFunction.AssetType = assetType;
                withdrawNftFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawNftFunction, cancellationToken);
        }

        public Task<string> WithdrawNftToRequestAsync(WithdrawNftToFunction withdrawNftToFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawNftToFunction);
        }

        public Task<TransactionReceipt> WithdrawNftToRequestAndWaitForReceiptAsync(WithdrawNftToFunction withdrawNftToFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawNftToFunction, cancellationToken);
        }

        public Task<string> WithdrawNftToRequestAsync(BigInteger returnValue1, BigInteger returnValue2, BigInteger returnValue3, string returnValue4)
        {
            var withdrawNftToFunction = new WithdrawNftToFunction();
                withdrawNftToFunction.ReturnValue1 = returnValue1;
                withdrawNftToFunction.ReturnValue2 = returnValue2;
                withdrawNftToFunction.ReturnValue3 = returnValue3;
                withdrawNftToFunction.ReturnValue4 = returnValue4;
            
             return ContractHandler.SendRequestAsync(withdrawNftToFunction);
        }

        public Task<TransactionReceipt> WithdrawNftToRequestAndWaitForReceiptAsync(BigInteger returnValue1, BigInteger returnValue2, BigInteger returnValue3, string returnValue4, CancellationTokenSource cancellationToken = null)
        {
            var withdrawNftToFunction = new WithdrawNftToFunction();
                withdrawNftToFunction.ReturnValue1 = returnValue1;
                withdrawNftToFunction.ReturnValue2 = returnValue2;
                withdrawNftToFunction.ReturnValue3 = returnValue3;
                withdrawNftToFunction.ReturnValue4 = returnValue4;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawNftToFunction, cancellationToken);
        }

        public Task<string> WithdrawToRequestAsync(WithdrawToFunction withdrawToFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawToFunction);
        }

        public Task<TransactionReceipt> WithdrawToRequestAndWaitForReceiptAsync(WithdrawToFunction withdrawToFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawToFunction, cancellationToken);
        }

        public Task<string> WithdrawToRequestAsync(BigInteger returnValue1, BigInteger returnValue2, string returnValue3)
        {
            var withdrawToFunction = new WithdrawToFunction();
                withdrawToFunction.ReturnValue1 = returnValue1;
                withdrawToFunction.ReturnValue2 = returnValue2;
                withdrawToFunction.ReturnValue3 = returnValue3;
            
             return ContractHandler.SendRequestAsync(withdrawToFunction);
        }

        public Task<TransactionReceipt> WithdrawToRequestAndWaitForReceiptAsync(BigInteger returnValue1, BigInteger returnValue2, string returnValue3, CancellationTokenSource cancellationToken = null)
        {
            var withdrawToFunction = new WithdrawToFunction();
                withdrawToFunction.ReturnValue1 = returnValue1;
                withdrawToFunction.ReturnValue2 = returnValue2;
                withdrawToFunction.ReturnValue3 = returnValue3;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawToFunction, cancellationToken);
        }
    }
}
