
namespace test
{
	public class file1: Thing 
	{
		
		private string _extension;
		private int _size;

		
		public file1 (string name , string extension, int size) : base(name)
		{
			
			this._extension = extension;
			this._size = size;
		}
		public override int Size()
		{
			return _size;
		}

		public override void Print()
		{
			Console.WriteLine($"File '{Name}{_extension} ' Size: {_size}) bytes");
		
		}





	}
}
