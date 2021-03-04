using NLog.Targets;
using UnityEngine;
using Exception6;

namespace DeveloperTools2
{
	// this is a tag for nlog to load this assembly
	[Target("DeveloperTools2")]
	public sealed class Target : TargetWithLayout
	{
		public Target()
		{
			NLogHook<Instance>.Load();
		}
	}
	public class NLogHook<T> where T : MonoBehaviour
	{
		public static Instance Load()
		{
			GameObject result = new GameObject("Exception6");
			Instance returnValue = result.AddComponent<Instance>();
			Object.DontDestroyOnLoad(result);
			return returnValue;
		}
	}
}
