using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT155_E_MID.ApptSystem.Extension
{
    public static class Extension_ListboxItem_AddTag
    {
        private static List<object> _ItemTagList { get; set; }   //暫存集合
        private static Dictionary<string, List<object>> _Tags { get; set; } //儲存Tag的字典，Key = cbx名, Value = Tag物件

        public static void AddItem(this ListBox box, object input, object setTag)
        {
            box.Items.Add(input);

            if (_Tags == null) { _Tags = new Dictionary<string, List<object>> { }; }    //初始化字典物件

            if (_Tags.Remove(box.Name))     //如果同combobox時，刪除已存在的Key-Value(cbx名-Tag物件)配對，以便放入新的
            { }
            else
            { _ItemTagList = new List<object>(); } //如果換了combobox時，清空暫存的list
            _ItemTagList.Add(setTag);              //將tag放入暫存list
            _Tags.Add(box.Name, _ItemTagList);     //將list放入dictionary
        }
        public static object ItemTagGet(this ListBox box, int index)
        {
            try
            {
                return _Tags[box.Name][index];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static void ItemTagSet(this ListBox box, int index, object setTag)
        {
            try
            {
                _Tags[box.Name][index] = setTag;
            }
            catch (Exception)
            { }
        }
        public static void ItemTagListClear(this ListBox box)
        {
            _ItemTagList?.Clear();
        }
    }
}
