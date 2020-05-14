namespace Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Runtime.Extensions;

    /// <summary>The properties of a database.</summary>
    public partial class DatabaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IDatabaseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Models.Api20180601Preview.IDatabasePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Charset" /> property.</summary>
        private string _charset;

        /// <summary>The charset of the database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Origin(Microsoft.Azure.PowerShell.Cmdlets.MariaDb.PropertyOrigin.Owned)]
        public string Charset { get => this._charset; set => this._charset = value; }

        /// <summary>Backing field for <see cref="Collation" /> property.</summary>
        private string _collation;

        /// <summary>The collation of the database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Origin(Microsoft.Azure.PowerShell.Cmdlets.MariaDb.PropertyOrigin.Owned)]
        public string Collation { get => this._collation; set => this._collation = value; }

        /// <summary>Creates an new <see cref="DatabaseProperties" /> instance.</summary>
        public DatabaseProperties()
        {

        }
    }
    /// The properties of a database.
    public partial interface IDatabaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Runtime.IJsonSerializable
    {
        /// <summary>The charset of the database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The charset of the database.",
        SerializedName = @"charset",
        PossibleTypes = new [] { typeof(string) })]
        string Charset { get; set; }
        /// <summary>The collation of the database.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collation of the database.",
        SerializedName = @"collation",
        PossibleTypes = new [] { typeof(string) })]
        string Collation { get; set; }

    }
    /// The properties of a database.
    internal partial interface IDatabasePropertiesInternal

    {
        /// <summary>The charset of the database.</summary>
        string Charset { get; set; }
        /// <summary>The collation of the database.</summary>
        string Collation { get; set; }

    }
}