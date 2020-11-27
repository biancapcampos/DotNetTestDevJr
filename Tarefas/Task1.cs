using System.Collections.Generic;

namespace Tasks
{
    public class Task1
    {
        /*
         * Dada a lista de inteiros, retorne o maior número da lista         
         */
[TestMethod] 
        public void Test1(
        {
            var result = Task1.GetMax(new List<int> { 1, 4, 3, 7, 12 });

            if (result != 12)
                Assert.Fail();
        }
            public static int? GetMax(List<int> list) { }
    }
}
