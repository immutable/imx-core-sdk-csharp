#!/bin/sh

# Go Code Generation for Smart Contracts
# Downloaded token relevant solidity files from https://github.com/OpenZeppelin/openzeppelin-contracts
# Referenced https://goethereumbook.org/smart-contract-compile/

# Outpiut directory for the generated contracts go files.
OUT_DIR="../Imx/Contracts"

ABI_TEMP_DIR="Generated/Abi"
BIN_TEMP_DIR="Generated/Abi"

# Generating ABI from solidity files using Solidity Compiler.
# See https://goethereumbook.org/smart-contract-compile/
solc --abi Registration.sol IERC20.sol IERC721.sol -o $ABI_TEMP_DIR --overwrite
solc --bin Registration.sol IERC20.sol IERC721.sol -o $BIN_TEMP_DIR --overwrite

# Convert ABI to .Net
# See https://docs.nethereum.com/en/latest/nethereum-codegen-console/#from-abi
rm -rf $OUT_DIR
mkdir -p $OUT_DIR
Nethereum.Generator.Console generate from-abi -abi $ABI_TEMP_DIR/Registration.abi  -ns Contracts -o ../Imx/Contracts/
Nethereum.Generator.Console generate from-abi -abi $ABI_TEMP_DIR/Core.abi  -ns Contracts -o ../Imx/Contracts/
Nethereum.Generator.Console generate from-abi -abi $ABI_TEMP_DIR/IERC20.abi  -ns Contracts -o ../Imx/Contracts/
Nethereum.Generator.Console generate from-abi -abi $ABI_TEMP_DIR/IERC721.abi  -ns Contracts -o ../Imx/Contracts/
