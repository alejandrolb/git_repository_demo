﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace test55
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the test55Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("56eaf8cc-718f-4fc4-9ead-db248ecfd6b5")]
    public partial class test55Repository : RepoGenBaseFolder
    {
        static test55Repository instance = new test55Repository();

        /// <summary>
        /// Gets the singleton class instance representing the test55Repository element repository.
        /// </summary>
        [RepositoryFolder("56eaf8cc-718f-4fc4-9ead-db248ecfd6b5")]
        public static test55Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public test55Repository() 
            : base("test55Repository", "/", null, 0, false, "56eaf8cc-718f-4fc4-9ead-db248ecfd6b5", ".\\RepositoryImages\\test55Repository56eaf8cc.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("56eaf8cc-718f-4fc4-9ead-db248ecfd6b5")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    public partial class test55RepositoryFolders
    {
    }
#pragma warning restore 0436
}