using Tobacco.Time;

namespace Tobacco
{
	/// <summary>
	/// Tobacco environment exposes access to static tobacco components such as time.
	/// </summary>
	public static class Environment
	{
		public static ITime Time { get; set; }

		static Environment()
		{
			Virtual();
		}

		/// <summary>
		/// Binds all environment components to their virtual implementations.
		/// </summary>
		public static void Virtual()
		{
			Time = new Virtual();
		}

		/// <summary>
		/// Binds all environment components to their actual implementations.
		/// </summary>
		public static void Actual()
		{
			Time = new Actual();
		}
	}
}
