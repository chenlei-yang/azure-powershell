// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Argument completer implementation for ResolveStatus.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResolveStatusTypeConverter))]
    public partial struct ResolveStatus :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Initialized".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Initialized", "Initialized", global::System.Management.Automation.CompletionResultType.ParameterValue, "Initialized");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Resolved".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Resolved", "Resolved", global::System.Management.Automation.CompletionResultType.ParameterValue, "Resolved");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "InvalidSyntax".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("InvalidSyntax", "InvalidSyntax", global::System.Management.Automation.CompletionResultType.ParameterValue, "InvalidSyntax");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MSINotEnabled".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("MSINotEnabled", "MSINotEnabled", global::System.Management.Automation.CompletionResultType.ParameterValue, "MSINotEnabled");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "VaultNotFound".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("VaultNotFound", "VaultNotFound", global::System.Management.Automation.CompletionResultType.ParameterValue, "VaultNotFound");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SecretNotFound".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SecretNotFound", "SecretNotFound", global::System.Management.Automation.CompletionResultType.ParameterValue, "SecretNotFound");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SecretVersionNotFound".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SecretVersionNotFound", "SecretVersionNotFound", global::System.Management.Automation.CompletionResultType.ParameterValue, "SecretVersionNotFound");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AccessToKeyVaultDenied".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AccessToKeyVaultDenied", "AccessToKeyVaultDenied", global::System.Management.Automation.CompletionResultType.ParameterValue, "AccessToKeyVaultDenied");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "OtherReasons".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("OtherReasons", "OtherReasons", global::System.Management.Automation.CompletionResultType.ParameterValue, "OtherReasons");
            }
        }
    }
}