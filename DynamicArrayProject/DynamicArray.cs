using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
	public class DynArray<T>
	{
		private const int defaultCapacity = 16;
		public T[] array;
		public int capacity;
		public int count;

		public DynArray()
		{
			count = 0;
			MakeArray(16);
		}

		public void MakeArray(int new_capacity)
		{
			if (new_capacity < defaultCapacity)
				new_capacity = defaultCapacity;

			var newArray = new T[new_capacity];

			if(array != null)
				Array.Copy(array, newArray, Math.Min(array.Length, newArray.Length));

			array = newArray;
			capacity = new_capacity;
		}

		public T GetItem(int index)
		{
			// ваш код
			if (index < 0 || index > count - 1)
				throw new IndexOutOfRangeException();

			return array[index];
		}

		public void Append(T itm)
		{
			if (count == capacity)
				MakeArray(capacity * 2);

			count++;
			array[count - 1] = itm;
		}

		public void Insert(T itm, int index)
		{
			if (index < 0 || index > count)
				throw new IndexOutOfRangeException();

			if (count == capacity)
				MakeArray(capacity * 2);

			if (count == index)
				array[count] = itm;
			else
			{
				Array.Copy(array, index, array, index + 1, count - index);
				array[index] = itm;
			}

			count++;
		}

		public void Remove(int index)
		{
			if (index < 0 || index > count - 1)
				throw new IndexOutOfRangeException();

			if (index < count - 1)
				Array.Copy(array, index + 1, array, index, count - index);

			array[count - 1] = default(T);
			count--;

			if (count / (double) capacity < 0.5 && capacity > 16)
				MakeArray((int) (capacity / 1.5));
		}
	}
}