using UnityEngine;

namespace Mirror
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Network/NetworkTransformLocal")]
	public class NetworkTransformLocal : NetworkTransformBaseLocal
	{
		protected override Transform targetComponent { get { return transform; } }
	}
}