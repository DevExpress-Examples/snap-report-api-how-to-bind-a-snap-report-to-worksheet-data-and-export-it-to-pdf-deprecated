using System;
using DevExpress.Spreadsheet;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using DevExpress.Office.Utils;

namespace SnapAndSpreadsheetDocumentServerExample {
    #region #XPictureProvider
    public class XPictureProvider : IBindingRangeValueConverter {
        Dictionary<string, Bitmap> pictures;

        public XPictureProvider(Worksheet sheet) {
            pictures = GetPictures(sheet);
        }

        public object ConvertToObject(CellValue value, Type requiredType, int columnIndex) {
            if (columnIndex == 13) {
                Bitmap pic;
                if (pictures.TryGetValue(value.TextValue, out pic))
                    return pic;
            }
            return value;
        }

        public CellValue TryConvertFromObject(object value) {
            return CellValue.Empty;
        }

        public Dictionary<string, Bitmap> GetPictures(Worksheet sheet) {
            Dictionary<string, Bitmap> employeePictures = new Dictionary<string, System.Drawing.Bitmap>();
            foreach (Picture pic in sheet.Pictures) {
                employeePictures.Add(pic.Name, new Bitmap(new MemoryStream(pic.Image.GetImageBytes(OfficeImageFormat.Bmp))));
            }
            return employeePictures;
        }
    }
    #endregion #XPictureProvider
}