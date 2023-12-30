using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT155_E_MID.ApptSystem.Extension
{
    public static class Extension_ComboboxItem_AddTag
    {
        private static List<object> _Temp { get; set; }   //暫存集合
        private static Dictionary<string, List<object>> _Tags { get; set; } //儲存Tag的字典，Key = cbx名, Value = Tag物件

        /// <summary>
        /// combobox功能擴充: 讓item擁有tag。
        /// 將combobox同時加入item和Tag的擴充方法。
        /// </summary>
        /// <param name="cbx">目前的物件combobox</param>
        /// <param name="input">放入的物件，通常是字串</param>
        /// <param name="setTag">Tag要放入的物件</param>
        /// <author>nekojuice</author>
        /// <lastUpdate>2023.12.9-1711</lastUpdate>
        public static void AddItem(this ComboBox cbx, object input, object setTag)
        {
            cbx.Items.Add(input);

            if (_Tags == null) { _Tags = new Dictionary<string, List<object>> { }; }    //初始化字典物件

            if (_Tags.Remove(cbx.Name))     //如果同combobox時，刪除已存在的Key-Value(cbx名-Tag物件)配對，以便放入新的
            { }
            else
            { _Temp = new List<object>(); } //如果換了combobox時，清空暫存的list
            _Temp.Add(setTag);              //將tag放入暫存list
            _Tags.Add(cbx.Name, _Temp);     //將list放入dictionary
        }
        /// <summary>
        /// combobox功能擴充: 讓item擁有Tag。
        /// 取得此item的Tag，沒有則回傳null。
        /// </summary>
        /// <param name="cbx">目前的combobox</param>
        /// <param name="index">目標的item Index</param>
        /// <author>nekojuice</author>
        /// <lastUpdate>2023.12.9-1711</lastUpdate>
        public static object ItemTagGet(this ComboBox cbx, int index)
        {
            try
            {
                return _Tags[cbx.Name][index];
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// combobox功能擴充: 讓item擁有Tag。
        /// 更改此item的Tag，item要先存在。
        /// </summary>
        /// <param name="cbx">目前的combobox</param>
        /// <param name="index">目標的item Index</param>
        /// <param name="setTag">目標item要更換的Tag物件</param>
        /// <author>nekojuice</author>
        /// <lastUpdate>2023.12.9-1711</lastUpdate>
        public static void ItemTagSet(this ComboBox cbx, int index, object setTag)
        {
            try
            {
                _Tags[cbx.Name][index] = setTag;
            }
            catch (Exception)
            { }
        }
    }
}
