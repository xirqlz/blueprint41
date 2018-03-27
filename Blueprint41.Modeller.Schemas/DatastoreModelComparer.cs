﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Blueprint41.Modeller.Schemas
{
    public abstract class DatastoreModelComparer
    {
        public static DatastoreModelComparer Instance { get { return instance.Value; } }
        private static Lazy<DatastoreModelComparer> instance = new Lazy<DatastoreModelComparer>(delegate ()
        {
            string dll = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Blueprint41.Modeller.Compare.dll");
            if (!File.Exists(dll))
                return null;

            string pdb = dll.Replace("dll", "pdb");
            if (!File.Exists(pdb))
                throw new FileNotFoundException($"File '{pdb}' not found.");

            Type type = AssemblyLoader.GetType(dll, pdb, "DatastoreModelComparerImpl");
            return (DatastoreModelComparer)Activator.CreateInstance(type);
        }, true);

        public abstract void GenerateUpgradeScript(modeller model, string storagePath);
    }

    public static class AssemblyLoader
    {
        public static Assembly LoadAssemblyAndPdbByBytes(string assemblyFile, string pdbFile)
        {
            byte[] assemblyBytes = File.ReadAllBytes(assemblyFile);
            byte[] pdbBytes = File.ReadAllBytes(pdbFile);
            return Assembly.Load(assemblyBytes, pdbBytes);
        }
        public static Type GetType(string assemblyFile, string pdbFile, string typeName)
        {
            Assembly assembly = LoadAssemblyAndPdbByBytes(assemblyFile, pdbFile);
            return assembly.GetTypes().First(x => x.Name == typeName || x.BaseType.Name == typeName);
        }
    }
}
