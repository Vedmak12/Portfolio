

namespace test
{
	public class FileSystem
	{

		private List<Thing> _contents;
		public FileSystem()
		{
			_contents = new List<Thing> ();
		}

		

		public void Add(Thing thing)
		{
			_contents.Add(thing);
		}
		
		public void PrintContents()
		{
			Console.WriteLine($"This File System contains: ");
			foreach(var item in  _contents)
			{
				item.Print();
			}
		}
	}
}
