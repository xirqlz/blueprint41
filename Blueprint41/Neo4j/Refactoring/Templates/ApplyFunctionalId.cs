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
    using System.Linq.Expressions;
    using System.Text;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Blueprint41;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\ApplyFunctionalId.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    internal partial class ApplyFunctionalId : ApplyFunctionalIdBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 9 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\ApplyFunctionalId.tt"

    Debug.WriteLine("	executing {0} -> Apply FunctionalId on entity {1}", this.GetType().Name, Entity.Label.Name);

            
            #line default
            #line hidden
            this.Write("MATCH (node:");
            
            #line 12 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\ApplyFunctionalId.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Entity.Label.Name));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 13 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\ApplyFunctionalId.tt"
 if(! this.Full) 
   {

            
            #line default
            #line hidden
            this.Write("WHERE NOT node.Uid STARTS WITH \'");
            
            #line 16 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\ApplyFunctionalId.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FunctionalId.Prefix));
            
            #line default
            #line hidden
            this.Write("\'\r\n");
            
            #line 17 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\ApplyFunctionalId.tt"
 }

            
            #line default
            #line hidden
            this.Write("WITH node limit 10000 \r\nCALL blueprint41.functionalid.next(\'");
            
            #line 20 "C:\_CirclesArrows\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\ApplyFunctionalId.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FunctionalId.Label));
            
            #line default
            #line hidden
            this.Write("\') YIELD value as key\r\nWITH node,key\r\nSET node.Uid=key\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
