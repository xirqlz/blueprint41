using System;

using Blueprint41;
using Blueprint41.Query;

namespace Domain.Data.Query
{
public partial class PRODUCTMODEL_HAS_ILLUSTRATION_REL : RELATIONSHIP, IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL, IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL	{
        public override string NEO4J_TYPE
        {
            get
            {
                return "HAS_ILLUSTRATION";
            }
        }
        public override AliasResult RelationshipAlias { get; protected set; }
        
		internal PRODUCTMODEL_HAS_ILLUSTRATION_REL(Blueprint41.Query.Node parent, DirectionEnum direction) : base(parent, direction) { }

		public PRODUCTMODEL_HAS_ILLUSTRATION_REL Alias(out PRODUCTMODEL_HAS_ILLUSTRATION_ALIAS alias)
		{
			alias = new PRODUCTMODEL_HAS_ILLUSTRATION_ALIAS(this);
            RelationshipAlias = alias;
			return this;
		} 
		public PRODUCTMODEL_HAS_ILLUSTRATION_REL Repeat(int maxHops)
		{
			return Repeat(1, maxHops);
		}
		public PRODUCTMODEL_HAS_ILLUSTRATION_REL Repeat(int minHops, int maxHops)
		{
			return this;
		}

		IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL.Alias(out PRODUCTMODEL_HAS_ILLUSTRATION_ALIAS alias)
		{
			return Alias(out alias);
		}
		IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL.Alias(out PRODUCTMODEL_HAS_ILLUSTRATION_ALIAS alias)
		{
			return Alias(out alias);
		}
		IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL.Repeat(int maxHops)
		{
			return Repeat(maxHops);
		}
		IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL.Repeat(int minHops, int maxHops)
		{
			return Repeat(minHops, maxHops);
		}
		IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL.Repeat(int maxHops)
		{
			return Repeat(maxHops);
		}
		IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL.Repeat(int minHops, int maxHops)
		{
			return Repeat(minHops, maxHops);
		}


		public PRODUCTMODEL_HAS_ILLUSTRATION_IN In { get { return new PRODUCTMODEL_HAS_ILLUSTRATION_IN(this); } }
        public class PRODUCTMODEL_HAS_ILLUSTRATION_IN
        {
            private PRODUCTMODEL_HAS_ILLUSTRATION_REL Parent;
            internal PRODUCTMODEL_HAS_ILLUSTRATION_IN(PRODUCTMODEL_HAS_ILLUSTRATION_REL parent)
            {
                Parent = parent;
            }

			public ProductModelNode ProductModel { get { return new ProductModelNode(Parent, DirectionEnum.In); } }
        }

        public PRODUCTMODEL_HAS_ILLUSTRATION_OUT Out { get { return new PRODUCTMODEL_HAS_ILLUSTRATION_OUT(this); } }
        public class PRODUCTMODEL_HAS_ILLUSTRATION_OUT
        {
            private PRODUCTMODEL_HAS_ILLUSTRATION_REL Parent;
            internal PRODUCTMODEL_HAS_ILLUSTRATION_OUT(PRODUCTMODEL_HAS_ILLUSTRATION_REL parent)
            {
                Parent = parent;
            }

			public IllustrationNode Illustration { get { return new IllustrationNode(Parent, DirectionEnum.Out); } }
        }
	}

    public interface IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL
    {
		IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL Alias(out PRODUCTMODEL_HAS_ILLUSTRATION_ALIAS alias);
		IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL Repeat(int maxHops);
		IFromIn_PRODUCTMODEL_HAS_ILLUSTRATION_REL Repeat(int minHops, int maxHops);

        PRODUCTMODEL_HAS_ILLUSTRATION_REL.PRODUCTMODEL_HAS_ILLUSTRATION_OUT Out { get; }
    }
    public interface IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL
    {
		IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL Alias(out PRODUCTMODEL_HAS_ILLUSTRATION_ALIAS alias);
		IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL Repeat(int maxHops);
		IFromOut_PRODUCTMODEL_HAS_ILLUSTRATION_REL Repeat(int minHops, int maxHops);

        PRODUCTMODEL_HAS_ILLUSTRATION_REL.PRODUCTMODEL_HAS_ILLUSTRATION_IN In { get; }
    }

    public class PRODUCTMODEL_HAS_ILLUSTRATION_ALIAS : AliasResult
    {
		private PRODUCTMODEL_HAS_ILLUSTRATION_REL Parent;

        internal PRODUCTMODEL_HAS_ILLUSTRATION_ALIAS(PRODUCTMODEL_HAS_ILLUSTRATION_REL parent)
        {
			Parent = parent;
        }
    }
}
