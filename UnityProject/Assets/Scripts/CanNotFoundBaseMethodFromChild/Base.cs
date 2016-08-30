using UnityEngine;
using System.Collections;

[behaviac.TypeMetaInfo()]
public class Base : behaviac.Agent 
{
	[behaviac.MethodMetaInfo()]
	public behaviac.EBTStatus BaseMethod(float speed)
	{
		return behaviac.EBTStatus.BT_SUCCESS;
	}
}
