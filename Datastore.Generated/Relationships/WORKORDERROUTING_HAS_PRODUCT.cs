using System;

using Blueprint41;
using Blueprint41.Query;

namespace Domain.Data.Query
{
public partial class WORKORDERROUTING_HAS_PRODUCT_REL : RELATIONSHIP, IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL, IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL	{
        public override string NEO4J_TYPE
        {
            get
            {
                return "HAS_PRODUCT";
            }
        }
        public override AliasResult RelationshipAlias { get; protected set; }
        
		internal WORKORDERROUTING_HAS_PRODUCT_REL(Blueprint41.Query.Node parent, DirectionEnum direction) : base(parent, direction) { }

		public WORKORDERROUTING_HAS_PRODUCT_REL Alias(out WORKORDERROUTING_HAS_PRODUCT_ALIAS alias)
		{
			alias = new WORKORDERROUTING_HAS_PRODUCT_ALIAS(this);
            RelationshipAlias = alias;
			return this;
		} 
		public WORKORDERROUTING_HAS_PRODUCT_REL Repeat(int maxHops)
		{
			return Repeat(1, maxHops);
		}
		public WORKORDERROUTING_HAS_PRODUCT_REL Repeat(int minHops, int maxHops)
		{
			return this;
		}

		IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL.Alias(out WORKORDERROUTING_HAS_PRODUCT_ALIAS alias)
		{
			return Alias(out alias);
		}
		IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL.Alias(out WORKORDERROUTING_HAS_PRODUCT_ALIAS alias)
		{
			return Alias(out alias);
		}
		IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL.Repeat(int maxHops)
		{
			return Repeat(maxHops);
		}
		IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL.Repeat(int minHops, int maxHops)
		{
			return Repeat(minHops, maxHops);
		}
		IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL.Repeat(int maxHops)
		{
			return Repeat(maxHops);
		}
		IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL.Repeat(int minHops, int maxHops)
		{
			return Repeat(minHops, maxHops);
		}


		public WORKORDERROUTING_HAS_PRODUCT_IN In { get { return new WORKORDERROUTING_HAS_PRODUCT_IN(this); } }
        public class WORKORDERROUTING_HAS_PRODUCT_IN
        {
            private WORKORDERROUTING_HAS_PRODUCT_REL Parent;
            internal WORKORDERROUTING_HAS_PRODUCT_IN(WORKORDERROUTING_HAS_PRODUCT_REL parent)
            {
                Parent = parent;
            }

			public WorkOrderRoutingNode WorkOrderRouting { get { return new WorkOrderRoutingNode(Parent, DirectionEnum.In); } }
        }

        public WORKORDERROUTING_HAS_PRODUCT_OUT Out { get { return new WORKORDERROUTING_HAS_PRODUCT_OUT(this); } }
        public class WORKORDERROUTING_HAS_PRODUCT_OUT
        {
            private WORKORDERROUTING_HAS_PRODUCT_REL Parent;
            internal WORKORDERROUTING_HAS_PRODUCT_OUT(WORKORDERROUTING_HAS_PRODUCT_REL parent)
            {
                Parent = parent;
            }

			public ProductNode Product { get { return new ProductNode(Parent, DirectionEnum.Out); } }
        }
	}

    public interface IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL
    {
		IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL Alias(out WORKORDERROUTING_HAS_PRODUCT_ALIAS alias);
		IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL Repeat(int maxHops);
		IFromIn_WORKORDERROUTING_HAS_PRODUCT_REL Repeat(int minHops, int maxHops);

        WORKORDERROUTING_HAS_PRODUCT_REL.WORKORDERROUTING_HAS_PRODUCT_OUT Out { get; }
    }
    public interface IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL
    {
		IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL Alias(out WORKORDERROUTING_HAS_PRODUCT_ALIAS alias);
		IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL Repeat(int maxHops);
		IFromOut_WORKORDERROUTING_HAS_PRODUCT_REL Repeat(int minHops, int maxHops);

        WORKORDERROUTING_HAS_PRODUCT_REL.WORKORDERROUTING_HAS_PRODUCT_IN In { get; }
    }

    public class WORKORDERROUTING_HAS_PRODUCT_ALIAS : AliasResult
    {
		private WORKORDERROUTING_HAS_PRODUCT_REL Parent;

        internal WORKORDERROUTING_HAS_PRODUCT_ALIAS(WORKORDERROUTING_HAS_PRODUCT_REL parent)
        {
			Parent = parent;
        }
    }
}
