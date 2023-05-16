using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class LRUCacheTest
    {
        [Fact]
        public void Update_AddValue_ReceiveValuesSuccess()
        {
            var cahce = new LRUCache<string, string>();
            cahce.Update("Key1", "Value1");
            cahce.Update("Key2", "Value2");
            cahce.Update("Key3", "Value3");

            Assert.Equal(3, cahce.Length);
            Assert.Equal("Value3", cahce.Get("Key3"));
            Assert.Equal("Value2", cahce.Get("Key2"));
            Assert.Equal("Value1", cahce.Get("Key1"));
        }

        [Fact]
        public void Get_AddNoValue_Success()
        {
            var cahce = new LRUCache<string, string>();
           

            Assert.Equal(0, cahce.Length);
            Assert.Null(cahce.Get("Key3"));
        }

        [Fact]
        public void Update_AddValuesOverCapacity_Success()
        {
            var cahce = new LRUCache<string, string>(2);
            cahce.Update("Key1", "Value1");
            cahce.Update("Key2", "Value2");
            cahce.Update("Key3", "Value3");

            Assert.Equal(2, cahce.Length);
            Assert.Equal("Value3", cahce.Get("Key3"));
            Assert.Equal("Value2", cahce.Get("Key2"));
            Assert.Null(cahce.Get("Key1"));
        }

        [Fact]
        public void Update_ChangeExistingValue_Success()
        {
            var cahce = new LRUCache<string, string>();
            cahce.Update("Key1", "Value1");
            cahce.Update("Key2", "Value2");
            cahce.Update("Key3", "Value3");

            cahce.Update("Key1", "Value11");

            Assert.Equal(3, cahce.Length);
            Assert.Equal("Value3", cahce.Get("Key3"));
            Assert.Equal("Value2", cahce.Get("Key2"));
            Assert.Equal("Value11", cahce.Get("Key1"));
        }
    }
}
