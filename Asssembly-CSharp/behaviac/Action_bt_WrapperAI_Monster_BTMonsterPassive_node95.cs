using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Monster_BTMonsterPassive_node95 : Action
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			uint objID = (uint)pAgent.GetVariable(1128863647u);
			((ObjAgent)pAgent).SelectTarget(objID);
			return EBTStatus.BT_SUCCESS;
		}
	}
}
