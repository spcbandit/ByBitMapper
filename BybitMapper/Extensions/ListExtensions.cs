using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Extensions
{
    public static class ListExtensions
    {
        public static void AddObjectIfNotNull<T>(this List<T> list, T obj)
        {
            if (obj == null) return;
            list.Add(obj);
        }
    }
}
