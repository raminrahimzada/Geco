using System;

namespace Geco.Common
{
    public class OptionsAttribute : Attribute
    {
        public Type OptionType { get; }
        public OptionsAttribute(Type optionsType)
        {
            OptionType = optionsType ?? throw new ArgumentNullException(nameof(optionsType));
        }
    }
}