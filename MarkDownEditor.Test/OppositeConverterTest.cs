using Xunit;
using System;

namespace MarkDownEditor.Test
{
    public class OppositeConverterTest
    {
        [Fact]
        public void Test1()
        {
            object returned = opposite(1);
            Assert.Equal(-1, returned);
        }

        [Fact]
        public void Test2()
        {
            object returned = opposite(1.0);
            Assert.Equal(-1.0, returned);
        }

        [Fact]
        public void Test3()
        {
            object returned = opposite(false);
            Assert.Equal(true, returned);
        }

        [Fact]
        public void Test4()
        {
            object returned = opposite(null);
        }

        private object opposite(object obj)
        {
            if (obj.GetType() == typeof(int))
                return -(int)obj;

            if (obj.GetType() == typeof(double))
                return -(double)obj;

            if (obj.GetType() == typeof(bool))
                return !(bool)obj;

            try
            {
                double val;
                if (Double.TryParse(obj.ToString(), out val) == false)
                    throw new Exception();
                return -val;
            }
            catch (Exception)
            {
                return obj;
            }
        }

    }
}
