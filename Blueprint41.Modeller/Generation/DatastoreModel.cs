﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Blueprint41.Modeller.Generation
{
    using System;
    using System.Text;
    using System.IO;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using Blueprint41.Modeller.Schemas;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class DatastoreModel : GenerationBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 10 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
 foreach (var functionalId in FunctionalIds)
{

            
            #line default
            #line hidden
            
            #line 13 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    if(functionalId.IsDefault == true)
    {

            
            #line default
            #line hidden
            this.Write("    FunctionalIds.Default = FunctionalIds.New(\"");
            
            #line 17 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 17 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Value));
            
            #line default
            #line hidden
            this.Write("\", IdFormat.");
            
            #line 17 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Type));
            
            #line default
            #line hidden
            this.Write(", 0);\r\n");
            
            #line 18 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
 
    } else {

            
            #line default
            #line hidden
            this.Write("    FunctionalId ");
            
            #line 21 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Name.ToLower()));
            
            #line default
            #line hidden
            this.Write("Id = FunctionalIds.New(\"");
            
            #line 21 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 21 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Value));
            
            #line default
            #line hidden
            this.Write("\", IdFormat.");
            
            #line 21 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(functionalId.Type));
            
            #line default
            #line hidden
            this.Write(", 0);\r\n");
            
            #line 22 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
        
   } // end of else

            
            #line default
            #line hidden
            
            #line 25 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
 
} // end of foreach functional id

            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 30 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

foreach (var entity in Entities)
{
    if(string.IsNullOrEmpty(entity.Inherits))
    {
        if (string.IsNullOrEmpty(entity.FunctionalId))
        {

            
            #line default
            #line hidden
            this.Write("    Entities.New(\"");
            
            #line 38 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 39 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        } 
        else 
        {
            var ids = FunctionalIds.Where(x => x.Guid == entity.FunctionalId && x.IsDefault == false).ToList();
            string entityFunctionalId = ids.Count > 0 ?  ", " + ids.First().Name.ToLower() + "Id": "";

            
            #line default
            #line hidden
            this.Write("    Entities.New(\"");
            
            #line 46 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 46 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityFunctionalId));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 47 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
    }
    else
    {
        string inheritedEntityName = Modeller.Model.Entities.Entity.Where(x => x.Guid == entity.Inherits).First().Name;			
        if(string.IsNullOrEmpty(entity.FunctionalId))
        {

            
            #line default
            #line hidden
            this.Write("    Entities.New(\"");
            
            #line 56 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\", Entities[\"");
            
            #line 56 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(inheritedEntityName));
            
            #line default
            #line hidden
            this.Write("\"])\r\n");
            
            #line 57 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
        else
        {
            var ids = FunctionalIds.Where(x => x.Guid == entity.FunctionalId && x.IsDefault == false).ToList();
            string entityFunctionalId = ids.Count > 0 ?  ids.First().Name.ToLower() + "Id, ": "";

            
            #line default
            #line hidden
            this.Write("    Entities.New(\"");
            
            #line 64 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 64 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entityFunctionalId));
            
            #line default
            #line hidden
            this.Write("Entities[\"");
            
            #line 64 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(inheritedEntityName));
            
            #line default
            #line hidden
            this.Write("\"])\r\n");
            
            #line 65 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
				
        }
        if(!string.IsNullOrEmpty(entity.Summary))
        {

            
            #line default
            #line hidden
            this.Write("        .Summary(\"");
            
            #line 70 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Summary.Replace("\"", "\\\"")));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 71 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
    }
    if(entity.Abstract)
    {

            
            #line default
            #line hidden
            this.Write("        .Abstract(true)\r\n");
            
            #line 78 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    }
    if(entity.Virtual)
    {

            
            #line default
            #line hidden
            this.Write("        .Virtual(true)\r\n");
            
            #line 84 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    }
	if (entity.StaticData != null)
	{

            
            #line default
            #line hidden
            this.Write("        .HasStaticData(true)\r\n");
            
            #line 90 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

	}
    foreach (var primitive in entity.Primitive)
    {
        if(!string.IsNullOrEmpty(primitive.Index) && !primitive.Index.Equals("None"))
        {

            
            #line default
            #line hidden
            this.Write("        .AddProperty(\"");
            
            #line 97 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Name));
            
            #line default
            #line hidden
            this.Write("\", typeof(");
            
            #line 97 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Type));
            
            #line default
            #line hidden
            this.Write("), ");
            
            #line 97 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!primitive.Nullable?"false,":""));
            
            #line default
            #line hidden
            this.Write(" IndexType.");
            
            #line 97 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Index));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 98 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
        else
        {

            
            #line default
            #line hidden
            this.Write("        .AddProperty(\"");
            
            #line 103 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Name));
            
            #line default
            #line hidden
            this.Write("\", typeof(");
            
            #line 103 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Type ?? ""));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 103 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!primitive.Nullable?", false":""));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 104 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
        if(primitive.IsKey)
        {

            
            #line default
            #line hidden
            this.Write("        .SetKey(\"");
            
            #line 109 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Name));
            
            #line default
            #line hidden
            this.Write("\", true)\r\n");
            
            #line 110 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
    } // end of foreach primitive
    Write(string.Join($"{Environment.NewLine}", entity.Primitive.Where(x => x.IsFullTextProperty == true).Select(x =>".SetFullTextProperty(\""+ x.Name+"\")").ToList()));
    GenerationEnvironment = TrimEnd(GenerationEnvironment);
    Write(";\r\n\r\n");

            
            #line default
            #line hidden
            
            #line 117 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

} // end foreach entities
foreach (var relationship in Relationships)
{
    bool hasRelationshipSourceName = string.IsNullOrEmpty(relationship.Source.Name);
    bool hasRelationshipTargetName = string.IsNullOrEmpty(relationship.Target.Name);

    string postfix = hasRelationshipTargetName ? ";" : "";
    if(string.IsNullOrEmpty(relationship.Name))
    {

            
            #line default
            #line hidden
            this.Write("\r\n    Relations.New(Entities[\"");
            
            #line 129 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Label));
            
            #line default
            #line hidden
            this.Write("\"], ");
            
            #line 129 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Label != null ? $"Entities[\"{relationship.Target.Label}\"]" : "null"));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 129 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Type));
            
            #line default
            #line hidden
            this.Write(")\r\n");
            
            #line 130 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    }
    else
    {

            
            #line default
            #line hidden
            this.Write("\r\n    Relations.New(Entities[\"");
            
            #line 136 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Label));
            
            #line default
            #line hidden
            this.Write("\"], ");
            
            #line 136 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Label != null ? $"Entities[\"{relationship.Target.Label}\"]" : "null"));
            
            #line default
            #line hidden
            this.Write(", \"");
            
            #line 136 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 136 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Type));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 137 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

    }
    if(!hasRelationshipSourceName)
    {
        if(relationship.Source.Nullable)
            {

            
            #line default
            #line hidden
            this.Write("        .SetInProperty(\"");
            
            #line 144 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Name));
            
            #line default
            #line hidden
            this.Write("\", PropertyType.");
            
            #line 144 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Type));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 144 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(postfix));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 145 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

			}
			else
            {

            
            #line default
            #line hidden
            this.Write("        .SetInProperty(\"");
            
            #line 150 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Name));
            
            #line default
            #line hidden
            this.Write("\", PropertyType.");
            
            #line 150 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Type));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 150 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Source.Nullable.ToString().ToLower()));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 150 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(postfix));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 151 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

            }
    }
    if(!hasRelationshipTargetName)
    {
        if(relationship.Target.Nullable)
        {

            
            #line default
            #line hidden
            this.Write("        .SetOutProperty(\"");
            
            #line 159 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Name));
            
            #line default
            #line hidden
            this.Write("\", PropertyType.");
            
            #line 159 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Type));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 160 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
		else
        {

            
            #line default
            #line hidden
            this.Write("        .SetOutProperty(\"");
            
            #line 165 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Name));
            
            #line default
            #line hidden
            this.Write("\", PropertyType.");
            
            #line 165 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Type));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 165 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(relationship.Target.Nullable.ToString().ToLower()));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 166 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

        }
    }
    else
    {
    }
} // end of foreach entities

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 175 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

foreach (var entity in Entities)
{
	if (entity.StaticData != null)
	{
		foreach(var record in entity.StaticData.Records.Record)
		{
			var allProperties = new List<Primitive>();
            Entity current = entity;
            do
            {
               allProperties.AddRange(current.Primitive);
               current = current.ParentEntity;
            } while (current != null);
            var primitiveRecords = record.Property.Where(r => allProperties.Any(p => p.Guid == r.PropertyGuid));


            
            #line default
            #line hidden
            this.Write("    Entities[\"");
            
            #line 192 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Name));
            
            #line default
            #line hidden
            this.Write("\"].Refactor.CreateNode(new {");
            
            #line 192 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

			for(int index = 0; index < primitiveRecords.Count(); index++)
			{
				var prop = primitiveRecords.ElementAt(index);
				string comma = index == primitiveRecords.Count() - 1 ? " " : ",";
				var primitive = allProperties.Where(p => p.Guid == prop.PropertyGuid).FirstOrDefault();
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 197 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(primitive.Name));
            
            #line default
            #line hidden
            this.Write(" = \"");
            
            #line 197 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Value));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 197 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(comma));
            
            #line default
            #line hidden
            
            #line 197 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

			}

            
            #line default
            #line hidden
            this.Write("});\r\n");
            
            #line 200 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 205 "D:\_Xirqlz\blueprint41\Blueprint41.Modeller\Generation\DatastoreModel.tt"

	
} // end foreach entities

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
