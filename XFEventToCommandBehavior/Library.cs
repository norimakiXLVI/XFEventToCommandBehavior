namespace XFEventToCommandBehavior
{
	public static class Library
	{
		private static object guard;

		public static void Init()
		{
			guard = new object();
		}
	}
}

