using Sandbox.Common.ObjectBuilders.Definitions;
using VRage.Game;
using VRage.Game.Definitions;
using VRage.Utils;

namespace Sandbox.Definitions
{
    [MyDefinitionType(typeof(MyObjectBuilder_GravityGeneratorDefinition))]
    public class MyGravityGeneratorDefinition : MyCubeBlockDefinition
    {
	    public MyStringHash ResourceSinkGroup;
        public float RequiredPowerInput;
        public float FieldWidth;
        public float FieldHeight;
        public float FieldDepth;

        protected override void Init(MyObjectBuilder_DefinitionBase builder)
        {
            base.Init(builder);

            var obGenerator = builder as MyObjectBuilder_GravityGeneratorDefinition;
            MyDebug.AssertDebug(obGenerator != null, "Initializing thrust definition using wrong object builder.");
	        ResourceSinkGroup = MyStringHash.GetOrCompute(obGenerator.ResourceSinkGroup);
            RequiredPowerInput = obGenerator.RequiredPowerInput;
            FieldWidth = obGenerator.FieldWidth;
            FieldHeight = obGenerator.FieldHeight;
            FieldDepth = obGenerator.FieldDepth;
        }
    }
}
