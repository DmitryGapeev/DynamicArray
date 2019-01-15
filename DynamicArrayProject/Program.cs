using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
	class Program
	{
		static void Main(string[] args)
		{
			TestAppend();
			TestInsert();
			TestRemove();

			Console.ReadKey();
		}

		static void TestAppend()
		{
			Console.WriteLine("test append");
			Console.WriteLine();

			var dynamicArray = new DynArray<int>();

			Console.WriteLine("array count = " + dynamicArray.count);
			Console.WriteLine("array capacity = " + dynamicArray.capacity);

			for (var i = 0; i < dynamicArray.capacity; i++)
				dynamicArray.Append( i * i);

			for (var i = 0; i < dynamicArray.count; i++)
				Console.Write(dynamicArray.GetItem(i) + " ");

			Console.WriteLine();
			Console.WriteLine("array count = " + dynamicArray.count);
			Console.WriteLine("array capacity = " + dynamicArray.capacity);

			Console.WriteLine();

			Console.WriteLine("add extra, value 200");
			dynamicArray.Append(200);
			Console.WriteLine("array count = " + dynamicArray.count);
			Console.WriteLine("array capacity = " + dynamicArray.capacity);

			for (var i = 0; i < dynamicArray.count; i++)
				Console.Write(dynamicArray.GetItem(i) + " ");

			Console.WriteLine();
			Console.WriteLine(new string('=', 30));
			
		}

		static void TestInsert()
		{
			Console.WriteLine("test insert");
			Console.WriteLine();

			var dynamicArray = new DynArray<int>();

			Console.WriteLine("array count = " + dynamicArray.count);
			Console.WriteLine("array capacity = " + dynamicArray.capacity);

			for (var i = 0; i < dynamicArray.capacity - 3; i++)
				dynamicArray.Append(i * i);

			for (var i = 0; i < dynamicArray.count; i++)
				Console.Write(dynamicArray.GetItem(i) + " ");

			Console.WriteLine();
			Console.WriteLine("insert 1000 into 0");
			Console.WriteLine("array count before = " + dynamicArray.count);
			Console.WriteLine("array capacity before = " + dynamicArray.capacity);
			dynamicArray.Insert(1000, 0);
			Console.WriteLine("array count after = " + dynamicArray.count);
			Console.WriteLine("array capacity after = " + dynamicArray.capacity);

			for (var i = 0; i < dynamicArray.count; i++)
				Console.Write(dynamicArray.GetItem(i) + " ");

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("insert 1000 into 7");
			Console.WriteLine("array count before = " + dynamicArray.count);
			Console.WriteLine("array capacity before = " + dynamicArray.capacity);
			dynamicArray.Insert(7000, 7);
			Console.WriteLine("array count after = " + dynamicArray.count);
			Console.WriteLine("array capacity after = " + dynamicArray.capacity);

			for (var i = 0; i < dynamicArray.count; i++)
				Console.Write(dynamicArray.GetItem(i) + " ");


			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("insert 15000 into 15");
			Console.WriteLine("array count before = " + dynamicArray.count);
			Console.WriteLine("array capacity before = " + dynamicArray.capacity);
			dynamicArray.Insert(15000, 15);
			Console.WriteLine("array count after = " + dynamicArray.count);
			Console.WriteLine("array capacity after = " + dynamicArray.capacity);

			for (var i = 0; i < dynamicArray.count; i++)
				Console.Write(dynamicArray.GetItem(i) + " ");


			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("insert 15000 into 15");
			Console.WriteLine("array count before = " + dynamicArray.count);
			Console.WriteLine("array capacity before = " + dynamicArray.capacity);
			dynamicArray.Insert(15000, 15);
			Console.WriteLine("array count after = " + dynamicArray.count);
			Console.WriteLine("array capacity after = " + dynamicArray.capacity);

			Console.WriteLine();
			Console.WriteLine("try to insert -100 into " + (dynamicArray.count +1));
			try
			{
				dynamicArray.Insert(-100, dynamicArray.count + 1);
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("exception OutOfRange");
			}

			Console.WriteLine(new string('=', 30));
		}

		static void TestRemove()
		{
			Console.WriteLine("test count");
			var dynamicArray = new DynArray<int>();
			
			for (var i = 0; i < 30; i++)
				dynamicArray.Append(i * i);

			for (var i = 0; i < dynamicArray.count; i++)
				Console.Write(dynamicArray.GetItem(i) + " ");

			Console.WriteLine();
			Console.WriteLine("array count after = " + dynamicArray.count);
			Console.WriteLine("array capacity after = " + dynamicArray.capacity);

			Console.WriteLine();
			Console.WriteLine("Remove items");
			for (var i = 20; i > 4;i--)
				dynamicArray.Remove(i);

			Console.WriteLine("array count after = " + dynamicArray.count);
			Console.WriteLine("array capacity after = " + dynamicArray.capacity);
			for (var i = 0; i < dynamicArray.count; i++)
				Console.Write(dynamicArray.GetItem(i) + " ");

			Console.WriteLine();
			Console.WriteLine("Remove items");
			for (var i = dynamicArray.count -2; i > 4; i--)
				dynamicArray.Remove(i);

			Console.WriteLine("array count after = " + dynamicArray.count);
			Console.WriteLine("array capacity after = " + dynamicArray.capacity);
			for (var i = 0; i < dynamicArray.count; i++)
				Console.Write(dynamicArray.GetItem(i) + " ");

			Console.WriteLine();
			Console.WriteLine("try to delete at " + (dynamicArray.count + 1));
			try
			{
				dynamicArray.Remove(dynamicArray.count + 1);
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("exception OutOfRange");
			}
		}
	}
}
