using System;
using System.Collections.ObjectModel;

namespace Gui.Extensions
{
	public static class CollectionExtensions
	{
		public static void AddOrReplace<T>(this Collection<T> collection, Func<T, bool> predicate, T newItem)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));

			var itemIndex = collection.IndexOf(predicate);

			if (itemIndex == -1)
			{
				collection.Add(newItem);
			}
			else
			{
				var oldItem = collection[itemIndex];
				collection.Insert(itemIndex, newItem);
				collection.Remove(oldItem);
			}
		}

		public static int IndexOf<T>(this Collection<T> collection, Func<T, bool> predicate)
		{
			if (collection == null) throw new ArgumentNullException(nameof(collection));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));

			for (var index = 0; index < collection.Count; index++)
				if (predicate(collection[index]))
					return index;

			return -1;
		}
	}
}