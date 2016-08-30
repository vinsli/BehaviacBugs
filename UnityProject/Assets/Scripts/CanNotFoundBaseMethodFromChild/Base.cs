using UnityEngine;
using System.Collections;

public class Base : behaviac.Agent 
{
	[behaviac.MethodMetaInfo()]
	public behaviac.EBTStatus BaseMethod(float speed)
	{
		return behaviac.EBTStatus.BT_SUCCESS;
	}
}
