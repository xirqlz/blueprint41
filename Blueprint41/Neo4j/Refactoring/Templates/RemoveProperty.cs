﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Blueprint41.Neo4j.Refactoring.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Blueprint41;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RemoveProperty.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    internal partial class RemoveProperty : RemovePropertyBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 8 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RemoveProperty.tt"


    Debug.WriteLine("	executing {0} -> Remove property from {1}.{2}", this.GetType().Name, ConcreteParent.Label.Name, Name);

            
            #line default
            #line hidden
            this.Write("MATCH (node:");
            
            #line 12 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RemoveProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConcreteParent.Label.Name));
            
            #line default
            #line hidden
            this.Write(") WHERE EXISTS(node.");
            
            #line 12 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RemoveProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(") \r\nWITH node LIMIT 10000 \r\nSET node.");
            
            #line 14 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\RemoveProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Name));
            
            #line default
            #line hidden
            this.Write(" = NULL\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
