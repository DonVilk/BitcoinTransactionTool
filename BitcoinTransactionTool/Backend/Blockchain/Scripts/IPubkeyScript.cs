﻿// Bitcoin Transaction Tool
// Copyright (c) 2017 Coding Enthusiast
// Distributed under the MIT software license, see the accompanying
// file LICENCE or http://www.opensource.org/licenses/mit-license.php.

namespace BitcoinTransactionTool.Backend.Blockchain.Scripts
{
    public interface IPubkeyScript : IScript
    {
        /// <summary>
        /// Returns type of this pubkey script instance.
        /// </summary>
        /// <returns><see cref="PubkeyScriptType"/> enum</returns>
        PubkeyScriptType GetPublicScriptType();
    }
}
