using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT155_E_MID.ApptSystem.Extension
{
    public static class Extension_DataTable_AddTag
    {

        private static List<object> _ItemTagList { get; set; }   //暫存集合
        private static Dictionary<string, List<object>> _Tags { get; set; } //儲存Tag的字典，Key = cbx名, Value = Tag物件

        public static void AddItem(this DataTable t, object[] input, object setTag)
        {
            t.Rows.Add(input);

            if (_Tags == null) { _Tags = new Dictionary<string, List<object>> { }; }    //初始化字典物件

            if (_Tags.Remove(t.TableName))     //如果同combobox時，刪除已存在的Key-Value(cbx名-Tag物件)配對，以便放入新的
            { }
            else
            { _ItemTagList = new List<object>(); } //如果換了combobox時，清空暫存的list
            _ItemTagList.Add(setTag);              //將tag放入暫存list
            _Tags.Add(t.TableName, _ItemTagList);     //將list放入dictionary
        }
        public static object ItemTagGet(this DataTable t, int index)
        {
            try
            {
                return _Tags[t.TableName][index];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static void ItemTagSet(this DataTable t, int index, object setTag)
        {
            try
            {
                _Tags[t.TableName][index] = setTag;
            }
            catch (Exception)
            { }
        }
        public static void ItemTagListClear(this DataTable t)
        {
            _ItemTagList?.Clear();
        }
    }
}
