using System;
using Xunit;

using TP3;
namespace TestProject1
{
    public class UnitTestParamétré
    {
        
        [Theory]
        // chemin 2-7 -> 8 -> 26
        // chemin 2-7 -> 8 -> 9-11 -> 12 -> 25 -> 8 -> 26
        [InlineData(new int[2] { 1, 0 }, 1, new int[2] { 1, 0 })]
        // chemin 2-7 -> 8 -> 9-11 -> 12 -> 13-14 -> 15 -> 24 -> 12 -> 25 -> 8 -> 26
        [InlineData(new int[2] { 0, 1 }, 2, new int[2] { 0, 1 })]
        // chemin 2-7 -> 8 -> 9-11 -> 12 -> 13-14 -> 15 -> 16-23 -> 24 -> 12 -> 25 -> 8 -> 26
        [InlineData(new int[2] { 1, 0 }, 2, new int[2] { 0, 1 })]

        public void TestDesChemins(int[] tableau, int nombre, int[] tableauAttendu)
        {
            Class1.tri_a_bulle(ref tableau, nombre);
            //XUnit reconnait les collections
            Assert.Equal(tableauAttendu, tableau);
        }

    }
}
