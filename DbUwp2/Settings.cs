using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.Storage;

namespace DbUwp2
{
    public static class Settings
    {

        private static Set _set { get; set; }


        public static async Task<IEnumerable<string>> GetStatus()
        {
            var list = new List<string>();


            foreach (var status in _set.status)
            {
                list.Add(status);
            }


            return list;

        }

        public static async void JsonSetting()
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile jsonsettings = await storageFolder.CreateFileAsync("settings.json", CreationCollisionOption.ReplaceExisting);



            jsonsettings = await storageFolder.GetFileAsync("newsettings.json");
            await FileIO.WriteTextAsync(jsonsettings, "{\"status\": [\"new\", \"active\", \"completed\"], \"maxItemsCount\": 4}");
        }


        public class Set
        {
            public string[] status { get; set; }
            public int maxItems { get; set; }
        }



        public static int GetMaxItems()
        {
            return _set.maxItems;
        }




    }
}
