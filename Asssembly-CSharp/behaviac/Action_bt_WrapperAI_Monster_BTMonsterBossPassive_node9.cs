using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Monster_BTMonsterBossPassive_node9 : Action
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			return ((ObjAgent)pAgent).CanMove();
		}
	}
}
