using System.Collections;
using System.ComponentModel;

namespace Ex216
{
    //https://docs.microsoft.com/ru-ru/dotnet/api/system.collections.ienumerator?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DRU-RU%26k%3Dk(System.Collections.IEnumerator);k(SolutionItemsProject);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.6.1);k(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.7.2

    class B : IEnumerator
    {
        int[] arr;
        private int index;

        public B(params int[] Col)
        {
           
            index = -1;

            arr = new int[Col.Length];

            for (int i = 0; i < Col.Length; i++)
            {
                arr[i] = Col[i]+1;
            }
        }

        public object Current { get { return arr[index]; } }

        public bool MoveNext()
        {
            index++;
            return index < arr.Length;
        }

        public void Reset() { index = -1; }
    }
}
