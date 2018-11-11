using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BigBang
{
    public class ImageHelper
    {
        static Dictionary<string, int> imageDictionary = new Dictionary<string, int>();
        public static int ImageDrawable(string drawableName)
        {
            int imageValue = -1;

            if (imageDictionary.ContainsKey(drawableName))
            {
                imageValue = imageDictionary[drawableName];
            }
            else
            {
                Type drawableType = typeof(Resource.Drawable);
                FieldInfo imageFieldInfo = drawableType.GetField(drawableName);
                imageValue = (int)imageFieldInfo.GetValue(null);

                imageDictionary.Add(drawableName, imageValue);
            }
            return imageValue;
        }
    }
}