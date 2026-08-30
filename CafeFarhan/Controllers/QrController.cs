using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace CafeFarhan.Controllers
{
    public class QrController : Controller
    {
        public IActionResult Table(int id)
        {
            var url =
                $"{Request.Scheme}://" +
                $"{Request.Host}" +
                $"/Menu?table={id}";


            using var qrGenerator =
                new QRCodeGenerator();


            using var qrData =
                qrGenerator.CreateQrCode(
                    url,
                    QRCodeGenerator.ECCLevel.Q
                );


            var pngQrCode =
                new PngByteQRCode(qrData);


            var bytes =
                pngQrCode.GetGraphic(20);


            return File(
                bytes,
                "image/png"
            );
        }
    }
}