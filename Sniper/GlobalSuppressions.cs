using System.Diagnostics.CodeAnalysis;
using static Sniper.WarningsErrors.MessageSuppression;

[assembly: SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider, MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Sniper.FileAndDirectory.ConfigurationFiles.#.cctor()")]
[assembly: SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider, MessageId = "System.String.Format(System.String,System.Object[])", Scope = "member", Target = "Sniper.Configuration.SiteData.#SiteUrl")]
[assembly: SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider, MessageId = "System.String.Format(System.String,System.Object,System.Object)", Scope = "global")]

