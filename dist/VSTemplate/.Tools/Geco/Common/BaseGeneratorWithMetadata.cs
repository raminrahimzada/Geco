﻿using System;
using Geco.Common.Inflector;
using Geco.Common.SimpleMetadata;

namespace Geco.Common
{
    public abstract class BaseGeneratorWithMetadata : BaseGenerator
    {
        protected readonly string ConnectionName;
        public DatabaseMetadata Db => Provider.GetMetadata(ConnectionName);
        public IMetadataProvider Provider { get; }

        protected BaseGeneratorWithMetadata(IMetadataProvider provider, IInflector inf, string connectionName)
            : base(inf)
        {
            ConnectionName = connectionName;
            Provider = provider;
        }

        protected void ReloadMetadata()
        {
            Provider.Reload();
            Db.Freeze();
        }

        protected virtual void OnMetadataLoaded(DatabaseMetadata db)
        {

        }

        protected string GetCSharpTypeName(Type type)
        {
            if (type == typeof(bool)) return "bool";
            if (type == typeof(byte)) return "byte";
            if (type == typeof(sbyte)) return "sbyte";
            if (type == typeof(char)) return "char";
            if (type == typeof(decimal)) return "decimal";
            if (type == typeof(double)) return "double";
            if (type == typeof(float)) return "float";
            if (type == typeof(int)) return "int";
            if (type == typeof(uint)) return "uint";
            if (type == typeof(long)) return "long";
            if (type == typeof(ulong)) return "ulong";
            if (type == typeof(object)) return "object";
            if (type == typeof(short)) return "short";
            if (type == typeof(ushort)) return "ushort";
            if (type == typeof(string)) return "string";
            return type.Name;
        }
    }
}