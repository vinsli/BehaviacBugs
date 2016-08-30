using UnityEngine;
using System.Collections;

[behaviac.TypeMetaInfo()]
public class Child : Base 
{
	[behaviac.MethodMetaInfo()]
	public behaviac.EBTStatus ChildMethod(float speed)
	{
		return behaviac.EBTStatus.BT_SUCCESS;
	}
}
