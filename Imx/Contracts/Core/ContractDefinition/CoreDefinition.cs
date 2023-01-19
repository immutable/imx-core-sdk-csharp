using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Contracts.Core.ContractDefinition
{


    public partial class CoreDeployment : CoreDeploymentBase
    {
        public CoreDeployment() : base(BYTECODE) { }
        public CoreDeployment(string byteCode) : base(byteCode) { }
    }

    public class CoreDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public CoreDeploymentBase() : base(BYTECODE) { }
        public CoreDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AnnounceAvailabilityVerifierRemovalIntentFunction : AnnounceAvailabilityVerifierRemovalIntentFunctionBase { }

    [Function("announceAvailabilityVerifierRemovalIntent")]
    public class AnnounceAvailabilityVerifierRemovalIntentFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class AnnounceVerifierRemovalIntentFunction : AnnounceVerifierRemovalIntentFunctionBase { }

    [Function("announceVerifierRemovalIntent")]
    public class AnnounceVerifierRemovalIntentFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class DepositFunction : DepositFunctionBase { }

    [Function("deposit")]
    public class DepositFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetType", 2)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class Deposit1Function : Deposit1FunctionBase { }

    [Function("deposit")]
    public class Deposit1FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetType", 2)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "quantizedAmount", 4)]
        public virtual BigInteger QuantizedAmount { get; set; }
    }

    public partial class DepositCancelFunction : DepositCancelFunctionBase { }

    [Function("depositCancel")]
    public class DepositCancelFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetId", 2)]
        public virtual BigInteger AssetId { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class DepositERC20Function : DepositERC20FunctionBase { }

    [Function("depositERC20")]
    public class DepositERC20FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetType", 2)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "quantizedAmount", 4)]
        public virtual BigInteger QuantizedAmount { get; set; }
    }

    public partial class DepositEthFunction : DepositEthFunctionBase { }

    [Function("depositEth")]
    public class DepositEthFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetType", 2)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class DepositNftFunction : DepositNftFunctionBase { }

    [Function("depositNft")]
    public class DepositNftFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetType", 2)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "tokenId", 4)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class DepositNftReclaimFunction : DepositNftReclaimFunctionBase { }

    [Function("depositNftReclaim")]
    public class DepositNftReclaimFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetType", 2)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "tokenId", 4)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class DepositReclaimFunction : DepositReclaimFunctionBase { }

    [Function("depositReclaim")]
    public class DepositReclaimFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetId", 2)]
        public virtual BigInteger AssetId { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class EscapeFunction : EscapeFunctionBase { }

    [Function("escape")]
    public class EscapeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 2)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "assetId", 3)]
        public virtual BigInteger AssetId { get; set; }
        [Parameter("uint256", "quantizedAmount", 4)]
        public virtual BigInteger QuantizedAmount { get; set; }
    }

    public partial class FreezeRequestFunction : FreezeRequestFunctionBase { }

    [Function("freezeRequest")]
    public class FreezeRequestFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 2)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class FullWithdrawalRequestFunction : FullWithdrawalRequestFunctionBase { }

    [Function("fullWithdrawalRequest")]
    public class FullWithdrawalRequestFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 2)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class GetAssetInfoFunction : GetAssetInfoFunctionBase { }

    [Function("getAssetInfo", "bytes")]
    public class GetAssetInfoFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "assetType", 1)]
        public virtual BigInteger AssetType { get; set; }
    }

    public partial class GetCancellationRequestFunction : GetCancellationRequestFunctionBase { }

    [Function("getCancellationRequest", "uint256")]
    public class GetCancellationRequestFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetId", 2)]
        public virtual BigInteger AssetId { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class GetDepositBalanceFunction : GetDepositBalanceFunctionBase { }

    [Function("getDepositBalance", "uint256")]
    public class GetDepositBalanceFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetId", 2)]
        public virtual BigInteger AssetId { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class GetEthKeyFunction : GetEthKeyFunctionBase { }

    [Function("getEthKey", "address")]
    public class GetEthKeyFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
    }

    public partial class GetFullWithdrawalRequestFunction : GetFullWithdrawalRequestFunctionBase { }

    [Function("getFullWithdrawalRequest", "uint256")]
    public class GetFullWithdrawalRequestFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 2)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class GetLastBatchIdFunction : GetLastBatchIdFunctionBase { }

    [Function("getLastBatchId", "uint256")]
    public class GetLastBatchIdFunctionBase : FunctionMessage
    {

    }

    public partial class GetOrderRootFunction : GetOrderRootFunctionBase { }

    [Function("getOrderRoot", "uint256")]
    public class GetOrderRootFunctionBase : FunctionMessage
    {

    }

    public partial class GetOrderTreeHeightFunction : GetOrderTreeHeightFunctionBase { }

    [Function("getOrderTreeHeight", "uint256")]
    public class GetOrderTreeHeightFunctionBase : FunctionMessage
    {

    }

    public partial class GetQuantizedDepositBalanceFunction : GetQuantizedDepositBalanceFunctionBase { }

    [Function("getQuantizedDepositBalance", "uint256")]
    public class GetQuantizedDepositBalanceFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "starkKey", 1)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "assetId", 2)]
        public virtual BigInteger AssetId { get; set; }
        [Parameter("uint256", "vaultId", 3)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class GetQuantumFunction : GetQuantumFunctionBase { }

    [Function("getQuantum", "uint256")]
    public class GetQuantumFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "presumedAssetType", 1)]
        public virtual BigInteger PresumedAssetType { get; set; }
    }

    public partial class GetRegisteredAvailabilityVerifiersFunction : GetRegisteredAvailabilityVerifiersFunctionBase { }

    [Function("getRegisteredAvailabilityVerifiers")]
    public class GetRegisteredAvailabilityVerifiersFunctionBase : FunctionMessage
    {

    }

    public partial class GetRegisteredVerifiersFunction : GetRegisteredVerifiersFunctionBase { }

    [Function("getRegisteredVerifiers")]
    public class GetRegisteredVerifiersFunctionBase : FunctionMessage
    {

    }

    public partial class GetSequenceNumberFunction : GetSequenceNumberFunctionBase { }

    [Function("getSequenceNumber", "uint256")]
    public class GetSequenceNumberFunctionBase : FunctionMessage
    {

    }

    public partial class GetVaultRootFunction : GetVaultRootFunctionBase { }

    [Function("getVaultRoot", "uint256")]
    public class GetVaultRootFunctionBase : FunctionMessage
    {

    }

    public partial class GetVaultTreeHeightFunction : GetVaultTreeHeightFunctionBase { }

    [Function("getVaultTreeHeight", "uint256")]
    public class GetVaultTreeHeightFunctionBase : FunctionMessage
    {

    }

    public partial class GetWithdrawalBalanceFunction : GetWithdrawalBalanceFunctionBase { }

    [Function("getWithdrawalBalance", "uint256")]
    public class GetWithdrawalBalanceFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "ownerKey", 1)]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetId", 2)]
        public virtual BigInteger AssetId { get; set; }
    }

    public partial class IsAvailabilityVerifierFunction : IsAvailabilityVerifierFunctionBase { }

    [Function("isAvailabilityVerifier")]
    public class IsAvailabilityVerifierFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsFrozenFunction : IsFrozenFunctionBase { }

    [Function("isFrozen")]
    public class IsFrozenFunctionBase : FunctionMessage
    {

    }

    public partial class IsOperatorFunction : IsOperatorFunctionBase { }

    [Function("isOperator")]
    public class IsOperatorFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsTokenAdminFunction : IsTokenAdminFunctionBase { }

    [Function("isTokenAdmin")]
    public class IsTokenAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsUserAdminFunction : IsUserAdminFunctionBase { }

    [Function("isUserAdmin")]
    public class IsUserAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsVerifierFunction : IsVerifierFunctionBase { }

    [Function("isVerifier")]
    public class IsVerifierFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MainAcceptGovernanceFunction : MainAcceptGovernanceFunctionBase { }

    [Function("mainAcceptGovernance")]
    public class MainAcceptGovernanceFunctionBase : FunctionMessage
    {

    }

    public partial class MainCancelNominationFunction : MainCancelNominationFunctionBase { }

    [Function("mainCancelNomination")]
    public class MainCancelNominationFunctionBase : FunctionMessage
    {

    }

    public partial class MainIsGovernorFunction : MainIsGovernorFunctionBase { }

    [Function("mainIsGovernor")]
    public class MainIsGovernorFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MainNominateNewGovernorFunction : MainNominateNewGovernorFunctionBase { }

    [Function("mainNominateNewGovernor")]
    public class MainNominateNewGovernorFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MainRemoveGovernorFunction : MainRemoveGovernorFunctionBase { }

    [Function("mainRemoveGovernor")]
    public class MainRemoveGovernorFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OnERC721ReceivedFunction : OnERC721ReceivedFunctionBase { }

    [Function("onERC721Received")]
    public class OnERC721ReceivedFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("bytes", "", 4)]
        public virtual byte[] ReturnValue4 { get; set; }
    }

    public partial class RegisterAndDepositERC20Function : RegisterAndDepositERC20FunctionBase { }

    [Function("registerAndDepositERC20")]
    public class RegisterAndDepositERC20FunctionBase : FunctionMessage
    {
        [Parameter("address", "ethKey", 1)]
        public virtual string EthKey { get; set; }
        [Parameter("uint256", "starkKey", 2)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("bytes", "signature", 3)]
        public virtual byte[] Signature { get; set; }
        [Parameter("uint256", "assetType", 4)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "vaultId", 5)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "quantizedAmount", 6)]
        public virtual BigInteger QuantizedAmount { get; set; }
    }

    public partial class RegisterAndDepositEthFunction : RegisterAndDepositEthFunctionBase { }

    [Function("registerAndDepositEth")]
    public class RegisterAndDepositEthFunctionBase : FunctionMessage
    {
        [Parameter("address", "ethKey", 1)]
        public virtual string EthKey { get; set; }
        [Parameter("uint256", "starkKey", 2)]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("bytes", "signature", 3)]
        public virtual byte[] Signature { get; set; }
        [Parameter("uint256", "assetType", 4)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "vaultId", 5)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class RegisterAvailabilityVerifierFunction : RegisterAvailabilityVerifierFunctionBase { }

    [Function("registerAvailabilityVerifier")]
    public class RegisterAvailabilityVerifierFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("string", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class RegisterOperatorFunction : RegisterOperatorFunctionBase { }

    [Function("registerOperator")]
    public class RegisterOperatorFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RegisterTokenFunction : RegisterTokenFunctionBase { }

    [Function("registerToken")]
    public class RegisterTokenFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("bytes", "", 2)]
        public virtual byte[] ReturnValue2 { get; set; }
    }

    public partial class RegisterTokenAdminFunction : RegisterTokenAdminFunctionBase { }

    [Function("registerTokenAdmin")]
    public class RegisterTokenAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RegisterUserFunction : RegisterUserFunctionBase { }

    [Function("registerUser")]
    public class RegisterUserFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("bytes", "", 3)]
        public virtual byte[] ReturnValue3 { get; set; }
    }

    public partial class RegisterUserAdminFunction : RegisterUserAdminFunctionBase { }

    [Function("registerUserAdmin")]
    public class RegisterUserAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RegisterVerifierFunction : RegisterVerifierFunctionBase { }

    [Function("registerVerifier")]
    public class RegisterVerifierFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("string", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class RemoveAvailabilityVerifierFunction : RemoveAvailabilityVerifierFunctionBase { }

    [Function("removeAvailabilityVerifier")]
    public class RemoveAvailabilityVerifierFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RemoveVerifierFunction : RemoveVerifierFunctionBase { }

    [Function("removeVerifier")]
    public class RemoveVerifierFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class UnFreezeFunction : UnFreezeFunctionBase { }

    [Function("unFreeze")]
    public class UnFreezeFunctionBase : FunctionMessage
    {

    }

    public partial class UnregisterOperatorFunction : UnregisterOperatorFunctionBase { }

    [Function("unregisterOperator")]
    public class UnregisterOperatorFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class UnregisterTokenAdminFunction : UnregisterTokenAdminFunctionBase { }

    [Function("unregisterTokenAdmin")]
    public class UnregisterTokenAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class UnregisterUserAdminFunction : UnregisterUserAdminFunctionBase { }

    [Function("unregisterUserAdmin")]
    public class UnregisterUserAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class UpdateStateFunction : UpdateStateFunctionBase { }

    [Function("updateState")]
    public class UpdateStateFunctionBase : FunctionMessage
    {
        [Parameter("uint256[]", "publicInput", 1)]
        public virtual List<BigInteger> PublicInput { get; set; }
        [Parameter("uint256[]", "applicationData", 2)]
        public virtual List<BigInteger> ApplicationData { get; set; }
    }

    public partial class WithdrawFunction : WithdrawFunctionBase { }

    [Function("withdraw")]
    public class WithdrawFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "ownerKey", 1)]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetType", 2)]
        public virtual BigInteger AssetType { get; set; }
    }

    public partial class WithdrawAndMintFunction : WithdrawAndMintFunctionBase { }

    [Function("withdrawAndMint")]
    public class WithdrawAndMintFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "ownerKey", 1)]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetType", 2)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("bytes", "mintingBlob", 3)]
        public virtual byte[] MintingBlob { get; set; }
    }

    public partial class WithdrawNftFunction : WithdrawNftFunctionBase { }

    [Function("withdrawNft")]
    public class WithdrawNftFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "ownerKey", 1)]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetType", 2)]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class WithdrawNftToFunction : WithdrawNftToFunctionBase { }

    [Function("withdrawNftTo")]
    public class WithdrawNftToFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("address", "", 4)]
        public virtual string ReturnValue4 { get; set; }
    }

    public partial class WithdrawToFunction : WithdrawToFunctionBase { }

    [Function("withdrawTo")]
    public class WithdrawToFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("address", "", 3)]
        public virtual string ReturnValue3 { get; set; }
    }

    public partial class LogDepositEventDTO : LogDepositEventDTOBase { }

    [Event("LogDeposit")]
    public class LogDepositEventDTOBase : IEventDTO
    {
        [Parameter("address", "depositorEthKey", 1, false )]
        public virtual string DepositorEthKey { get; set; }
        [Parameter("uint256", "starkKey", 2, false )]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 3, false )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "assetType", 4, false )]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "nonQuantizedAmount", 5, false )]
        public virtual BigInteger NonQuantizedAmount { get; set; }
        [Parameter("uint256", "quantizedAmount", 6, false )]
        public virtual BigInteger QuantizedAmount { get; set; }
    }

    public partial class LogDepositCancelEventDTO : LogDepositCancelEventDTOBase { }

    [Event("LogDepositCancel")]
    public class LogDepositCancelEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "starkKey", 1, false )]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 2, false )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "assetId", 3, false )]
        public virtual BigInteger AssetId { get; set; }
    }

    public partial class LogDepositCancelReclaimedEventDTO : LogDepositCancelReclaimedEventDTOBase { }

    [Event("LogDepositCancelReclaimed")]
    public class LogDepositCancelReclaimedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "starkKey", 1, false )]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 2, false )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "assetType", 3, false )]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "nonQuantizedAmount", 4, false )]
        public virtual BigInteger NonQuantizedAmount { get; set; }
        [Parameter("uint256", "quantizedAmount", 5, false )]
        public virtual BigInteger QuantizedAmount { get; set; }
    }

    public partial class LogDepositNftCancelReclaimedEventDTO : LogDepositNftCancelReclaimedEventDTOBase { }

    [Event("LogDepositNftCancelReclaimed")]
    public class LogDepositNftCancelReclaimedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "starkKey", 1, false )]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 2, false )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "assetType", 3, false )]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "tokenId", 4, false )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "assetId", 5, false )]
        public virtual BigInteger AssetId { get; set; }
    }

    public partial class LogFullWithdrawalRequestEventDTO : LogFullWithdrawalRequestEventDTOBase { }

    [Event("LogFullWithdrawalRequest")]
    public class LogFullWithdrawalRequestEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "starkKey", 1, false )]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 2, false )]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class LogMintWithdrawalPerformedEventDTO : LogMintWithdrawalPerformedEventDTOBase { }

    [Event("LogMintWithdrawalPerformed")]
    public class LogMintWithdrawalPerformedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "ownerKey", 1, false )]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetType", 2, false )]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "nonQuantizedAmount", 3, false )]
        public virtual BigInteger NonQuantizedAmount { get; set; }
        [Parameter("uint256", "quantizedAmount", 4, false )]
        public virtual BigInteger QuantizedAmount { get; set; }
        [Parameter("uint256", "assetId", 5, false )]
        public virtual BigInteger AssetId { get; set; }
    }

    public partial class LogMintableWithdrawalAllowedEventDTO : LogMintableWithdrawalAllowedEventDTOBase { }

    [Event("LogMintableWithdrawalAllowed")]
    public class LogMintableWithdrawalAllowedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "ownerKey", 1, false )]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetId", 2, false )]
        public virtual BigInteger AssetId { get; set; }
        [Parameter("uint256", "quantizedAmount", 3, false )]
        public virtual BigInteger QuantizedAmount { get; set; }
    }

    public partial class LogNftDepositEventDTO : LogNftDepositEventDTOBase { }

    [Event("LogNftDeposit")]
    public class LogNftDepositEventDTOBase : IEventDTO
    {
        [Parameter("address", "depositorEthKey", 1, false )]
        public virtual string DepositorEthKey { get; set; }
        [Parameter("uint256", "starkKey", 2, false )]
        public virtual BigInteger StarkKey { get; set; }
        [Parameter("uint256", "vaultId", 3, false )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "assetType", 4, false )]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "tokenId", 5, false )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "assetId", 6, false )]
        public virtual BigInteger AssetId { get; set; }
    }

    public partial class LogNftWithdrawalAllowedEventDTO : LogNftWithdrawalAllowedEventDTOBase { }

    [Event("LogNftWithdrawalAllowed")]
    public class LogNftWithdrawalAllowedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "ownerKey", 1, false )]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetId", 2, false )]
        public virtual BigInteger AssetId { get; set; }
    }

    public partial class LogNftWithdrawalPerformedEventDTO : LogNftWithdrawalPerformedEventDTOBase { }

    [Event("LogNftWithdrawalPerformed")]
    public class LogNftWithdrawalPerformedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "ownerKey", 1, false )]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetType", 2, false )]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "tokenId", 3, false )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "assetId", 4, false )]
        public virtual BigInteger AssetId { get; set; }
        [Parameter("address", "recipient", 5, false )]
        public virtual string Recipient { get; set; }
    }

    public partial class LogRootUpdateEventDTO : LogRootUpdateEventDTOBase { }

    [Event("LogRootUpdate")]
    public class LogRootUpdateEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "sequenceNumber", 1, false )]
        public virtual BigInteger SequenceNumber { get; set; }
        [Parameter("uint256", "batchId", 2, false )]
        public virtual BigInteger BatchId { get; set; }
        [Parameter("uint256", "vaultRoot", 3, false )]
        public virtual BigInteger VaultRoot { get; set; }
        [Parameter("uint256", "orderRoot", 4, false )]
        public virtual BigInteger OrderRoot { get; set; }
    }

    public partial class LogStateTransitionFactEventDTO : LogStateTransitionFactEventDTOBase { }

    [Event("LogStateTransitionFact")]
    public class LogStateTransitionFactEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "stateTransitionFact", 1, false )]
        public virtual byte[] StateTransitionFact { get; set; }
    }

    public partial class LogVaultBalanceChangeAppliedEventDTO : LogVaultBalanceChangeAppliedEventDTOBase { }

    [Event("LogVaultBalanceChangeApplied")]
    public class LogVaultBalanceChangeAppliedEventDTOBase : IEventDTO
    {
        [Parameter("address", "ethKey", 1, false )]
        public virtual string EthKey { get; set; }
        [Parameter("uint256", "assetId", 2, false )]
        public virtual BigInteger AssetId { get; set; }
        [Parameter("uint256", "vaultId", 3, false )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("int256", "quantizedAmountChange", 4, false )]
        public virtual BigInteger QuantizedAmountChange { get; set; }
    }

    public partial class LogWithdrawalAllowedEventDTO : LogWithdrawalAllowedEventDTOBase { }

    [Event("LogWithdrawalAllowed")]
    public class LogWithdrawalAllowedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "ownerKey", 1, false )]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetType", 2, false )]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "nonQuantizedAmount", 3, false )]
        public virtual BigInteger NonQuantizedAmount { get; set; }
        [Parameter("uint256", "quantizedAmount", 4, false )]
        public virtual BigInteger QuantizedAmount { get; set; }
    }

    public partial class LogWithdrawalPerformedEventDTO : LogWithdrawalPerformedEventDTOBase { }

    [Event("LogWithdrawalPerformed")]
    public class LogWithdrawalPerformedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "ownerKey", 1, false )]
        public virtual BigInteger OwnerKey { get; set; }
        [Parameter("uint256", "assetType", 2, false )]
        public virtual BigInteger AssetType { get; set; }
        [Parameter("uint256", "nonQuantizedAmount", 3, false )]
        public virtual BigInteger NonQuantizedAmount { get; set; }
        [Parameter("uint256", "quantizedAmount", 4, false )]
        public virtual BigInteger QuantizedAmount { get; set; }
        [Parameter("address", "recipient", 5, false )]
        public virtual string Recipient { get; set; }
    }



























    public partial class GetAssetInfoOutputDTO : GetAssetInfoOutputDTOBase { }

    [FunctionOutput]
    public class GetAssetInfoOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "assetInfo", 1)]
        public virtual byte[] AssetInfo { get; set; }
    }

    public partial class GetCancellationRequestOutputDTO : GetCancellationRequestOutputDTOBase { }

    [FunctionOutput]
    public class GetCancellationRequestOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "request", 1)]
        public virtual BigInteger Request { get; set; }
    }

    public partial class GetDepositBalanceOutputDTO : GetDepositBalanceOutputDTOBase { }

    [FunctionOutput]
    public class GetDepositBalanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
    }

    public partial class GetEthKeyOutputDTO : GetEthKeyOutputDTOBase { }

    [FunctionOutput]
    public class GetEthKeyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "ethKey", 1)]
        public virtual string EthKey { get; set; }
    }

    public partial class GetFullWithdrawalRequestOutputDTO : GetFullWithdrawalRequestOutputDTOBase { }

    [FunctionOutput]
    public class GetFullWithdrawalRequestOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "res", 1)]
        public virtual BigInteger Res { get; set; }
    }

    public partial class GetLastBatchIdOutputDTO : GetLastBatchIdOutputDTOBase { }

    [FunctionOutput]
    public class GetLastBatchIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "batchId", 1)]
        public virtual BigInteger BatchId { get; set; }
    }

    public partial class GetOrderRootOutputDTO : GetOrderRootOutputDTOBase { }

    [FunctionOutput]
    public class GetOrderRootOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "root", 1)]
        public virtual BigInteger Root { get; set; }
    }

    public partial class GetOrderTreeHeightOutputDTO : GetOrderTreeHeightOutputDTOBase { }

    [FunctionOutput]
    public class GetOrderTreeHeightOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "height", 1)]
        public virtual BigInteger Height { get; set; }
    }

    public partial class GetQuantizedDepositBalanceOutputDTO : GetQuantizedDepositBalanceOutputDTOBase { }

    [FunctionOutput]
    public class GetQuantizedDepositBalanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
    }

    public partial class GetQuantumOutputDTO : GetQuantumOutputDTOBase { }

    [FunctionOutput]
    public class GetQuantumOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "quantum", 1)]
        public virtual BigInteger Quantum { get; set; }
    }





    public partial class GetSequenceNumberOutputDTO : GetSequenceNumberOutputDTOBase { }

    [FunctionOutput]
    public class GetSequenceNumberOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "seq", 1)]
        public virtual BigInteger Seq { get; set; }
    }

    public partial class GetVaultRootOutputDTO : GetVaultRootOutputDTOBase { }

    [FunctionOutput]
    public class GetVaultRootOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "root", 1)]
        public virtual BigInteger Root { get; set; }
    }

    public partial class GetVaultTreeHeightOutputDTO : GetVaultTreeHeightOutputDTOBase { }

    [FunctionOutput]
    public class GetVaultTreeHeightOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "height", 1)]
        public virtual BigInteger Height { get; set; }
    }

    public partial class GetWithdrawalBalanceOutputDTO : GetWithdrawalBalanceOutputDTOBase { }

    [FunctionOutput]
    public class GetWithdrawalBalanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
    }


































































}
