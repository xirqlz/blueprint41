﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
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
    using Blueprint41.Dynamic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class SetDefaultLookupValue : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 9 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"


    Debug.WriteLine("	executing {0} -> Set Default Lookup Value for {1}.{2}", this.GetType().Name, Property.Parent.Name, Property.Name);

            
            #line default
            #line hidden
            this.Write("MATCH (in:");
            
            #line 13 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Property.Parent.Label.Name));
            
            #line default
            #line hidden
            this.Write("), (target:");
            
            #line 13 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Property.ForeignEntity.Label.Name));
            
            #line default
            #line hidden
            this.Write(" { ");
            
            #line 13 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Property.ForeignEntity.Key.Name));
            
            #line default
            #line hidden
            this.Write(" : \'");
            
            #line 13 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Value.GetKey()));
            
            #line default
            #line hidden
            this.Write("\'})\r\nOPTIONAL MATCH (in)-[rel:");
            
            #line 14 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Property.Relationship.Neo4JRelationshipType));
            
            #line default
            #line hidden
            this.Write("]-(out:");
            
            #line 14 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Property.ForeignEntity.Label.Name));
            
            #line default
            #line hidden
            this.Write(")\r\nWITH in, count(out) as count\r\nWHERE count = 0\r\nWITH in LIMIT 10000\r\nCREATE UNI" +
                    "QUE (in)-[rel:");
            
            #line 18 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Property.Relationship.Neo4JRelationshipType));
            
            #line default
            #line hidden
            this.Write("]-(target)\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 19 "E:\_xirqlz\blueprint41\Blueprint41\Neo4j\Refactoring\Templates\SetDefaultLookupValue.tt"


	// Template Parameters
	public Property Property { get; set; }
	public DynamicEntity	Value	 { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}