namespace test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FileSystem filesystem = new FileSystem();

			for (int i = 0; i < 5; i++)
			{
				filesystem.Add(new file1($"104762184-{i}",".txt",100 + i*10));
			}

			Folder folder = new Folder("Folder WITH 3 files");
			for (int i = 0; i < 3; i++)
			{
				folder.Add(new file1($"104762184-{i}", ".txt", 150 + i * 10));
			}
			filesystem.Add(folder);


			Folder folder1 = new Folder("Folder with subfolder");
			Folder subfolder = new Folder("subfolder with 23 files");
			for (int i = 0;i<23;i++)
			{
				subfolder.Add(new file1($"104762184-{i}", ".txt", 200 + i * 10));
			}

			folder1.Add(subfolder);
			filesystem.Add(folder1);


			for (int i = 0; i < 11; i++)
			{
				filesystem.Add(new Folder($"'Empty Folder {i}'"));
			}
			filesystem.PrintContents();
		}
	}
}
