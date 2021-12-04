using System;
using System.Collections.Generic;

namespace Ex1
{

    public class Item
    {

    }
    interface IChangeOrder
    {
        public void GetItems(List<Item> itemList);
        public void GetItemCount(List<Item> itemList);
        public void AddItem(List<Item> itemList, Item item);
        public void DeleteItem(List<Item> itemList, Item item);
    }

    class ChangeOrder : IChangeOrder
    {
        public ChangeOrder(List<Item> itemList, Item item)
        {
        }
        public void GetItems(List<Item> itemList) {/*...*/}
        public void GetItemCount(List<Item> itemList) {/*...*/}
        public void AddItem(List<Item> itemList, Item item) {/*...*/}
        public void DeleteItem(List<Item> itemList, Item item) {/*...*/}
    }

    interface ISeeOrder
    {
        public void PrintOrder(List<Item> itemList);
        public void ShowOrder(List<Item> itemList);
    }

    class SeeOrder : ISeeOrder
    {
        public SeeOrder(List<Item> itemList)
        {
        }
        public void PrintOrder(List<Item> itemList) {/*...*/}
        public void ShowOrder(List<Item> itemList) {/*...*/}
    }


    interface ISettings
    {
        public void Load(List<Item> itemList);
        public void Save(List<Item> itemList);
        public void Update(List<Item> itemList);
        public void Delete(List<Item> itemList);
    }
    class Settings : ISettings
    {
        public Settings(List<Item> itemList)
        {
        }
        public void Load(List<Item> itemList) {/*...*/}
        public void Save(List<Item> itemList) {/*...*/}
        public void Update(List<Item> itemList) {/*...*/}
        public void Delete(List<Item> itemList) {/*...*/}
    }



    class Order
    {
        public Item item1;
        private List<Item> itemList;
        private Item item;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }
            set
            {
                itemList = value;
            }
        }
        public void CalculateTotalSum() {/*...*/}
        public void Change(IChangeOrder change)
        {
            change.GetItems(this.itemList);
            change.GetItemCount(this.itemList);
            change.AddItem(this.itemList, this.item);
            change.DeleteItem(this.itemList, this.item);
        }

        public void See(ISeeOrder see)
        {
            see.PrintOrder(this.itemList);
            see.ShowOrder(this.itemList);
        }

        public void Setting(ISettings setting)
        {
            setting.Load(this.itemList);
            setting.Save(this.itemList);
            setting.Update(this.itemList);
            setting.Delete(this.itemList);
        }

        class Program
        {
            static void Main(string[] args)
            {

            }
        }

    }
}