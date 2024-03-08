using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Mobile;
namespace TrainGo.Services
{
    public class ScanQR
    {

        /// <summary>
        /// Method to scan qr/bar codes
        /// </summary>
        /// <returns>the data from the qr code</returns>
        public async Task<Result> ScanQRCode()
        {
            var scanner = new MobileBarcodeScanner();
            scanner.TopText = "Enfoca el codigo!";
            var result = await scanner.Scan();
            return result;                       
        }

    }
}
