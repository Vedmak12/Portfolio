



namespace test
{
	public class Folder : Thing
	{
        List<Thing> _contents = new List<Thing>();


        public Folder(string name) : base(name)
		{
            _contents = new List<Thing>();
        }
    


    

		public void Add(Thing thing)
		{
			_contents.Add(thing);
		}

		public override int Size()
		{
			int size = 0;
			foreach(var item in _contents)
			{
				size += item.Size();
			}
			return size;
		}

		public override void Print()
		{
			if (_contents.Count == 0)
			{
				Console.WriteLine($"The Folder: {Name} is empty!");
			}
			else
			{
				Console.WriteLine($"The Folder: '{Name}' Contains {_contents.Count} files totalling {Size()} bytes");

				
				foreach(var item in  _contents)
				{
					item.Print();
				}
			}

			
		}


	}
}
