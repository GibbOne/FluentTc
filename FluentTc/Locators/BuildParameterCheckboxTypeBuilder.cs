﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentTc.Locators
{
    public interface IBuildParameterCheckboxTypeBuilder
    {
        IBuildParameterCheckboxTypeBuilder WithCheckedValue(string checkedValue);
        IBuildParameterCheckboxTypeBuilder WithUncheckedValue(string uncheckedValue);
    }

    internal class BuildParameterCheckboxTypeBuilder : IBuildParameterCheckboxTypeBuilder
    {
        private string m_checkedValue;
        private string m_uncheckedValue;

        public IBuildParameterCheckboxTypeBuilder WithCheckedValue(string checkedValue)
        {
            m_checkedValue = checkedValue;
            return this;
        }

        public IBuildParameterCheckboxTypeBuilder WithUncheckedValue(string uncheckedValue)
        {
            m_uncheckedValue = uncheckedValue;
            return this;
        }

        public string Build()
        {
            var builder = new StringBuilder();
            builder.Append("checkbox");
            if (!string.IsNullOrEmpty(m_checkedValue))
                builder.Append($" checkedValue='{m_checkedValue}'");
            if (!string.IsNullOrEmpty(m_uncheckedValue))
                builder.Append($" uncheckedValue='{m_uncheckedValue}'");
            return builder.ToString();
        }
    }
}
