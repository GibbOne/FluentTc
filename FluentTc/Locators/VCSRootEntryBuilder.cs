﻿using FluentTc.Domain;

namespace FluentTc.Locators
{
    public interface IVCSRootEntryBuilder
    {
        IVCSRootEntryBuilder Id(string value);

        IVCSRootEntryBuilder CheckoutRules(string value);
    }

    public class VCSRootEntryBuilder: IVCSRootEntryBuilder
    {
        private VcsRootEntry m_VCSRootEntry = new VcsRootEntry();

        public IVCSRootEntryBuilder Id(string value)
        {
            if (m_VCSRootEntry.VcsRoot == null) m_VCSRootEntry.VcsRoot = new VcsRoot();
            m_VCSRootEntry.VcsRoot.Id = value;
            return this;
        }

        public IVCSRootEntryBuilder CheckoutRules(string value)
        {
            m_VCSRootEntry.CheckoutRules = value;
            return this;
        }

        public VcsRootEntry GetVCSRootEntry()
        {
            return m_VCSRootEntry;
        }
    }
}