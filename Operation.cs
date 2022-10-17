using BarcodeLib;
using IronBarCode;
using System.Drawing;
using System.Drawing.Imaging;
using BarcodeReader = IronBarCode.BarcodeReader;

namespace BarcodeGenerator
{
    public class Operation
    {
        public void GenerateBarcode(string numericString)
		{
            Barcode barcodeLib = new();

            int imageWidth = 250;
            int imageHeight = 110;
            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;

            Image barcodeImage = barcodeLib.Encode(TYPE.UPCA, numericString,
            foreColor, backColor, imageWidth, imageHeight);

            barcodeImage.Save(@"C:\Users\ugurcanyagmur\Projects\BarcodeGenarator\Barcode.png", ImageFormat.Png);
        }

        public void ReadBarcode(string path)
        {

            BarcodeResult barcodeResult = BarcodeReader.QuicklyReadOneBarcode(path);
            Console.WriteLine("Barkod numaranız: " + barcodeResult.Text);
          
        }
    }
}